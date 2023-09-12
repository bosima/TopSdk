using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.student.batchget
    /// </summary>
    public class OapiEduClassStudentBatchgetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassStudentBatchgetResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string RequestParam { get; set; }

        public List<OpenEduSelectStudentRequestDomain> RequestParam_ { set { this.RequestParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.student.batchget";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request_param", this.RequestParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("request_param", this.RequestParam, 999);
        }

	/// <summary>
/// OpenStudentParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenStudentParamDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("classId")]
	        public string ClassId { get; set; }
	
	        /// <summary>
	        /// 班级列表
	        /// </summary>
	        [XmlArray("studentIds")]
	        [XmlArrayItem("string")]
	        public List<string> StudentIds { get; set; }
}

	/// <summary>
/// OpenEduSelectStudentRequestDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSelectStudentRequestDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("classId")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corpId")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 学生入参
	        /// </summary>
	        [XmlArray("studentParam")]
	        [XmlArrayItem("open_student_param")]
	        public List<OpenStudentParamDomain> StudentParam { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userId")]
	        public string UserId { get; set; }
}

        #endregion
    }
}
