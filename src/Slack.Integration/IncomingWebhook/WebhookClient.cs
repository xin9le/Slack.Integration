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
    public class WebhookClient : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets a <see cref="HttpClient"/>.
        /// </summary>
        private HttpClient Client { get; }


        /// <summary>
        /// Gets whether the <see cref="IDisposable.Dispose"/> method needs to be called.
        /// </summary>
        private bool NeedsDispose { get; }
        #endregion


        #region Constructors
        /// <summary>
        /// Creates instance.
        /// </summary>
        /// <param name="client"></param>
        public WebhookClient()
        {
            this.Client = new HttpClient();
            this.NeedsDispose = true;
        }


        /// <summary>
        /// Creates instance.
        /// </summary>
        /// <param name="client"></param>
        public WebhookClient(HttpClient client)
        {
            this.Client = client;
            this.NeedsDispose = false;
        }
        #endregion


        #region IDisposable implementations
        /// <summary>
        /// Releases the used resources.
        /// </summary>
        public void Dispose()
        {
            if (!this.NeedsDispose)
                return;

            if (this.isDisposed)
                return;

            this.Client.Dispose();
            this.isDisposed = true;
        }
        private bool isDisposed = false;
        #endregion


        #region Methods
        /// <summary>
        /// Send a specified payload to Slack.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="payload"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<ResultCode> SendAsync(string url, Payload payload, CancellationToken token = default)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));
            if (payload == null) throw new ArgumentNullException(nameof(payload));

            var json = JsonSerializer.Serialize(payload);
            using (var content = new ByteArrayContent(json))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await this.Client.PostAsync(url, content, token).ConfigureAwait(false);
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return result.ToResultCode();
            }   
        }
        #endregion
    }
}
