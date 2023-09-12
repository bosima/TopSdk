using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOrgpaasOrgInfoGetResponse.
    /// </summary>
    public class OapiOrgpaasOrgInfoGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码 -1 系统异常 40035 参数错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 组织信息
        /// </summary>
        [XmlElement("result")]
        public GetOrgInfoRespDomain Result { get; set; }

        /// <summary>
        /// 接口是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GetOrgInfoRespDomain Data Structure.
/// </summary>
[Serializable]

public class GetOrgInfoRespDomain : TopObject
{
	        /// <summary>
	        /// 组织附件信息
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 组织名
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
}

    }
}
