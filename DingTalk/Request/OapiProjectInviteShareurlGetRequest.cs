using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.project.invite.shareurl.get
    /// </summary>
    public class OapiProjectInviteShareurlGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProjectInviteShareurlGetResponse>
    {
        /// <summary>
        /// 邀请信息
        /// </summary>
        public string InviteInfo { get; set; }

        public InviteUrlQueryDomain InviteInfo_ { set { this.InviteInfo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.project.invite.shareurl.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("invite_info", this.InviteInfo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("invite_info", this.InviteInfo);
        }

	/// <summary>
/// InviteUrlQueryDomain Data Structure.
/// </summary>
[Serializable]

public class InviteUrlQueryDomain : TopObject
{
	        /// <summary>
	        /// 圈子里关联的某个群ID
	        /// </summary>
	        [XmlElement("chat_id")]
	        public string ChatId { get; set; }
	
	        /// <summary>
	        /// 该分享链接有效时间，以秒为单位。 最大不超过7776000（即90天），此字段如果不填，则默认有效期为30秒。
	        /// </summary>
	        [XmlElement("expire_seconds")]
	        public Nullable<long> ExpireSeconds { get; set; }
	
	        /// <summary>
	        /// 活动生效后的承接页面标志
	        /// </summary>
	        [XmlElement("redirect")]
	        public string Redirect { get; set; }
	
	        /// <summary>
	        /// 场景标志，用于区分活动场景
	        /// </summary>
	        [XmlElement("scene_id")]
	        public string SceneId { get; set; }
	
	        /// <summary>
	        /// 期限类型：SHORT短期（默认），LONG长期（最多10万个数量限制）
	        /// </summary>
	        [XmlElement("term_type")]
	        public string TermType { get; set; }
	
	        /// <summary>
	        /// 邀请人的员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
