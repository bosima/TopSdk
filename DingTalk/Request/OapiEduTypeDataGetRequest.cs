using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.type.data.get
    /// </summary>
    public class OapiEduTypeDataGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduTypeDataGetResponse>
    {
        /// <summary>
        /// 排序因子
        /// </summary>
        public string Orders { get; set; }

        public List<OpenOrderDataRequestDomain> Orders_ { set { this.Orders = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 页码；必须大于0
        /// </summary>
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小；必须大于0
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.type.data.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("orders", this.Orders);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("stat_date", this.StatDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("orders", this.Orders, 20);
            RequestValidator.ValidateRequired("page_num", this.PageNum);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("stat_date", this.StatDate);
        }

	/// <summary>
/// OpenOrderDataRequestDomain Data Structure.
/// </summary>
[Serializable]

public class OpenOrderDataRequestDomain : TopObject
{
	        /// <summary>
	        /// 排序字段名；字段名与返回值名保持一致
	        /// </summary>
	        [XmlElement("field_name")]
	        public string FieldName { get; set; }
	
	        /// <summary>
	        /// 升序: asc; 降序：desc;
	        /// </summary>
	        [XmlElement("order")]
	        public string Order { get; set; }
}

        #endregion
    }
}
