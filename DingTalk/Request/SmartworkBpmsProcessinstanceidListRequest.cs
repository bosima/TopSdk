using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.processinstanceid.list
    /// </summary>
    public class SmartworkBpmsProcessinstanceidListRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessinstanceidListResponse>
    {
        /// <summary>
        /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 审批实例结束时间，毫秒级，默认取当前值
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 流程模板唯一标识，可在oa后台编辑审批表单部分查询
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// 分页参数，每页大小，最多传20
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 审批实例开始时间，毫秒级
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 发起人用户id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.processinstanceid.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("process_code", this.ProcessCode);
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
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 20);
        }

        #endregion
    }
}
