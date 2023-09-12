using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessWorkrecordCreateResponse.
    /// </summary>
    public class OapiProcessWorkrecordCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 0
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 实例信息
        /// </summary>
        [XmlElement("result")]
        public SaveFaceProcessInstanceResponseDomain Result { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SaveFaceProcessInstanceResponseDomain Data Structure.
/// </summary>
[Serializable]

public class SaveFaceProcessInstanceResponseDomain : TopObject
{
	        /// <summary>
	        /// 审批实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
}

    }
}
