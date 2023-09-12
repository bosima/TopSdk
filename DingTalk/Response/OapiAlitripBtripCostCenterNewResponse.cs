using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripCostCenterNewResponse.
    /// </summary>
    public class OapiAlitripBtripCostCenterNewResponse : DingTalkResponse
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
        /// 成本中心对象
        /// </summary>
        [XmlElement("result")]
        public OpenCostCenterSaveRsDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCostCenterSaveRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterSaveRsDomain : TopObject
{
	        /// <summary>
	        /// 商旅横版中心id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

    }
}
