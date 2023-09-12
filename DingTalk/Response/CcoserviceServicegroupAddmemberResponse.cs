using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CcoserviceServicegroupAddmemberResponse.
    /// </summary>
    public class CcoserviceServicegroupAddmemberResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AddMembersResponseModelDomain Result { get; set; }

	/// <summary>
/// AddMembersResponseModelDomain Data Structure.
/// </summary>
[Serializable]

public class AddMembersResponseModelDomain : TopObject
{
	        /// <summary>
	        /// dingtalkId
	        /// </summary>
	        [XmlElement("dingtalk_id")]
	        public string DingtalkId { get; set; }
}

    }
}
