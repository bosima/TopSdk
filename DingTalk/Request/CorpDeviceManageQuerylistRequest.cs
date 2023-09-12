using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.device.manage.querylist
    /// </summary>
    public class CorpDeviceManageQuerylistRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpDeviceManageQuerylistResponse>
    {
        /// <summary>
        /// 分页拉取设备列表的游标，首次拉取可传Null或者0
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 设备服务商ID
        /// </summary>
        public Nullable<long> DeviceServiceId { get; set; }

        /// <summary>
        /// 单次请求的大小，最大不超过20
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.device.manage.querylist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("device_service_id", this.DeviceServiceId);
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
            RequestValidator.ValidateRequired("device_service_id", this.DeviceServiceId);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 20);
        }

        #endregion
    }
}
