using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.isv.blazers.generatecode
    /// </summary>
    public class IsvBlazersGeneratecodeRequest : BaseDingTalkRequest<DingTalk.Api.Response.IsvBlazersGeneratecodeResponse>
    {
        /// <summary>
        /// 业务对象唯一标示
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 具体业务场景下约定的数据，格式：Map<String,String>
        /// </summary>
        public string Ext { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.isv.blazers.generatecode";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("ext", this.Ext);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateRequired("ext", this.Ext);
        }

        #endregion
    }
}
