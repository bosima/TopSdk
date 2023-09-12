using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.devicemember.sync
    /// </summary>
    public class OapiSmartdeviceDevicememberSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDevicememberSyncResponse>
    {
        /// <summary>
        /// 需新增的userIds（与del_userids必填其一）
        /// </summary>
        public string AddUserids { get; set; }

        /// <summary>
        /// 需移除的userIds（与add_userids必填其一）
        /// </summary>
        public string DelUserids { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        public Nullable<long> DeviceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.devicemember.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_userids", this.AddUserids);
            parameters.Add("del_userids", this.DelUserids);
            parameters.Add("device_id", this.DeviceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_userids", this.AddUserids, 200);
            RequestValidator.ValidateMaxListSize("del_userids", this.DelUserids, 200);
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
        }

        #endregion
    }
}
