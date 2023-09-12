using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.enable
    /// </summary>
    public class OapiPbpInstanceEnableRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceEnableResponse>
    {
        /// <summary>
        /// 业务唯一标识
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 业务实例唯一标识
        /// </summary>
        public string BizInstId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.enable";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("biz_inst_id", this.BizInstId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateRequired("biz_inst_id", this.BizInstId);
        }

        #endregion
    }
}
