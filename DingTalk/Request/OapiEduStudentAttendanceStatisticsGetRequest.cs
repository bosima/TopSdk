using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.student.attendance.statistics.get
    /// </summary>
    public class OapiEduStudentAttendanceStatisticsGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduStudentAttendanceStatisticsGetResponse>
    {
        /// <summary>
        /// 指定获取哪一天的数据，格式为yyyyMMdd
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 当前操作人的用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 指定获取那个学校的数据，学校的CorpId
        /// </summary>
        public string SchoolCorpid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.student.attendance.statistics.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("date", this.Date);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("school_corpid", this.SchoolCorpid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("date", this.Date);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("school_corpid", this.SchoolCorpid);
        }

        #endregion
    }
}
