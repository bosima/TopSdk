using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.mpdev.build.status.get
    /// </summary>
    public class OapiMpdevBuildStatusGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMpdevBuildStatusGetResponse>
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        public string MiniappId { get; set; }

        /// <summary>
        /// 上传任务ID
        /// </summary>
        public string TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.mpdev.build.status.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("miniapp_id", this.MiniappId);
            parameters.Add("task_id", this.TaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("miniapp_id", this.MiniappId);
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
