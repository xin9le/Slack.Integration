# Slack.Integration

This library provides Slack APIs. You can integrate your service and Slack. Currently support is only Incoming Webhook.

- Incoming Webhook
- Slash Command
- Easy to pass known colors and emojis

[![Releases](https://img.shields.io/github/release/xin9le/Slack.Integration.svg)](https://github.com/xin9le/Slack.Integration/releases)
[![GitHub license](https://img.shields.io/github/license/xin9le/Slack.Integration)](https://github.com/xin9le/Slack.Integration/blob/master/LICENSE)


## Support Platform

- .NET Framework 4.6.1+
- .NET Standard 2.0+
- .NET 5.0+



## Incoming Webhook

Super easy to use.

```cs
var url = "<Your Incoming Webhook URL here.>";
var payload = new Payload { Text = "Hello, Slack!!" };
var client = new WebhookClient();
await client.SendAsync(url, payload);
```

Following is payload sample.

```cs
var payload = new Payload
{
    UserName = "Incoming Webhook",
    Text = "Hello, @xin9le !!\n\nThis posts is test for _Incoming WebHook_ .\nDocument is <https://api.slack.com/incoming-webhooks|here>.",
    Markdown = true,
    Channel = "#random",  // override channel
    LinkNames = true,
    IconEmoji = KnownEmoji.PlusOne,
    Attachments = new []
    {
        new Attachment
        {
            Fallback = "脱・読みづらいコード！今日から一段上のプログラマーになる方法 5 選",
            Color = Color.AliceBlue.ToHex(),
            PreText = "This text is optional that is displayed at the top of _attachment block_ .",
            AuthorName = "xin9le",
            AuthorLink = "http://xin9le.net",
            AuthorIcon = "https://pbs.twimg.com/profile_images/1047114972118114305/vw07RO7H_normal.jpg",
            Title = "脱・読みづらいコード！今日から一段上のプログラマーになる方法 5 選",
            TitleLink = "http://blog.xin9le.net/entry/2016/02/26/043557",
            Text = "「ソースコードを綺麗に書く」というのは、プログラマーであれば誰しもが心掛けたいと思っている *極めて重要な事柄* です。そもそも「綺麗なコードってなんぞ？」という感じですが、いくつかあると思います。",
            ImageUrl = "http://cdn-ak.f.st-hatena.com/images/fotolife/x/xin9le/20160226/20160226040749.png",
            ThumbUrl = "https://pbs.twimg.com/profile_images/1047114972118114305/vw07RO7H_normal.jpg",
            Footer = "xin9le",
            FooterIcon = "https://pbs.twimg.com/profile_images/1047114972118114305/vw07RO7H_normal.jpg",
            Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds(),
            Fields = new []
            {
                new Field
                {
                    Title = "Unique User",
                    Value = "345",
                    Short = true,
                },
                new Field
                {
                    Title = "Page View",
                    Value = "12345",
                    Short = true,
                },
            },
            Actions = new []
            {
                new Slack.Integration.IncomingWebhook.Action
                {
                    Type = ActionType.Button,
                    Text = "GitHub",
                    Url = "https://github.com/xin9le",
                    Style = ActionStyle.Default,
                },
                new Slack.Integration.IncomingWebhook.Action
                {
                    Type = ActionType.Button,
                    Text = "Blog",
                    Url = "https://blog.xin9le.net",
                    Style = ActionStyle.Primary,
                },
                new Slack.Integration.IncomingWebhook.Action
                {
                    Type = ActionType.Button,
                    Text = "Twitter",
                    Url = "https://twitter.com/xin9le",
                    Style = ActionStyle.Danger,
                },
            },
        },
    },
};
```

![2018-11-29 15 49 39](https://user-images.githubusercontent.com/4776688/49205381-344e9300-f3f2-11e8-8849-cd446dd2a6d4.png)



## Slash Command

Slash Command requests sent from Slack can be mapped as follows.

```cs
using Microsoft.AspNetCore.Mvc;
using Slack.Integration.SlashCommand;

public class SlashCommandController : Controller
{
    [HttpPost]
    public IAsyncResult DoSomething([FromForm]Request request)  // request mapping
    {
        // do something
        return this.Ok();
    }
}
```



## Installation

Getting started from downloading [NuGet](https://www.nuget.org/packages/Slack.Integration) package.

```
dotnet add package Slack.Integration
```



## License

This library is provided under [MIT License](http://opensource.org/licenses/MIT).



## Author

Takaaki Suzuki (a.k.a [@xin9le](https://twitter.com/xin9le)) is software developer in Japan who awarded Microsoft MVP for Developer Technologies (C#) since July 2012.

