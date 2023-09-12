using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.nick.batchupdate
    /// </summary>
    public class OapiChatNickBatchupdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatNickBatchupdateResponse>
    {
        /// <summary>
        /// 会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// userId和nick的模型
        /// </summary>
        public string UserNickModel { get; set; }

        public List<OpenStaffIdAndNickModelDomain> UserNickModel_ { set { this.UserNickModel = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.nick.batchupdate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("user_nick_model", this.UserNickModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("user_nick_model", this.UserNickModel);
            RequestValidator.ValidateObjectMaxListSize("user_nick_model", this.UserNickModel, 500);
        }

	/// <summary>
/// OpenStaffIdAndNickModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenStaffIdAndNickModelDomain : TopObject
{
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
