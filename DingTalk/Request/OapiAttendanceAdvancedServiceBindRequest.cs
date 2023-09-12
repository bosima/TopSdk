using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.advanced.service.bind
    /// </summary>
    public class OapiAttendanceAdvancedServiceBindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceAdvancedServiceBindResponse>
    {
        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        public string Param { get; set; }

        public BindParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.advanced.service.bind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// BindParamDomain Data Structure.
/// </summary>
[Serializable]

public class BindParamDomain : TopObject
{
	        /// <summary>
	        /// 有效期结束时间，时间戳
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 实体id
	        /// </summary>
	        [XmlElement("entity_id")]
	        public string EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型，当前支持user,group,corp
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 绑定名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 服务id
	        /// </summary>
	        [XmlElement("service_id")]
	        public Nullable<long> ServiceId { get; set; }
	
	        /// <summary>
	        /// 有效期开始时间，时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<long> StartTime { get; set; }
}

        #endregion
    }
}
