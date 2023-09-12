using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.create
    /// </summary>
    public class OapiRhinoMosExecClothesCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesCreateResponse>
    {
        /// <summary>
        /// 工序信息
        /// </summary>
        public string AdditionalOperations { get; set; }

        public List<AddtionalOperationDomain> AdditionalOperations_ { set { this.AdditionalOperations = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 衣服状态是否自动开启
        /// </summary>
        public Nullable<bool> AutoStart { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 衣服详情
        /// </summary>
        public string Clothes { get; set; }

        public List<ClothesInfoReqDomain> Clothes_ { set { this.Clothes = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 实体类型
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        public SourceDomain Source_ { set { this.Source = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("additional_operations", this.AdditionalOperations);
            parameters.Add("auto_start", this.AutoStart);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("clothes", this.Clothes);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("source", this.Source);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("additional_operations", this.AdditionalOperations, 500);
            RequestValidator.ValidateObjectMaxListSize("clothes", this.Clothes, 20);
            RequestValidator.ValidateRequired("entity_type", this.EntityType);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("source", this.Source);
        }

	/// <summary>
/// AddtionalOperationDomain Data Structure.
/// </summary>
[Serializable]

public class AddtionalOperationDomain : TopObject
{
	        /// <summary>
	        /// 上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 设备ID列表
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeviceIds { get; set; }
	
	        /// <summary>
	        /// 排位布局版本
	        /// </summary>
	        [XmlElement("flow_version")]
	        public Nullable<long> FlowVersion { get; set; }
	
	        /// <summary>
	        /// 工序类型
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// 工序ID
	        /// </summary>
	        [XmlElement("operation_uid")]
	        public Nullable<long> OperationUid { get; set; }
	
	        /// <summary>
	        /// 工序执行状态
	        /// </summary>
	        [XmlElement("perform_status")]
	        public string PerformStatus { get; set; }
	
	        /// <summary>
	        /// 优先级
	        /// </summary>
	        [XmlElement("priority")]
	        public Nullable<long> Priority { get; set; }
	
	        /// <summary>
	        /// 工序执行完成时间
	        /// </summary>
	        [XmlElement("process_end_time")]
	        public Nullable<DateTime> ProcessEndTime { get; set; }
	
	        /// <summary>
	        /// 工序执行开始时间
	        /// </summary>
	        [XmlElement("process_start_time")]
	        public Nullable<DateTime> ProcessStartTime { get; set; }
	
	        /// <summary>
	        /// 工序能力类型
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工段
	        /// </summary>
	        [XmlElement("section_code")]
	        public string SectionCode { get; set; }
	
	        /// <summary>
	        /// 执行人
	        /// </summary>
	        [XmlArray("work_nos")]
	        [XmlArrayItem("string")]
	        public List<string> WorkNos { get; set; }
	
	        /// <summary>
	        /// 工位
	        /// </summary>
	        [XmlElement("workstation_code")]
	        public string WorkstationCode { get; set; }
}

	/// <summary>
/// SourceDomain Data Structure.
/// </summary>
[Serializable]

public class SourceDomain : TopObject
{
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
}

	/// <summary>
/// ClothesInfoReqDomain Data Structure.
/// </summary>
[Serializable]

public class ClothesInfoReqDomain : TopObject
{
	        /// <summary>
	        /// 颜色code
	        /// </summary>
	        [XmlElement("color_code")]
	        public string ColorCode { get; set; }
	
	        /// <summary>
	        /// 颜色名
	        /// </summary>
	        [XmlElement("color_name")]
	        public string ColorName { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("count")]
	        public Nullable<long> Count { get; set; }
	
	        /// <summary>
	        /// 衣服完成时间
	        /// </summary>
	        [XmlElement("finish_time")]
	        public Nullable<DateTime> FinishTime { get; set; }
	
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
	        /// 衣服开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
}

        #endregion
    }
}
