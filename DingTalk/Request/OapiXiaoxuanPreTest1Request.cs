using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.xiaoxuan.pre.test1
    /// </summary>
    public class OapiXiaoxuanPreTest1Request : BaseDingTalkRequest<DingTalk.Api.Response.OapiXiaoxuanPreTest1Response>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string NormalData { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string SystemData { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.xiaoxuan.pre.test1";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("name", this.Name);
            parameters.Add("normalData", this.NormalData);
            parameters.Add("systemData", this.SystemData);
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
