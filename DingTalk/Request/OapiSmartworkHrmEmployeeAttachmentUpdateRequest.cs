using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.attachment.update
    /// </summary>
    public class OapiSmartworkHrmEmployeeAttachmentUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeAttachmentUpdateResponse>
    {
        /// <summary>
        /// 微应用在企业的AgentId
        /// </summary>
        public string Agentid { get; set; }

        /// <summary>
        /// 更新信息
        /// </summary>
        public string Param { get; set; }

        public EmpAttachmentUpdateParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.attachment.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// EmpAttachmentUpdateParamDomain Data Structure.
/// </summary>
[Serializable]

public class EmpAttachmentUpdateParamDomain : TopObject
{
	        /// <summary>
	        /// 字段ID
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 文件名后缀，用以标识和展示
	        /// </summary>
	        [XmlElement("file_suffix")]
	        public string FileSuffix { get; set; }
	
	        /// <summary>
	        /// 文件id，参考oapi.dingtalk.com/media/upload接口
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 用户ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
