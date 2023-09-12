using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.getcolumnval
    /// </summary>
    public class OapiAttendanceGetcolumnvalRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGetcolumnvalResponse>
    {
        /// <summary>
        /// 列id，多值用英文逗号分隔
        /// </summary>
        public string ColumnIdList { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> FromDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> ToDate { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.getcolumnval";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("column_id_list", this.ColumnIdList);
            parameters.Add("from_date", this.FromDate);
            parameters.Add("to_date", this.ToDate);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("column_id_list", this.ColumnIdList, 20);
        }

        #endregion
    }
}
