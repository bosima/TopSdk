using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.master.delete
    /// </summary>
    public class OapiSmartworkHrmMasterDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmMasterDeleteResponse>
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        public string BizData { get; set; }

        public List<BizDataVoDomain> BizData_ { set { this.BizData = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 业务方id(由系统统一分配)
        /// </summary>
        public Nullable<long> Tenantid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.master.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_data", this.BizData);
            parameters.Add("tenantid", this.Tenantid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_data", this.BizData);
            RequestValidator.ValidateObjectMaxListSize("biz_data", this.BizData, 20);
            RequestValidator.ValidateRequired("tenantid", this.Tenantid);
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
	        /// 字段值原始字符串
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ScopeVoDomain Data Structure.
/// </summary>
[Serializable]

public class ScopeVoDomain : TopObject
{
	        /// <summary>
	        /// 业务域code
	        /// </summary>
	        [XmlElement("scope_code")]
	        public string ScopeCode { get; set; }
	
	        /// <summary>
	        /// 业务域版本号
	        /// </summary>
	        [XmlElement("version")]
	        public Nullable<long> Version { get; set; }
}

	/// <summary>
/// BizDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class BizDataVoDomain : TopObject
{
	        /// <summary>
	        /// 数据业务时间戳
	        /// </summary>
	        [XmlElement("biz_time")]
	        public Nullable<long> BizTime { get; set; }
	
	        /// <summary>
	        /// 业务uk，唯一标识一条流水
	        /// </summary>
	        [XmlElement("biz_uk")]
	        public string BizUk { get; set; }
	
	        /// <summary>
	        /// 字段列表
	        /// </summary>
	        [XmlArray("fields")]
	        [XmlArrayItem("fieldlist")]
	        public List<FieldlistDomain> Fields { get; set; }
	
	        /// <summary>
	        /// 数据所属业务域
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
