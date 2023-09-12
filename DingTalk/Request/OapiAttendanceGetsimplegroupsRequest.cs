using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.getsimplegroups
    /// </summary>
    public class OapiAttendanceGetsimplegroupsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGetsimplegroupsResponse>
    {
        /// <summary>
        /// 偏移位置
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大10
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.getsimplegroups";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
