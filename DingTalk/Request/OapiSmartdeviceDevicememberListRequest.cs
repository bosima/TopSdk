using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.devicemember.list
    /// </summary>
    public class OapiSmartdeviceDevicememberListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDevicememberListResponse>
    {
        /// <summary>
        /// 查询游标，起始传0，后续传返回值中的cursor字段
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        public Nullable<long> DeviceId { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.devicemember.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 500);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
        }

        #endregion
    }
}
