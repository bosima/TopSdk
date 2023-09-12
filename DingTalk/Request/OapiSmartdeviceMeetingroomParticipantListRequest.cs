using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.meetingroom.participant.list
    /// </summary>
    public class OapiSmartdeviceMeetingroomParticipantListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceMeetingroomParticipantListResponse>
    {
        /// <summary>
        /// 会议室预订id
        /// </summary>
        public string Bookid { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 最大200(含)
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.meetingroom.participant.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bookid", this.Bookid);
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
            RequestValidator.ValidateRequired("bookid", this.Bookid);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
