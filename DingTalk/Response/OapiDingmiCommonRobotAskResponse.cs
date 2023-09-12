using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingmiCommonRobotAskResponse.
    /// </summary>
    public class OapiDingmiCommonRobotAskResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 需将示例值转成json,示例中包含两个json字符串，分别在"}或{"前后，请分别解析，这两种数据格式表示调用方需要解析的两种数据结构 请注意，answerContent表示从机器人获取到了问题答案，recommendAnswerContent表示只获取到了推荐问题，请在解析的时候做判断，若有疑问请与api开发者联系
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
