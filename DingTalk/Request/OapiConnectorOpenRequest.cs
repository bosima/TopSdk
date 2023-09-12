using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.connector.open
    /// </summary>
    public class OapiConnectorOpenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiConnectorOpenResponse>
    {
        /// <summary>
        /// 连接器id
        /// </summary>
        public string ConnectorId { get; set; }

        /// <summary>
        /// 待开通连接器的企业id
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// 开通连接器的企业员工id
        /// </summary>
        public string CreatorUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.connector.open";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("connector_id", this.ConnectorId);
            parameters.Add("corp_id", this.CorpId);
            parameters.Add("creator_userid", this.CreatorUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("connector_id", this.ConnectorId);
            RequestValidator.ValidateRequired("corp_id", this.CorpId);
            RequestValidator.ValidateRequired("creator_userid", this.CreatorUserid);
        }

        #endregion
    }
}
