using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.grade.create
    /// </summary>
    public class OapiEduGradeCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduGradeCreateResponse>
    {
        /// <summary>
        /// 待写入的年级
        /// </summary>
        public string OpenGrade { get; set; }

        public OpenGradeDomain OpenGrade_ { set { this.OpenGrade = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 学段id
        /// </summary>
        public Nullable<long> SuperId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.grade.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_grade", this.OpenGrade);
            parameters.Add("operator", this.Operator);
            parameters.Add("super_id", this.SuperId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_grade", this.OpenGrade);
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("super_id", this.SuperId);
        }

	/// <summary>
/// OpenGradeDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGradeDomain : TopObject
{
	        /// <summary>
	        /// 创建年级时，需要在此年级下创建多少个班级。允许填0.
	        /// </summary>
	        [XmlElement("classes")]
	        public Nullable<long> Classes { get; set; }
	
	        /// <summary>
	        /// 年级level
	        /// </summary>
	        [XmlElement("grade")]
	        public string Grade { get; set; }
	
	        /// <summary>
	        /// 年级名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 入学年份
	        /// </summary>
	        [XmlElement("start_year")]
	        public string StartYear { get; set; }
}

        #endregion
    }
}
