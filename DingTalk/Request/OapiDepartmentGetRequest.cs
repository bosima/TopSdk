using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.department.get
    /// </summary>
    public class OapiDepartmentGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDepartmentGetResponse>
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN，未来会支持en_US)
        /// </summary>
        public string Lang { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.department.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("lang", this.Lang);
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
