using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.goods.query
    /// </summary>
    public class OapiAppstoreGoodsQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreGoodsQueryResponse>
    {
        /// <summary>
        /// 商品码
        /// </summary>
        public string GoodsCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.goods.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("goods_code", this.GoodsCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("goods_code", this.GoodsCode);
        }

        #endregion
    }
}
