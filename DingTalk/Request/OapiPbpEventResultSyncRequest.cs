using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.event.result.sync
    /// </summary>
    public class OapiPbpEventResultSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpEventResultSyncResponse>
    {
        /// <summary>
        /// 打卡事件结果模型
        /// </summary>
        public string Param { get; set; }

        public UserEventResultOapiRequestVoDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.event.result.sync";
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
/// PositionOapiVoDomain Data Structure.
/// </summary>
[Serializable]

public class PositionOapiVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡成功的位置点id
	        /// </summary>
	        [XmlElement("position_id")]
	        public string PositionId { get; set; }
	
	        /// <summary>
	        /// 打卡成功的位置类型
	        /// </summary>
	        [XmlElement("position_type")]
	        public Nullable<long> PositionType { get; set; }
}

	/// <summary>
/// UserEventResultOapiRequestVoDomain Data Structure.
/// </summary>
[Serializable]

public class UserEventResultOapiRequestVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡业务代码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
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
	        /// 是否失效当前事件，不可重复打卡:true，可重复打卡:false
	        /// </summary>
	        [XmlElement("invalid_event")]
	        public Nullable<bool> InvalidEvent { get; set; }
	
	        /// <summary>
	        /// 打卡成功的位置信息
	        /// </summary>
	        [XmlElement("punch_position")]
	        public PositionOapiVoDomain PunchPosition { get; set; }
	
	        /// <summary>
	        /// 打卡事件结果，2:成功，3:失败
	        /// </summary>
	        [XmlElement("result")]
	        public Nullable<long> Result { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
