using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.getleavestatus
    /// </summary>
    public class OapiAttendanceGetleavestatusRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGetleavestatusResponse>
    {
        /// <summary>
        /// 结束时间，时间戳，支持最多180天的查询
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 分页偏移，非负整数
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，正整数，最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 开始时间 ，时间戳，支持最多180天的查询
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 待查询用户id列表，支持最多100个用户的批量查询
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.getleavestatus";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 100);
        }

        #endregion
    }
}
