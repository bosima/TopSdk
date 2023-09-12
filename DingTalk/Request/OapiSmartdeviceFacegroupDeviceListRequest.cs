using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.facegroup.device.list
    /// </summary>
    public class OapiSmartdeviceFacegroupDeviceListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFacegroupDeviceListResponse>
    {
        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 游标，第一次传 <=0的值，后续传本调用的返回值
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 查询模式：all-企业所有设备；bound-本组已关联设备
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 需查询的设备类型
        /// </summary>
        public string Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.facegroup.device.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("mode", this.Mode);
            parameters.Add("size", this.Size);
            parameters.Add("type", this.Type);
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
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("mode", this.Mode);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 20);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
