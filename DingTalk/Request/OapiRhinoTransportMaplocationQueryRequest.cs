using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.transport.maplocation.query
    /// </summary>
    public class OapiRhinoTransportMaplocationQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoTransportMaplocationQueryResponse>
    {
        /// <summary>
        /// 是否获取配置信息
        /// </summary>
        public Nullable<bool> IncludeConfig { get; set; }

        /// <summary>
        /// poiCode list
        /// </summary>
        public string PoiCodeList { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.transport.maplocation.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("include_config", this.IncludeConfig);
            parameters.Add("poi_code_list", this.PoiCodeList);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("poi_code_list", this.PoiCodeList);
            RequestValidator.ValidateMaxListSize("poi_code_list", this.PoiCodeList, 20);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
