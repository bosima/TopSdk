using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.vacation.type.list
    /// </summary>
    public class OapiAttendanceVacationTypeListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceVacationTypeListResponse>
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 空:开放接口定义假期类型;all:所有假期类型
        /// </summary>
        public string VacationSource { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.vacation.type.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("vacation_source", this.VacationSource);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

        #endregion
    }
}
