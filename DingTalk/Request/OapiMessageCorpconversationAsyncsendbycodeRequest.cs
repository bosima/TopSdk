using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.message.corpconversation.asyncsendbycode
    /// </summary>
    public class OapiMessageCorpconversationAsyncsendbycodeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMessageCorpconversationAsyncsendbycodeResponse>
    {
        /// <summary>
        /// 微应用的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 用户操作产生的授权码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 接收者的部门id列表
        /// </summary>
        public string DeptIdList { get; set; }

        /// <summary>
        /// 与msgtype对应的消息体，具体见文档
        /// </summary>
        public string Msgcontent { get; set; }

        /// <summary>
        /// 消息类型,如text、file、oa等，具体见文档
        /// </summary>
        public string Msgtype { get; set; }

        /// <summary>
        /// 是否发送给企业全部用户
        /// </summary>
        public Nullable<bool> ToAllUser { get; set; }

        /// <summary>
        /// 接收者的用户userid列表
        /// </summary>
        public string UserIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.message.corpconversation.asyncsendbycode";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("code", this.Code);
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("msgcontent", this.Msgcontent);
            parameters.Add("msgtype", this.Msgtype);
            parameters.Add("to_all_user", this.ToAllUser);
            parameters.Add("user_id_list", this.UserIdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("code", this.Code);
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 20);
            RequestValidator.ValidateRequired("msgcontent", this.Msgcontent);
            RequestValidator.ValidateRequired("msgtype", this.Msgtype);
            RequestValidator.ValidateMaxListSize("user_id_list", this.UserIdList, 20);
        }

        #endregion
    }
}
