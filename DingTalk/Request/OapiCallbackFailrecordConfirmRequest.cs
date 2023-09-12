using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.callback.failrecord.confirm
    /// </summary>
    public class OapiCallbackFailrecordConfirmRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCallbackFailrecordConfirmResponse>
    {
        /// <summary>
        /// 失败记录id列表
        /// </summary>
        public string IdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.callback.failrecord.confirm";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id_list", this.IdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("id_list", this.IdList);
            RequestValidator.ValidateMaxListSize("id_list", this.IdList, 100);
        }

        #endregion
    }
}
