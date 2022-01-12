using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Utf8Json;

namespace Slack.Integration.IncomingWebhook;



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


    /// <summary>
    /// Destroy instance.
    /// </summary>
    ~WebhookClient()
        => this.Dispose();
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
        GC.SuppressFinalize(this);
    }
    private bool isDisposed = false;
    #endregion


    #region Methods
    /// <summary>
    /// Send a specified payload to Slack.
    /// </summary>
    /// <param name="url"></param>
    /// <param name="payload"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultCode> SendAsync(string url, Payload payload, CancellationToken cancellationToken = default)
    {
        if (url == null) throw new ArgumentNullException(nameof(url));
        if (payload == null) throw new ArgumentNullException(nameof(payload));

        var json = JsonSerializer.Serialize(payload);
        using (var content = new ByteArrayContent(json))
        {
            content.Headers.ContentType = new("application/json");
            var response = await this.Client.PostAsync(url, content, cancellationToken).ConfigureAwait(false);
#if NET5_0_OR_GREATER
            var result = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif
            return result.ToResultCode();
        }
    }
    #endregion
}
