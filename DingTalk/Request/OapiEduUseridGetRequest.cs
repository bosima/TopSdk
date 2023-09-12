using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.userid.get
    /// </summary>
    public class OapiEduUseridGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduUseridGetResponse>
    {
        /// <summary>
        /// 手机列表，最大不超过50个
        /// </summary>
        public string Mobiles { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string Operator { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.userid.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mobiles", this.Mobiles);
            parameters.Add("operator", this.Operator);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mobiles", this.Mobiles);
            RequestValidator.ValidateMaxListSize("mobiles", this.Mobiles, 999);
        }

        #endregion
    }
}
