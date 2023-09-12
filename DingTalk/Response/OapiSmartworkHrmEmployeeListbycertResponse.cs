using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeListbycertResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeListbycertResponse : DingTalkResponse
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
        /// 结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("simple_emp_personal_info_vo")]
        public List<SimpleEmpPersonalInfoVoDomain> Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SimpleEmpPersonalInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleEmpPersonalInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 身份证号
	        /// </summary>
	        [XmlElement("cert_no")]
	        public string CertNo { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
