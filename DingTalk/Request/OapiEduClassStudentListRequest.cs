using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.student.list
    /// </summary>
    public class OapiEduClassStudentListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassStudentListResponse>
    {
        /// <summary>
        /// 班级ID
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// corpId
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// 学生入参
        /// </summary>
        public string StudentParam { get; set; }

        public List<OpenStudentParamDomain> StudentParam_ { set { this.StudentParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.student.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            parameters.Add("corp_id", this.CorpId);
            parameters.Add("student_param", this.StudentParam);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateObjectMaxListSize("student_param", this.StudentParam, 20);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

	/// <summary>
/// OpenStudentParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenStudentParamDomain : TopObject
{
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public string ClassId { get; set; }
	
	        /// <summary>
	        /// 学生列表
	        /// </summary>
	        [XmlArray("student_ids")]
	        [XmlArrayItem("string")]
	        public List<string> StudentIds { get; set; }
}

        #endregion
    }
}
