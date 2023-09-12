using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.event.delete
    /// </summary>
    public class OapiPbpEventDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpEventDeleteResponse>
    {
        /// <summary>
        /// 打卡事件参数模型
        /// </summary>
        public string Param { get; set; }

        public UserEventOapiRequestVoDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.event.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// UserEventOapiVoDomain Data Structure.
/// </summary>
[Serializable]

public class UserEventOapiVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡业务实例id
	        /// </summary>
	        [XmlElement("biz_inst_id")]
	        public string BizInstId { get; set; }
	
	        /// <summary>
	        /// 打卡事件外部id，唯一键
	        /// </summary>
	        [XmlElement("event_id")]
	        public string EventId { get; set; }
	
	        /// <summary>
	        /// 打卡事件名称
	        /// </summary>
	        [XmlElement("event_name")]
	        public string EventName { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// UserEventOapiRequestVoDomain Data Structure.
/// </summary>
[Serializable]

public class UserEventOapiRequestVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡业务代码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 打卡事件列表
	        /// </summary>
	        [XmlArray("user_event_list")]
	        [XmlArrayItem("user_event_oapi_vo")]
	        public List<UserEventOapiVoDomain> UserEventList { get; set; }
}

        #endregion
    }
}
