using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.record.upload
    /// </summary>
    public class OapiAttendanceRecordUploadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceRecordUploadResponse>
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 打卡设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 打卡备注图片地址，必须是公网可访问的地址
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// 员工打卡的时间
        /// </summary>
        public Nullable<long> UserCheckTime { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.record.upload";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_name", this.DeviceName);
            parameters.Add("photo_url", this.PhotoUrl);
            parameters.Add("user_check_time", this.UserCheckTime);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("device_name", this.DeviceName);
            RequestValidator.ValidateRequired("user_check_time", this.UserCheckTime);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
