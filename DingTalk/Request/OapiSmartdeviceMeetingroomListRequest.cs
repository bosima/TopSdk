using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.meetingroom.list
    /// </summary>
    public class OapiSmartdeviceMeetingroomListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceMeetingroomListResponse>
    {
        /// <summary>
        /// 如果为null,那么就从头开始查询.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 最大500
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.meetingroom.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
