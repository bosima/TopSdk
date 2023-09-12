using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.masterdata.save
    /// </summary>
    public class OapiSmartworkHrmMasterdataSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmMasterdataSaveResponse>
    {
        /// <summary>
        /// 第三方业务数据结构
        /// </summary>
        public string BizDataFields { get; set; }

        public List<BizDataFieldVoDomain> BizDataFields_ { set { this.BizDataFields = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 唯一标识此记录的外键id
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 代表业务领域枚举值
        /// </summary>
        public string ScopeCode { get; set; }

        /// <summary>
        /// 数据代表用户唯一标识
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.masterdata.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_data_fields", this.BizDataFields);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("scope_code", this.ScopeCode);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_data_fields", this.BizDataFields);
            RequestValidator.ValidateObjectMaxListSize("biz_data_fields", this.BizDataFields, 999);
            RequestValidator.ValidateRequired("outer_id", this.OuterId);
            RequestValidator.ValidateRequired("scope_code", this.ScopeCode);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

	/// <summary>
/// BizDataFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class BizDataFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 业务字段
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 对应的值
	        /// </summary>
	        [XmlElement("value_str")]
	        public string ValueStr { get; set; }
}

        #endregion
    }
}
