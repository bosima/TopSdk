using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.checkin.record
    /// </summary>
    public class OapiCheckinRecordRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCheckinRecordResponse>
    {
        /// <summary>
        /// 部门id（1 表示根部门）
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// 开始时间，精确到毫秒，注意字段的位数 例：1520956800000
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 支持分页查询，与size 参数同时设置时才生效，此参数代表偏移量，从0 开始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 排序，asc 为正序，desc 为倒序
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// 支持分页查询，与offset 参数同时设置时才生效，此参数代表分页大小，最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 结束时间，精确到毫秒，注意字段的位数 例：1520956800000（默认为当前时间）
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.checkin.record";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department_id", this.DepartmentId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("offset", this.Offset);
            parameters.Add("order", this.Order);
            parameters.Add("size", this.Size);
            parameters.Add("start_time", this.StartTime);
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
