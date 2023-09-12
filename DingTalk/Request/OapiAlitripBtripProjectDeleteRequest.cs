using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.project.delete
    /// </summary>
    public class OapiAlitripBtripProjectDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripProjectDeleteResponse>
    {
        /// <summary>
        /// 企业id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 第三方项目ID
        /// </summary>
        public string ThirdPartId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.project.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corpid", this.Corpid);
            parameters.Add("third_part_id", this.ThirdPartId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corpid", this.Corpid);
            RequestValidator.ValidateRequired("third_part_id", this.ThirdPartId);
        }

        #endregion
    }
}
