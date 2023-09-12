using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.meetingroom.checkin
    /// </summary>
    public class OapiSmartdeviceMeetingroomCheckinRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceMeetingroomCheckinResponse>
    {
        /// <summary>
        /// 预约会议ID
        /// </summary>
        public string Bookid { get; set; }

        /// <summary>
        /// 签到用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.meetingroom.checkin";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bookid", this.Bookid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("bookid", this.Bookid);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
