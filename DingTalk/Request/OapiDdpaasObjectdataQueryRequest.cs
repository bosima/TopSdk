using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ddpaas.objectdata.query
    /// </summary>
    public class OapiDdpaasObjectdataQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDdpaasObjectdataQueryResponse>
    {
        /// <summary>
        /// 钉钉PaaS 应用 ID
        /// </summary>
        public string AppUuid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string CurrentOperatorUserid { get; set; }

        /// <summary>
        /// 查询游标
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 钉钉 PaaS 表单编号
        /// </summary>
        public string FormCode { get; set; }

        /// <summary>
        /// 查询条件DSL
        /// </summary>
        public string QueryDsl { get; set; }

        /// <summary>
        /// 分页限制
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ddpaas.objectdata.query";
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
            parameters.Add("cursor", this.Cursor);
            parameters.Add("form_code", this.FormCode);
            parameters.Add("query_dsl", this.QueryDsl);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("app_uuid", this.AppUuid);
            RequestValidator.ValidateRequired("form_code", this.FormCode);
        }

        #endregion
    }
}
