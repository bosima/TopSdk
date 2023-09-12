using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.internal.remind
    /// </summary>
    public class OapiAppstoreInternalRemindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreInternalRemindResponse>
    {
        /// <summary>
        /// 商品码
        /// </summary>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 试用审批单id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.internal.remind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("goods_code", this.GoodsCode);
            parameters.Add("process_instance_id", this.ProcessInstanceId);
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
