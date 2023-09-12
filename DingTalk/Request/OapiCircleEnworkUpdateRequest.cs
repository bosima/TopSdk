using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.circle.enwork.update
    /// </summary>
    public class OapiCircleEnworkUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCircleEnworkUpdateResponse>
    {
        /// <summary>
        /// 请求封装类
        /// </summary>
        public string OpenUpdateDto { get; set; }

        public OpenUpdateWorkPostDTODomain OpenUpdateDto_ { set { this.OpenUpdateDto = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.circle.enwork.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_update_dto", this.OpenUpdateDto);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OpenUpdateWorkPostDTODomain Data Structure.
/// </summary>
[Serializable]

public class OpenUpdateWorkPostDTODomain : TopObject
{
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("open_id")]
	        public string OpenId { get; set; }
	
	        /// <summary>
	        /// 作文批改结果
	        /// </summary>
	        [XmlElement("pigai_analysis")]
	        public string PigaiAnalysis { get; set; }
	
	        /// <summary>
	        /// 作文id
	        /// </summary>
	        [XmlElement("post_id")]
	        public string PostId { get; set; }
	
	        /// <summary>
	        /// 相似度结果
	        /// </summary>
	        [XmlElement("similarity")]
	        public string Similarity { get; set; }
	
	        /// <summary>
	        /// 作文id
	        /// </summary>
	        [XmlElement("version_id")]
	        public Nullable<long> VersionId { get; set; }
	
	        /// <summary>
	        /// 作业id
	        /// </summary>
	        [XmlElement("work_id")]
	        public string WorkId { get; set; }
}

        #endregion
    }
}
