using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceAdvancedServiceIsboundResponse.
    /// </summary>
    public class OapiAttendanceAdvancedServiceIsboundResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("advanced_service_instance_vo")]
        public List<AdvancedServiceInstanceVoDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AdvancedServiceInstanceVoDomain Data Structure.
/// </summary>
[Serializable]

public class AdvancedServiceInstanceVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 有效期结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 实体id
	        /// </summary>
	        [XmlElement("entity_id")]
	        public string EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型，取值user, group, corp
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 绑定关系id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 是否删除，取值Y|N
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public string IsDeleted { get; set; }
	
	        /// <summary>
	        /// 绑定关系名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 服务id
	        /// </summary>
	        [XmlElement("service_id")]
	        public long ServiceId { get; set; }
	
	        /// <summary>
	        /// 有效期开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
}

    }
}
