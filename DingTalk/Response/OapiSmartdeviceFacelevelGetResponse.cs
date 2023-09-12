using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFacelevelGetResponse.
    /// </summary>
    public class OapiSmartdeviceFacelevelGetResponse : DingTalkResponse
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
        /// 父对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("face_result_vo")]
        public List<FaceResultVoDomain> Result { get; set; }

	/// <summary>
/// FaceResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class FaceResultVoDomain : TopObject
{
	        /// <summary>
	        /// 员工认证姓名
	        /// </summary>
	        [XmlElement("certify_name")]
	        public string CertifyName { get; set; }
	
	        /// <summary>
	        /// 实人认证结果 1:已实名 3:已实人 4:管理员通过
	        /// </summary>
	        [XmlElement("certify_type")]
	        public long CertifyType { get; set; }
	
	        /// <summary>
	        /// 有人脸
	        /// </summary>
	        [XmlElement("has_face")]
	        public bool HasFace { get; set; }
	
	        /// <summary>
	        /// 人脸最后更新时间
	        /// </summary>
	        [XmlElement("last_modified")]
	        public string LastModified { get; set; }
	
	        /// <summary>
	        /// 当前操作人的userid
	        /// </summary>
	        [XmlElement("operator_userid")]
	        public string OperatorUserid { get; set; }
	
	        /// <summary>
	        /// 当前操作人的姓名
	        /// </summary>
	        [XmlElement("operator_username")]
	        public string OperatorUsername { get; set; }
	
	        /// <summary>
	        /// 用户staffid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
