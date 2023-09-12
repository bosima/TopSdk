using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.blackboard.category.list
    /// </summary>
    public class OapiBlackboardCategoryListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBlackboardCategoryListResponse>
    {
        /// <summary>
        /// 操作人userId(必须是公告管理员)
        /// </summary>
        public string OperationUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.blackboard.category.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("operation_userid", this.OperationUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operation_userid", this.OperationUserid);
        }

        #endregion
    }
}
