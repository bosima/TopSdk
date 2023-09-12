using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFaceFeatureResponse.
    /// </summary>
    public class OapiSmartdeviceFaceFeatureResponse : DingTalkResponse
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
        /// 父对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("dido_feature_vo")]
        public List<DidoFeatureVoDomain> Result { get; set; }

	/// <summary>
/// DidoFeatureVoDomain Data Structure.
/// </summary>
[Serializable]

public class DidoFeatureVoDomain : TopObject
{
	        /// <summary>
	        /// 特征值
	        /// </summary>
	        [XmlElement("feature_info")]
	        public string FeatureInfo { get; set; }
	
	        /// <summary>
	        /// 用户ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
