using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.add_to_single_chat
    /// </summary>
    public class OapiCspaceAddToSingleChatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAddToSingleChatResponse>
    {
        /// <summary>
        /// 文件接收人的userid
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 文件名(需包含含扩展名),需要utf-8 urlEncode
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 调用钉盘上传文件接口得到的mediaid,需要utf-8 urlEncode
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 文件发送者微应用的agentId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.add_to_single_chat";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("file_name", this.FileName);
            parameters.Add("media_id", this.MediaId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
