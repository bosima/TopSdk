using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.checkin.record.get
    /// </summary>
    public class OapiCheckinRecordGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCheckinRecordGetResponse>
    {
        /// <summary>
        /// 分页查询的游标，最开始可以传0
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 截止时间，单位毫秒。如果是取1个人的数据，时间范围最大到10天，如果是取多个人的数据，时间范围最大1天。
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 分页查询的每页大小，最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 起始时间,单位毫秒
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 需要查询的用户列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.checkin.record.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("end_time", this.EndTime);
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
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 10);
        }

        #endregion
    }
}
