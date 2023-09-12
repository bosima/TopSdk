using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.master.save
    /// </summary>
    public class OapiSmartworkHrmMasterSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmMasterSaveResponse>
    {
        /// <summary>
        /// 业务数据列表
        /// </summary>
        public string BizData { get; set; }

        public List<BizdatavoDomain> BizData_ { set { this.BizData = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 业务方id，接入前系统分配
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.master.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_data", this.BizData);
            parameters.Add("tenant_id", this.TenantId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_data", this.BizData);
            RequestValidator.ValidateObjectMaxListSize("biz_data", this.BizData, 50);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

	/// <summary>
/// ScopeVoDomain Data Structure.
/// </summary>
[Serializable]

public class ScopeVoDomain : TopObject
{
	        /// <summary>
	        /// 业务域code，如PERFORMANCE，系统分配，枚举见文档
	        /// </summary>
	        [XmlElement("scope_code")]
	        public string ScopeCode { get; set; }
	
	        /// <summary>
	        /// 业务域版本，接入时系统分配，默认传0
	        /// </summary>
	        [XmlElement("version")]
	        public Nullable<long> Version { get; set; }
}

	/// <summary>
/// FieldlistDomain Data Structure.
/// </summary>
[Serializable]

public class FieldlistDomain : TopObject
{
	        /// <summary>
	        /// 字段名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 字段string值，映射规则见文档
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// BizdatavoDomain Data Structure.
/// </summary>
[Serializable]

public class BizdatavoDomain : TopObject
{
	        /// <summary>
	        /// 数据变更时间戳，用以保证更新操作的顺序性
	        /// </summary>
	        [XmlElement("biz_time")]
	        public Nullable<long> BizTime { get; set; }
	
	        /// <summary>
	        /// 数据流水唯一标识，如流水号，用以唯一确认一条写入数据
	        /// </summary>
	        [XmlElement("biz_uk")]
	        public string BizUk { get; set; }
	
	        /// <summary>
	        /// 业务域下的细分领域实体
	        /// </summary>
	        [XmlElement("entityCode")]
	        public string EntityCode { get; set; }
	
	        /// <summary>
	        /// 数据字段列表
	        /// </summary>
	        [XmlArray("fields")]
	        [XmlArrayItem("fieldlist")]
	        public List<FieldlistDomain> Fields { get; set; }
	
	        /// <summary>
	        /// 业务域描述，系统分配，枚举见文档
	        /// </summary>
	        [XmlElement("scope")]
	        public ScopeVoDomain Scope { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
