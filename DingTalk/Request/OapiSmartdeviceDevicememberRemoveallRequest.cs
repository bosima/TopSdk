using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.devicemember.removeall
    /// </summary>
    public class OapiSmartdeviceDevicememberRemoveallRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDevicememberRemoveallResponse>
    {
        /// <summary>
        /// 设备id
        /// </summary>
        public Nullable<long> DeviceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.devicemember.removeall";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_id", this.DeviceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
        }

        #endregion
    }
}
