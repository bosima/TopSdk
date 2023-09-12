using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosLayoutOperationdefsListsimpleResponse.
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefsListsimpleResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 工序定义图
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("operation_def_dto")]
        public List<OperationDefDtoDomain> Result { get; set; }

	/// <summary>
/// OperationDefDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationDefDtoDomain : TopObject
{
	        /// <summary>
	        /// 适用尺码（即将下线，后续迁移到applicable_size_list）
	        /// </summary>
	        [XmlElement("applicable_size_code")]
	        public string ApplicableSizeCode { get; set; }
	
	        /// <summary>
	        /// 适用尺码列表
	        /// </summary>
	        [XmlArray("applicable_size_list")]
	        [XmlArrayItem("string")]
	        public List<string> ApplicableSizeList { get; set; }
	
	        /// <summary>
	        /// 是否需要调度
	        /// </summary>
	        [XmlElement("auto_schedule")]
	        public bool AutoSchedule { get; set; }
	
	        /// <summary>
	        /// 业务编码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 工艺内容ID（bop）
	        /// </summary>
	        [XmlElement("biz_id_dtech_item")]
	        public string BizIdDtechItem { get; set; }
	
	        /// <summary>
	        /// 业务来源
	        /// </summary>
	        [XmlElement("biz_source")]
	        public string BizSource { get; set; }
	
	        /// <summary>
	        /// 进入条件：ANY_MATCH/ALL_MATCH
	        /// </summary>
	        [XmlElement("enter_condition")]
	        public string EnterCondition { get; set; }
	
	        /// <summary>
	        /// 执行系统
	        /// </summary>
	        [XmlElement("exec_system")]
	        public string ExecSystem { get; set; }
	
	        /// <summary>
	        /// PaaSflowID（只用于返回，保存会自增）
	        /// </summary>
	        [XmlElement("flow_id")]
	        public long FlowId { get; set; }
	
	        /// <summary>
	        /// 工序定义版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public long FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工艺内容版本（bop）
	        /// </summary>
	        [XmlElement("item_version")]
	        public long ItemVersion { get; set; }
	
	        /// <summary>
	        /// 工序名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 工序外部ID
	        /// </summary>
	        [XmlElement("operation_external_id")]
	        public string OperationExternalId { get; set; }
	
	        /// <summary>
	        /// 工序类型：ASSIST/QUALITY_INSPECT/TECHNOLOGY
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序唯一ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public long OperationUid { get; set; }
	
	        /// <summary>
	        /// 工序编码(同订单内唯一)
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 工序能力类型：SJ/PP/TR等
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工段CODE：F-SL/C..
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// 工段名称：缝制-碎料/裁床..
	        /// </summary>
	        [XmlElement("section_name")]
	        public string SectionName { get; set; }
	
	        /// <summary>
	        /// 是否跳过(不生产)
	        /// </summary>
	        [XmlElement("skip")]
	        public bool Skip { get; set; }
	
	        /// <summary>
	        /// 标准工时/秒
	        /// </summary>
	        [XmlElement("std_cost")]
	        public string StdCost { get; set; }
}

    }
}
