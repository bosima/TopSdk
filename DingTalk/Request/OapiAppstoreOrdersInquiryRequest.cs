using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.orders.inquiry
    /// </summary>
    public class OapiAppstoreOrdersInquiryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreOrdersInquiryResponse>
    {
        /// <summary>
        /// 询价企业id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 订购周期数量
        /// </summary>
        public Nullable<long> CycNum { get; set; }

        /// <summary>
        /// 订购周期单位
        /// </summary>
        public Nullable<long> CycUnit { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 规格码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 询价用户手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 订购人数
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.orders.inquiry";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corpid", this.Corpid);
            parameters.Add("cyc_num", this.CycNum);
            parameters.Add("cyc_unit", this.CycUnit);
            parameters.Add("goods_code", this.GoodsCode);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("quantity", this.Quantity);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corpid", this.Corpid);
            RequestValidator.ValidateRequired("cyc_num", this.CycNum);
            RequestValidator.ValidateRequired("cyc_unit", this.CycUnit);
            RequestValidator.ValidateRequired("goods_code", this.GoodsCode);
            RequestValidator.ValidateRequired("item_code", this.ItemCode);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
        }

        #endregion
    }
}
