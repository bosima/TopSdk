using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmObjectdataCustomerDeleteResponse.
    /// </summary>
    public class OapiCrmObjectdataCustomerDeleteResponse : DingTalkResponse
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
        /// 删除结果
        /// </summary>
        [XmlElement("result")]
        public ObjectDataDeleteDtoDomain Result { get; set; }

	/// <summary>
/// ObjectDataDeleteDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ObjectDataDeleteDtoDomain : TopObject
{
	        /// <summary>
	        /// 删除的客户实例ID
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
}

    }
}
