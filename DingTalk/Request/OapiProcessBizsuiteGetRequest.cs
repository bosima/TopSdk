using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.bizsuite.get
    /// </summary>
    public class OapiProcessBizsuiteGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessBizsuiteGetResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string Request { get; set; }

        public BaseSuiteRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.bizsuite.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// OAPIFormDataReqVODomain Data Structure.
/// </summary>
[Serializable]

public class OAPIFormDataReqVODomain : TopObject
{
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extend_value")]
	        public string ExtendValue { get; set; }
	
	        /// <summary>
	        /// 表单标签
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 表单值value
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// BaseSuiteRequestDomain Data Structure.
/// </summary>
[Serializable]

public class BaseSuiteRequestDomain : TopObject
{
	        /// <summary>
	        /// 业务请求标识
	        /// </summary>
	        [XmlElement("action_type")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// 企业应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 套件业务标识
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 表单数据列表
	        /// </summary>
	        [XmlArray("form_data_list")]
	        [XmlArrayItem("o_a_p_i_form_data_req_v_o")]
	        public List<OAPIFormDataReqVODomain> FormDataList { get; set; }
	
	        /// <summary>
	        /// 流程processCode
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 请求唯一标识
	        /// </summary>
	        [XmlElement("seq_id")]
	        public Nullable<long> SeqId { get; set; }
	
	        /// <summary>
	        /// 操作人userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
