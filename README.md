# TopSdk
钉钉旧版服务端SDK改造版：项目框架调整为 .netstandard 2.0；增加异步请求接口。

原始代码来源：https://open.dingtalk.com/document/isvapp/download-the-server-side-sdk-2

## 使用方法

```
IAsyncDingTalkClient client = new AsyncDefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
OapiUserGetRequest req = new OapiUserGetRequest();
req.Userid = "userid1";
req.SetHttpMethod("GET");
OapiUserGetResponse rsp = await client.ExecuteAsync(req, accessToken)
```

## 注意：

1、源代码是从钉钉开放平台页面公开下载的，其中没有 License 文件，但是从公开下载的行为看，应该是允许修改的，且本人也没有售卖此代码。如有侵权，请联系删除此仓库。

2、源代码是基于 .net framework 2.0 改造的，改造过程中用到了 SocketsHttpHandler，.netstandard 2.0本身不支持这个类，用了三方的 [StandardSocketsHttpHandler](https://github.com/TalAloni/StandardSocketsHttpHandler)。

3、虽然本人使用正常，但未做全面测试，使用前请谨慎测试评估，因使用此仓库代码造成的损失，本人概不负责。


