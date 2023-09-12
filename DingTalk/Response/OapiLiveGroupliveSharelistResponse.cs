using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveSharelistResponse.
    /// </summary>
    public class OapiLiveGroupliveSharelistResponse : DingTalkResponse
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
        /// 返回的分享群列表
        /// </summary>
        [XmlArray("share_cid_list")]
        [XmlArrayItem("string")]
        public List<string> ShareCidList { get; set; }

    }
}
