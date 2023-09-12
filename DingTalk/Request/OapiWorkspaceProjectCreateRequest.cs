using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.project.create
    /// </summary>
    public class OapiWorkspaceProjectCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceProjectCreateResponse>
    {
        /// <summary>
        /// 创建人（主管理员）在归属组织内的userId
        /// </summary>
        public string BelongCorpUserid { get; set; }

        /// <summary>
        /// 是否建圈自动建群
        /// </summary>
        public Nullable<bool> CreateGroup { get; set; }

        /// <summary>
        /// 描述，长度256字符以内
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 组织名，长度3-50个字符以内，不允许中划线、下划线、逗号、空格
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开放的cid，如果有值会把该群作为组织的默认群，否则会新创建1个默认群
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 允许调用者传入外部id用于做系统关联
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        /// <summary>
        /// 1项目组织  2圈子组织
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 可以指定创建人在项目/圈子组织内的userId，如果不填系统随机生成
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.project.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("belong_corp_userid", this.BelongCorpUserid);
            parameters.Add("create_group", this.CreateGroup);
            parameters.Add("desc", this.Desc);
            parameters.Add("name", this.Name);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("type", this.Type);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("belong_corp_userid", this.BelongCorpUserid);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
