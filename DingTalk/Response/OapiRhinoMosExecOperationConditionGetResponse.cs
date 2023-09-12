using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecOperationConditionGetResponse.
    /// </summary>
    public class OapiRhinoMosExecOperationConditionGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("model")]
        public PageResultDomain Model { get; set; }

        /// <summary>
        /// 系统自动生成
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
	        /// 颜色id
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
	        /// 实体id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 尺码code
	        /// </summary>
	        [XmlElement("size_code")]
	        public string SizeCode { get; set; }
	
	        /// <summary>
	        /// 尺码名称
	        /// </summary>
	        [XmlElement("size_name")]
	        public string SizeName { get; set; }
	
	        /// <summary>
	        /// 源id
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 源类型
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 租户
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 当前起始
	        /// </summary>
	        [XmlElement("current_start")]
	        public long CurrentStart { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 页信息
	        /// </summary>
	        [XmlArray("result_list")]
	        [XmlArrayItem("clothes_dto")]
	        public List<ClothesDtoDomain> ResultList { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
