using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.blackboard.get
    /// </summary>
    public class OapiBlackboardGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBlackboardGetResponse>
    {
        /// <summary>
        /// 公告id
        /// </summary>
        public string BlackboardId { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OperationUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.blackboard.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("blackboard_id", this.BlackboardId);
            parameters.Add("operation_userid", this.OperationUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("blackboard_id", this.BlackboardId);
            RequestValidator.ValidateRequired("operation_userid", this.OperationUserid);
        }

        #endregion
    }
}
