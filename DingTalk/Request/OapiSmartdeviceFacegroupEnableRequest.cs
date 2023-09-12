using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.facegroup.enable
    /// </summary>
    public class OapiSmartdeviceFacegroupEnableRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFacegroupEnableResponse>
    {
        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 设备id列表
        /// </summary>
        public string DeviceIds { get; set; }

        /// <summary>
        /// true-启用识别；false-禁用识别
        /// </summary>
        public Nullable<bool> Enable { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.facegroup.enable";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("device_ids", this.DeviceIds);
            parameters.Add("enable", this.Enable);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateMaxLength("biz_id", this.BizId, 23);
            RequestValidator.ValidateMaxListSize("device_ids", this.DeviceIds, 20);
            RequestValidator.ValidateRequired("enable", this.Enable);
        }

        #endregion
    }
}
