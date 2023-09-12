using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.appstore.orders.special_canal.create_order
    /// </summary>
    public class OapiAppstoreOrdersSpecialCanalCreateOrderRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAppstoreOrdersSpecialCanalCreateOrderResponse>
    {
        /// <summary>
        /// 下单企业id
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 订购周期数量
        /// </summary>
        public string CycNum { get; set; }

        /// <summary>
        /// 订购的周期单位：1-年，2-月，3-日
        /// </summary>
        public string CycUnit { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 规格码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 下单人手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 联通订单id
        /// </summary>
        public string OrderCenterId { get; set; }

        /// <summary>
        /// 订购价格
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 订购数量
        /// </summary>
        public string Quantity { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.appstore.orders.special_canal.create_order";
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
            parameters.Add("order_center_id", this.OrderCenterId);
            parameters.Add("price", this.Price);
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
            RequestValidator.ValidateRequired("order_center_id", this.OrderCenterId);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
        }

        #endregion
    }
}
