using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sceneservicegroup.groupset.create
    /// </summary>
    public class OapiSceneservicegroupGroupsetCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSceneservicegroupGroupsetCreateResponse>
    {
        /// <summary>
        /// 开放模板id
        /// </summary>
        public string GroupTemplateid { get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        public string GroupsetName { get; set; }

        /// <summary>
        /// 开放团队id
        /// </summary>
        public string OpenTeamid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sceneservicegroup.groupset.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_templateid", this.GroupTemplateid);
            parameters.Add("groupset_name", this.GroupsetName);
            parameters.Add("open_teamid", this.OpenTeamid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_teamid", this.OpenTeamid);
        }

        #endregion
    }
}
