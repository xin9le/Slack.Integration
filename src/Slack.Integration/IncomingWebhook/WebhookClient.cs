using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Slack.Integration.IncomingWebhook;



/// <summary>
/// Provides incoming webhook client. 
/// </summary>
public class WebhookClient : IDisposable
{
    #region Fields
    private readonly HttpClient _client;
    private readonly bool _needsDispose;
    #endregion


    #region Constructors
    /// <summary>
    /// Creates instance.
    /// </summary>
    public WebhookClient()
    {
        this._client = new HttpClient();
        this._needsDispose = true;
    }


    /// <summary>
    /// Creates instance.
    /// </summary>
    /// <param name="client"></param>
    public WebhookClient(HttpClient client)
    {
        this._client = client;
        this._needsDispose = false;
    }


    /// <summary>
    /// Destroy instance.
    /// </summary>
    ~WebhookClient()
        => this.Dispose();
    #endregion


    #region IDisposable
    /// <summary>
    /// Releases the used resources.
    /// </summary>
    public void Dispose()
    {
        if (!this._needsDispose)
            return;

        if (this._isDisposed)
            return;

        this._client.Dispose();
        this._isDisposed = true;
        GC.SuppressFinalize(this);
    }
    private bool _isDisposed = false;
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
        var response = await this._client.PostAsJsonAsync(url, payload, cancellationToken).ConfigureAwait(false);
#if NET5_0_OR_GREATER
        var result = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
        var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif
        return result.ToResultCode();
    }
    #endregion
}
