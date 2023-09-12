using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.facegroup.device.update
    /// </summary>
    public class OapiSmartdeviceFacegroupDeviceUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFacegroupDeviceUpdateResponse>
    {
        /// <summary>
        /// 需新增的设备id列表
        /// </summary>
        public string AddDeviceIds { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 需移除的设备id列表
        /// </summary>
        public string DelDeviceIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.facegroup.device.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_device_ids", this.AddDeviceIds);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("del_device_ids", this.DelDeviceIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_device_ids", this.AddDeviceIds, 20);
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateMaxLength("biz_id", this.BizId, 23);
            RequestValidator.ValidateMaxListSize("del_device_ids", this.DelDeviceIds, 20);
        }

        #endregion
    }
}
