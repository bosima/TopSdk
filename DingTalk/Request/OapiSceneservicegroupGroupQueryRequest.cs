using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sceneservicegroup.group.query
    /// </summary>
    public class OapiSceneservicegroupGroupQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSceneservicegroupGroupQueryResponse>
    {
        /// <summary>
        /// 表示分页游标，从0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 开放群ID
        /// </summary>
        public string OpenConversationid { get; set; }

        /// <summary>
        /// 群组id
        /// </summary>
        public string OpenGroupsetid { get; set; }

        /// <summary>
        /// 团队id
        /// </summary>
        public string OpenTeamid { get; set; }

        /// <summary>
        /// 表示分页大小，size最大不超过100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sceneservicegroup.group.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("group_name", this.GroupName);
            parameters.Add("open_conversationid", this.OpenConversationid);
            parameters.Add("open_groupsetid", this.OpenGroupsetid);
            parameters.Add("open_teamid", this.OpenTeamid);
            parameters.Add("size", this.Size);
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
