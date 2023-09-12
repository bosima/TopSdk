using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.sendbytemplate
    /// </summary>
    public class OapiMessageCorpconversationSendbytemplateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationSendbytemplateResponse>
    {
        /// <summary>
        /// 微应用的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 消息模板动态参数赋值数据, key和value均为字符串格式。
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 接收者的部门id列表
        /// </summary>
        public string DeptIdList { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// 接收者的用户userid列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.sendbytemplate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("data", this.Data);
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 500);
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 5000);
        }

        #endregion
    }
}
