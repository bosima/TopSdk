using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosSpaceWorkstationListResponse.
    /// </summary>
    public class OapiRhinoMosSpaceWorkstationListResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("prod_workstation_dto")]
        public List<ProdWorkstationDtoDomain> Model { get; set; }

	/// <summary>
/// ProdWorkstationDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProdWorkstationDtoDomain : TopObject
{
	        /// <summary>
	        /// 类目code
	        /// </summary>
	        [XmlElement("category_code")]
	        public string CategoryCode { get; set; }
	
	        /// <summary>
	        /// 类目子code
	        /// </summary>
	        [XmlElement("category_sub_code")]
	        public string CategorySubCode { get; set; }
	
	        /// <summary>
	        /// 兴趣点code
	        /// </summary>
	        [XmlElement("poi_code")]
	        public string PoiCode { get; set; }
	
	        /// <summary>
	        /// 站位code
	        /// </summary>
	        [XmlElement("prod_workstation_code")]
	        public string ProdWorkstationCode { get; set; }
	
	        /// <summary>
	        /// 站位name
	        /// </summary>
	        [XmlElement("prod_workstation_name")]
	        public string ProdWorkstationName { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

    }
}
