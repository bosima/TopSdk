using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.project.create.v2
    /// </summary>
    public class OapiWorkspaceProjectCreateV2Request : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceProjectCreateV2Response>
    {
        /// <summary>
        /// 项目创建人userid
        /// </summary>
        public string BelongCorpUserid { get; set; }

        /// <summary>
        /// 是否创建群
        /// </summary>
        public Nullable<bool> CreateGroup { get; set; }

        /// <summary>
        /// 描述，长度256字符以内
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 项目logo media id
        /// </summary>
        public string LogoMediaId { get; set; }

        /// <summary>
        /// 组织名，长度3-50个字符以内，不允许中划线、下划线、逗号、空格
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        public string OpenConversationId { get; set; }

        /// <summary>
        /// sourceid
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 默认创建项目，可不用入参
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.project.create.v2";
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
            parameters.Add("logo_media_id", this.LogoMediaId);
            parameters.Add("name", this.Name);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("name", this.Name);
        }

        #endregion
    }
}
