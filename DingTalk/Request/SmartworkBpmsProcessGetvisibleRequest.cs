using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.process.getvisible
    /// </summary>
    public class SmartworkBpmsProcessGetvisibleRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessGetvisibleResponse>
    {
        /// <summary>
        /// 流程模板唯一标识，可在oa后台编辑审批表单部分查询
        /// </summary>
        public string ProcessCodeList { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.process.getvisible";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("process_code_list", this.ProcessCodeList);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("process_code_list", this.ProcessCodeList);
            RequestValidator.ValidateMaxListSize("process_code_list", this.ProcessCodeList, 20);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
