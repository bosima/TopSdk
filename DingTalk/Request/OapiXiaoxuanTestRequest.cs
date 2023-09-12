using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.xiaoxuan.test
    /// </summary>
    public class OapiXiaoxuanTestRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiXiaoxuanTestResponse>
    {
        /// <summary>
        /// 4
        /// </summary>
        public string NormalData { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        public string SystemData { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.xiaoxuan.test";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("normal_data", this.NormalData);
            parameters.Add("system_data", this.SystemData);
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
