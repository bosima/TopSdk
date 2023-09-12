using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.device.uniquecode.get
    /// </summary>
    public class OapiRhinoDeviceUniquecodeGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoDeviceUniquecodeGetResponse>
    {
        /// <summary>
        /// 设备uniqueCode
        /// </summary>
        public string UniqueCode { get; set; }

        /// <summary>
        /// 业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.device.uniquecode.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("unique_code", this.UniqueCode);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("unique_code", this.UniqueCode);
        }

        #endregion
    }
}
