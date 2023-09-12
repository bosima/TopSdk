using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.family.child.get
    /// </summary>
    public class OapiEduFamilyChildGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduFamilyChildGetResponse>
    {
        /// <summary>
        /// 孩子userid
        /// </summary>
        public string ChildUserid { get; set; }

        /// <summary>
        /// 操作者userid
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.family.child.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("child_userid", this.ChildUserid);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("child_userid", this.ChildUserid);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

        #endregion
    }
}
