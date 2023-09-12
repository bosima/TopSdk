using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecClothesGetResponse.
    /// </summary>
    public class OapiRhinoMosExecClothesGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉平台错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 额外错误信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 衣服详情
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("clothes_dto")]
        public List<ClothesDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ClothesDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ClothesDtoDomain : TopObject
{
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 颜色ID
	        /// </summary>
	        [XmlElement("color_id")]
	        public long ColorId { get; set; }
	
	        /// <summary>
	        /// 颜色名称
	        /// </summary>
	        [XmlElement("color_name")]
	        public string ColorName { get; set; }
	
	        /// <summary>
	        /// 创建类型
	        /// </summary>
	        [XmlElement("create_type")]
	        public string CreateType { get; set; }
	
	        /// <summary>
	        /// 衣服ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 尺码Code
	        /// </summary>
	        [XmlElement("size_code")]
	        public string SizeCode { get; set; }
	
	        /// <summary>
	        /// 尺码名称
	        /// </summary>
	        [XmlElement("size_name")]
	        public string SizeName { get; set; }
	
	        /// <summary>
	        /// 来源ID
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 来源类型
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

    }
}
