using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.device.manage.hasbinddevice
    /// </summary>
    public class CorpDeviceManageHasbinddeviceRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpDeviceManageHasbinddeviceResponse>
    {
        /// <summary>
        /// 设备产品类型 产品编码：M1：9 C1：14 M2：15 D1：24
        /// </summary>
        public Nullable<long> DeviceServiceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.device.manage.hasbinddevice";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_service_id", this.DeviceServiceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_service_id", this.DeviceServiceId);
        }

        #endregion
    }
}
