using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.device.querylist
    /// </summary>
    public class OapiSmartdeviceDeviceQuerylistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDeviceQuerylistResponse>
    {
        /// <summary>
        /// 列表查询对象
        /// </summary>
        public string PageQueryVo { get; set; }

        public PageQueryVoDomain PageQueryVo_ { set { this.PageQueryVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.device.querylist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_query_vo", this.PageQueryVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_query_vo", this.PageQueryVo);
        }

	/// <summary>
/// PageQueryVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryVoDomain : TopObject
{
	        /// <summary>
	        /// 游标地址,第一页填0
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 产品唯一编码
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
	
	        /// <summary>
	        /// 分页大小，最大20
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
}

        #endregion
    }
}
