using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessApproversForecastResponse.
    /// </summary>
    public class OapiProcessApproversForecastResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("process_forecast_response")]
        public List<ProcessForecastResponseDomain> Result { get; set; }

	/// <summary>
/// UserProfileVoDomain Data Structure.
/// </summary>
[Serializable]

public class UserProfileVoDomain : TopObject
{
	        /// <summary>
	        /// 审批人姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 审批人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ProcessForecastResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessForecastResponseDomain : TopObject
{
	        /// <summary>
	        /// 审批人列表
	        /// </summary>
	        [XmlArray("approvers")]
	        [XmlArrayItem("user_profile_vo")]
	        public List<UserProfileVoDomain> Approvers { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("node_name")]
	        public string NodeName { get; set; }
	
	        /// <summary>
	        /// 节点展示名称
	        /// </summary>
	        [XmlElement("node_show_name")]
	        public string NodeShowName { get; set; }
}

    }
}
