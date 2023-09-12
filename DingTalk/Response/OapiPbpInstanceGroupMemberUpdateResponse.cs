using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPbpInstanceGroupMemberUpdateResponse.
    /// </summary>
    public class OapiPbpInstanceGroupMemberUpdateResponse : DingTalkResponse
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
        /// 打卡组id
        /// </summary>
        [XmlElement("punch_group_id")]
        public string PunchGroupId { get; set; }

    }
}
