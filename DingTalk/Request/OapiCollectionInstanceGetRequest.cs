using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.collection.instance.get
    /// </summary>
    public class OapiCollectionInstanceGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCollectionInstanceGetResponse>
    {
        /// <summary>
        /// 0表示通用填表，1表示教育版填表
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        public string FormInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.collection.instance.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("formInstance_id", this.FormInstanceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("formInstance_id", this.FormInstanceId);
        }

        #endregion
    }
}
