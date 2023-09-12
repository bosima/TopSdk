using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.internal.skupage.get
    /// </summary>
    public class OapiAppstoreInternalSkupageGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreInternalSkupageGetResponse>
    {
        /// <summary>
        /// 回调页面(进行URLEncode处理)，微应用为页面URL，E应用为页面路径地址
        /// </summary>
        public string CallbackPage { get; set; }

        /// <summary>
        /// 与callbackPage配合使用。当用户从SKU页面下单并支付成功后，会跳转回ISV页面，此时将此参数原样回传。主要用于用户页面引导等操作，不能作为权益开通凭证。
        /// </summary>
        public string ExtendParam { get; set; }

        /// <summary>
        /// 内购商品码
        /// </summary>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 内购商品规格码，如果设置了规格码，页面会默认选中该规格码
        /// </summary>
        public string ItemCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.internal.skupage.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("callback_page", this.CallbackPage);
            parameters.Add("extend_param", this.ExtendParam);
            parameters.Add("goods_code", this.GoodsCode);
            parameters.Add("item_code", this.ItemCode);
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
