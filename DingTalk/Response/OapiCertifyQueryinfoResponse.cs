using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCertifyQueryinfoResponse.
    /// </summary>
    public class OapiCertifyQueryinfoResponse : DingTalkResponse
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
        public YunQi2018CertifyVODomain Result { get; set; }

	/// <summary>
/// YunQi2018CertifyVODomain Data Structure.
/// </summary>
[Serializable]

public class YunQi2018CertifyVODomain : TopObject
{
	        /// <summary>
	        /// 实名时的脸图
	        /// </summary>
	        [XmlElement("certify_face_image")]
	        public string CertifyFaceImage { get; set; }
	
	        /// <summary>
	        /// 是否已实名
	        /// </summary>
	        [XmlElement("has_certify")]
	        public bool HasCertify { get; set; }
	
	        /// <summary>
	        /// 是否需要补录脸
	        /// </summary>
	        [XmlElement("need_enter_face")]
	        public bool NeedEnterFace { get; set; }
}

    }
}
