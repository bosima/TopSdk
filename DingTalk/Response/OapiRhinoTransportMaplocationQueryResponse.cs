using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoTransportMaplocationQueryResponse.
    /// </summary>
    public class OapiRhinoTransportMaplocationQueryResponse : DingTalkResponse
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
        /// 其它信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("map_location_detail_result")]
        public List<MapLocationDetailResultDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ConfigsDomain Data Structure.
/// </summary>
[Serializable]

public class ConfigsDomain : TopObject
{
	        /// <summary>
	        /// 位置id
	        /// </summary>
	        [XmlElement("location_id")]
	        public long LocationId { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 执行code
	        /// </summary>
	        [XmlElement("trans_cmd_code")]
	        public string TransCmdCode { get; set; }
	
	        /// <summary>
	        /// 运输类型
	        /// </summary>
	        [XmlElement("trans_type_code")]
	        public string TransTypeCode { get; set; }
}

	/// <summary>
/// MapLocationDetailResultDomain Data Structure.
/// </summary>
[Serializable]

public class MapLocationDetailResultDomain : TopObject
{
	        /// <summary>
	        /// config信息
	        /// </summary>
	        [XmlArray("configs")]
	        [XmlArrayItem("configs")]
	        public List<ConfigsDomain> Configs { get; set; }
	
	        /// <summary>
	        /// 位置id
	        /// </summary>
	        [XmlElement("location_id")]
	        public long LocationId { get; set; }
	
	        /// <summary>
	        /// poi编码
	        /// </summary>
	        [XmlElement("own_poi_code")]
	        public string OwnPoiCode { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

    }
}
