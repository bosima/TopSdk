using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.visitor.removevisitor
    /// </summary>
    public class OapiSmartdeviceVisitorRemovevisitorRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceVisitorRemovevisitorResponse>
    {
        /// <summary>
        /// 预约编号
        /// </summary>
        public string ReservationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.visitor.removevisitor";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("reservation_id", this.ReservationId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("reservation_id", this.ReservationId);
        }

        #endregion
    }
}
