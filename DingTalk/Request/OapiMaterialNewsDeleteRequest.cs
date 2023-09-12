using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.material.news.delete
    /// </summary>
    public class OapiMaterialNewsDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMaterialNewsDeleteResponse>
    {
        /// <summary>
        /// 消息卡片素材id
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.material.news.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("media_id", this.MediaId);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("media_id", this.MediaId);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

        #endregion
    }
}
