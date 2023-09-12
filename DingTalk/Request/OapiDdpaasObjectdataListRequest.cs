using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ddpaas.objectdata.list
    /// </summary>
    public class OapiDdpaasObjectdataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDdpaasObjectdataListResponse>
    {
        /// <summary>
        /// 钉钉PaaS应用ID
        /// </summary>
        public string AppUuid { get; set; }

        /// <summary>
        /// 当前操作用户ID，不填默认系统身份
        /// </summary>
        public string CurrentOperatorUserid { get; set; }

        /// <summary>
        /// 表单数据实例ID列表
        /// </summary>
        public string DataIdList { get; set; }

        /// <summary>
        /// 钉钉PaaS表单编号
        /// </summary>
        public string FormCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ddpaas.objectdata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_uuid", this.AppUuid);
            parameters.Add("current_operator_userid", this.CurrentOperatorUserid);
            parameters.Add("data_id_list", this.DataIdList);
            parameters.Add("form_code", this.FormCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("app_uuid", this.AppUuid);
            RequestValidator.ValidateRequired("data_id_list", this.DataIdList);
            RequestValidator.ValidateMaxListSize("data_id_list", this.DataIdList, 999);
            RequestValidator.ValidateRequired("form_code", this.FormCode);
        }

        #endregion
    }
}
