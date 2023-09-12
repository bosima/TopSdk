using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.list
    /// </summary>
    public class OapiAttendanceListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceListResponse>
    {
        /// <summary>
        /// 是否国际化
        /// </summary>
        public Nullable<bool> IsI18n { get; set; }

        /// <summary>
        /// 表示获取考勤数据的条数，最大不能超过50条
        /// </summary>
        public Nullable<long> Limit { get; set; }

        /// <summary>
        /// 表示获取考勤数据的起始点，第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 员工在企业内的UserID列表，企业用来唯一标识用户的字段
        /// </summary>
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 查询考勤打卡记录的起始工作日
        /// </summary>
        public string WorkDateFrom { get; set; }

        /// <summary>
        /// 查询考勤打卡记录的结束工作日
        /// </summary>
        public string WorkDateTo { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("isI18n", this.IsI18n);
            parameters.Add("limit", this.Limit);
            parameters.Add("offset", this.Offset);
            parameters.Add("userIdList", TopUtils.ObjectToJson(this.UserIdList));
            parameters.Add("workDateFrom", this.WorkDateFrom);
            parameters.Add("workDateTo", this.WorkDateTo);
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
