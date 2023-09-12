using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.applyoutid
    /// </summary>
    public class OapiSmartdeviceApplyoutidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceApplyoutidResponse>
    {
        /// <summary>
        /// 设备类型id
        /// </summary>
        public Nullable<long> DevServId { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        public string Sn { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.applyoutid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dev_serv_id", this.DevServId);
            parameters.Add("sn", this.Sn);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dev_serv_id", this.DevServId);
            RequestValidator.ValidateRequired("sn", this.Sn);
        }

        #endregion
    }
}
