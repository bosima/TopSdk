using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoDeviceUniquecodeGetResponse.
    /// </summary>
    public class OapiRhinoDeviceUniquecodeGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("model")]
        public MosDeviceTenantDtoDomain Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MosDeviceTenantDtoDomain Data Structure.
/// </summary>
[Serializable]

public class MosDeviceTenantDtoDomain : TopObject
{
	        /// <summary>
	        /// 属性值
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 是否已删除
	        /// </summary>
	        [XmlElement("deleted")]
	        public bool Deleted { get; set; }
	
	        /// <summary>
	        /// 行业设备型号
	        /// </summary>
	        [XmlElement("global_model_id")]
	        public string GlobalModelId { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 设备instanceId
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
	
	        /// <summary>
	        /// 行业设备型号id
	        /// </summary>
	        [XmlElement("model_id")]
	        public long ModelId { get; set; }
	
	        /// <summary>
	        /// 厂商设备型号id
	        /// </summary>
	        [XmlElement("supplier_model_id")]
	        public long SupplierModelId { get; set; }
	
	        /// <summary>
	        /// 厂商SN
	        /// </summary>
	        [XmlElement("supplier_sn")]
	        public string SupplierSn { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
}

    }
}
