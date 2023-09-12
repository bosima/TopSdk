using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.positions.query
    /// </summary>
    public class OapiAttendanceGroupPositionsQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupPositionsQueryResponse>
    {
        /// <summary>
        /// 上一批次的最后一个id，默认空
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 考勤组id
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.positions.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("group_key", this.GroupKey);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
        }

        #endregion
    }
}
