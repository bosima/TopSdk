using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.robot.update
    /// </summary>
    public class OapiDingmiRobotUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiRobotUpdateResponse>
    {
        /// <summary>
        /// 服务号(1) | 群(2)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string UpdateBotModel { get; set; }

        public UpdateBotRequestDTODomain UpdateBotModel_ { set { this.UpdateBotModel = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.robot.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("type", this.Type);
            parameters.Add("update_bot_model", this.UpdateBotModel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("update_bot_model", this.UpdateBotModel);
        }

	/// <summary>
/// UpdateBotRequestDTODomain Data Structure.
/// </summary>
[Serializable]

public class UpdateBotRequestDTODomain : TopObject
{
	        /// <summary>
	        /// 头像资源ID
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 机器人简介描述
	        /// </summary>
	        [XmlElement("brief")]
	        public string Brief { get; set; }
	
	        /// <summary>
	        /// 对机器人的描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 机器人名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 预览图资源地址
	        /// </summary>
	        [XmlElement("preview_media_url")]
	        public string PreviewMediaUrl { get; set; }
}

        #endregion
    }
}
