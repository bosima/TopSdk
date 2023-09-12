using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmMasterCheckResponse.
    /// </summary>
    public class OapiSmartworkHrmMasterCheckResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 保存错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 保存结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("integrate_batch_result_vo")]
        public List<IntegrateBatchResultVoDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// EntityFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class EntityFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 字段名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 字段string值
	        /// </summary>
	        [XmlElement("valueStr")]
	        public string ValueStr { get; set; }
}

	/// <summary>
/// IntegrateBatchResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class IntegrateBatchResultVoDomain : TopObject
{
	        /// <summary>
	        /// 业务方唯一标识
	        /// </summary>
	        [XmlElement("bizUk")]
	        public string BizUk { get; set; }
	
	        /// <summary>
	        /// 一条数据的明细
	        /// </summary>
	        [XmlArray("fieldList")]
	        [XmlArrayItem("entity_field_vo")]
	        public List<EntityFieldVoDomain> FieldList { get; set; }
	
	        /// <summary>
	        /// 关联id, 一般为userId
	        /// </summary>
	        [XmlElement("relationId")]
	        public string RelationId { get; set; }
}

    }
}
