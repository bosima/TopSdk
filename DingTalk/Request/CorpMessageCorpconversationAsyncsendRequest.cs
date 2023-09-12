using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.message.corpconversation.asyncsend
    /// </summary>
    public class CorpMessageCorpconversationAsyncsendRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpMessageCorpconversationAsyncsendResponse>
    {
        /// <summary>
        /// 微应用的id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

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
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.message.corpconversation.asyncsend";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("msgcontent", this.Msgcontent);
            parameters.Add("msgtype", this.Msgtype);
            parameters.Add("to_all_user", this.ToAllUser);
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
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 20);
            RequestValidator.ValidateRequired("msgcontent", this.Msgcontent);
            RequestValidator.ValidateRequired("msgtype", this.Msgtype);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 100);
        }

        #endregion
    }
}
