using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Utf8Json;



namespace Slack.Integration.IncomingWebhook
{
    /// <summary>
    /// Provides incoming webhook client. 
    /// </summary>
    public class WebhookClient
    {
        /// <summary>
        /// Gets a <see cref="HttpClient"/>.
        /// </summary>
        private HttpClient Client { get; }


        /// <summary>
        /// Creates instance.
        /// </summary>
        /// <param name="client"></param>
        public WebhookClient(HttpClient client)
            => this.Client = client;


        /// <summary>
        /// Send a specified payload to Slack.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="payload"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task SendAsync(string url, Payload payload, CancellationToken token = default)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (payload == null) throw new ArgumentNullException(nameof(payload));

            var json = JsonSerializer.Serialize(payload);
            using (var content = new ByteArrayContent(json))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await this.Client.PostAsync(url, content, token).ConfigureAwait(false);
                await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }   
        }
    }
}
