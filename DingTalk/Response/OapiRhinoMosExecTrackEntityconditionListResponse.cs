using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecTrackEntityconditionListResponse.
    /// </summary>
    public class OapiRhinoMosExecTrackEntityconditionListResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("model")]
        public PageResultDomain Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TrackRecordDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TrackRecordDtoDomain : TopObject
{
	        /// <summary>
	        /// 生效结束时间
	        /// </summary>
	        [XmlElement("effect_end_time")]
	        public string EffectEndTime { get; set; }
	
	        /// <summary>
	        /// 生效开始时间
	        /// </summary>
	        [XmlElement("effect_start_time")]
	        public string EffectStartTime { get; set; }
	
	        /// <summary>
	        /// 生效工位
	        /// </summary>
	        [XmlElement("effect_start_workstation_code")]
	        public string EffectStartWorkstationCode { get; set; }
	
	        /// <summary>
	        /// 生效状态
	        /// </summary>
	        [XmlElement("effect_status")]
	        public string EffectStatus { get; set; }
	
	        /// <summary>
	        /// 实体ID
	        /// </summary>
	        [XmlElement("entity_id")]
	        public long EntityId { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 追踪ID
	        /// </summary>
	        [XmlElement("track_id")]
	        public string TrackId { get; set; }
	
	        /// <summary>
	        /// 追踪类型
	        /// </summary>
	        [XmlElement("track_type")]
	        public string TrackType { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 当前起始位置
	        /// </summary>
	        [XmlElement("current_start")]
	        public long CurrentStart { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 追踪记录
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("track_record_dto")]
	        public List<TrackRecordDtoDomain> Result { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
