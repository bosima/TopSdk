using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessTemplateUpgradeinfoQueryResponse.
    /// </summary>
    public class OapiProcessTemplateUpgradeinfoQueryResponse : DingTalkResponse
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
        /// List<Object>类型，Object含processCode和canBeUpgraded两个属性
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 是否可升级
	        /// </summary>
	        [XmlElement("can_be_upgraded")]
	        public bool CanBeUpgraded { get; set; }
	
	        /// <summary>
	        /// 模板code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

    }
}
