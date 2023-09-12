using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectdata.list
    /// </summary>
    public class OapiCrmObjectdataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectdataListResponse>
    {
        /// <summary>
        /// 操作人用户ID
        /// </summary>
        public string CurrentOperatorUserid { get; set; }

        /// <summary>
        /// 数据ID列表
        /// </summary>
        public string DataIdList { get; set; }

        /// <summary>
        /// 表单名称
        /// </summary>
        public string Name { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectdata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_operator_userid", this.CurrentOperatorUserid);
            parameters.Add("data_id_list", this.DataIdList);
            parameters.Add("name", this.Name);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("data_id_list", this.DataIdList);
            RequestValidator.ValidateMaxListSize("data_id_list", this.DataIdList, 100);
            RequestValidator.ValidateRequired("name", this.Name);
        }

        #endregion
    }
}
