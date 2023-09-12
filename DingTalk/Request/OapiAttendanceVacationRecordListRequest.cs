using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.vacation.record.list
    /// </summary>
    public class OapiAttendanceVacationRecordListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceVacationRecordListResponse>
    {
        /// <summary>
        /// 假期类型唯一标识
        /// </summary>
        public string LeaveCode { get; set; }

        /// <summary>
        /// 分页偏移(从0开始非负整数)
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 分页偏移(正整数 最大200)
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 待查询员工ID列表
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.vacation.record.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("leave_code", this.LeaveCode);
            parameters.Add("offset", this.Offset);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("size", this.Size);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("leave_code", this.LeaveCode);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateMinValue("offset", this.Offset, 0);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 200);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 50);
        }

        #endregion
    }
}
