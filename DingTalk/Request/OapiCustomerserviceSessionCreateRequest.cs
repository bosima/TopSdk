using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.session.create
    /// </summary>
    public class OapiCustomerserviceSessionCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceSessionCreateResponse>
    {
        /// <summary>
        /// 新建会话参数
        /// </summary>
        public string CreateSession { get; set; }

        public CreateSessionDTODomain CreateSession_ { set { this.CreateSession = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.session.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_session", this.CreateSession);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("create_session", this.CreateSession);
        }

	/// <summary>
/// SessionSourceDTODomain Data Structure.
/// </summary>
[Serializable]

public class SessionSourceDTODomain : TopObject
{
	        /// <summary>
	        /// /**      * H5页面      */     H5(0),     /**      * APP内嵌的链接      */     APP(1),     /**      * 微信小程序      */     WE_CHAT_APPLETS(2),     /**      * 微信公众号      */     WE_CHAT_OFFICIAL_ACCOUNTS(3)
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 发起咨询的头像
	        /// </summary>
	        [XmlElement("channel_avatar_url")]
	        public string ChannelAvatarUrl { get; set; }
	
	        /// <summary>
	        /// 渠道名称
	        /// </summary>
	        [XmlElement("channel_nick")]
	        public string ChannelNick { get; set; }
	
	        /// <summary>
	        /// 渠道会员id
	        /// </summary>
	        [XmlElement("channel_uid")]
	        public string ChannelUid { get; set; }
	
	        /// <summary>
	        /// 渠道会员所属的系统
	        /// </summary>
	        [XmlElement("channel_user_source")]
	        public string ChannelUserSource { get; set; }
	
	        /// <summary>
	        /// 会员id
	        /// </summary>
	        [XmlElement("cms_id")]
	        public string CmsId { get; set; }
	
	        /// <summary>
	        /// 会话结束时间
	        /// </summary>
	        [XmlElement("session_end_time")]
	        public Nullable<long> SessionEndTime { get; set; }
	
	        /// <summary>
	        /// 会话来源
	        /// </summary>
	        [XmlElement("session_source")]
	        public string SessionSource { get; set; }
	
	        /// <summary>
	        /// 会话开始时间
	        /// </summary>
	        [XmlElement("session_start_time")]
	        public Nullable<long> SessionStartTime { get; set; }
	
	        /// <summary>
	        /// 0会话中，1已结束
	        /// </summary>
	        [XmlElement("session_status")]
	        public Nullable<long> SessionStatus { get; set; }
	
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("sid")]
	        public string Sid { get; set; }
	
	        /// <summary>
	        /// 会话摘要
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
}

	/// <summary>
/// SessionTargetDTODomain Data Structure.
/// </summary>
[Serializable]

public class SessionTargetDTODomain : TopObject
{
	        /// <summary>
	        /// 业务单元id
	        /// </summary>
	        [XmlElement("bu_id")]
	        public string BuId { get; set; }
	
	        /// <summary>
	        /// 钉钉的corpId
	        /// </summary>
	        [XmlElement("ding_corp_id")]
	        public string DingCorpId { get; set; }
	
	        /// <summary>
	        /// 实例的id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 1，智能客服；1001，经济体版本
	        /// </summary>
	        [XmlElement("production_type")]
	        public Nullable<long> ProductionType { get; set; }
	
	        /// <summary>
	        /// 服务编号
	        /// </summary>
	        [XmlElement("service_id")]
	        public string ServiceId { get; set; }
	
	        /// <summary>
	        /// 会话来源
	        /// </summary>
	        [XmlElement("session_source")]
	        public string SessionSource { get; set; }
}

	/// <summary>
/// CreateSessionDTODomain Data Structure.
/// </summary>
[Serializable]

public class CreateSessionDTODomain : TopObject
{
	        /// <summary>
	        /// 会员来源
	        /// </summary>
	        [XmlElement("source")]
	        public SessionSourceDTODomain Source { get; set; }
	
	        /// <summary>
	        /// 会话目标
	        /// </summary>
	        [XmlElement("target")]
	        public SessionTargetDTODomain Target { get; set; }
}

        #endregion
    }
}
