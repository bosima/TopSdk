using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.school.init
    /// </summary>
    public class OapiEduSchoolInitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduSchoolInitResponse>
    {
        /// <summary>
        /// 校区
        /// </summary>
        public string Campus { get; set; }

        public OpenCampusDomain Campus_ { set { this.Campus = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 钉钉企业通讯录管理员
        /// </summary>
        public string Operator { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.school.init";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campus", this.Campus);
            parameters.Add("operator", this.Operator);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("campus", this.Campus);
            RequestValidator.ValidateRequired("operator", this.Operator);
        }

	/// <summary>
/// OpenGradeDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGradeDomain : TopObject
{
	        /// <summary>
	        /// [0,无限)其下的班级数。尽量不要超过100个，否则页面性能有问题
	        /// </summary>
	        [XmlElement("classes")]
	        public Nullable<long> Classes { get; set; }
	
	        /// <summary>
	        /// 年级level
	        /// </summary>
	        [XmlElement("grade")]
	        public string Grade { get; set; }
	
	        /// <summary>
	        /// 年级名，与grade start_year需要对应
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 入学年份。请注意startyear name grade三者之间的关联关系
	        /// </summary>
	        [XmlElement("start_year")]
	        public string StartYear { get; set; }
}

	/// <summary>
/// OpenPeriodDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPeriodDomain : TopObject
{
	        /// <summary>
	        /// 年级列表
	        /// </summary>
	        [XmlArray("grades")]
	        [XmlArrayItem("open_grade")]
	        public List<OpenGradeDomain> Grades { get; set; }
	
	        /// <summary>
	        /// number: 初中按照1,2,3年级命名。默认。  text: 初中按照6,7,8,9年级命名
	        /// </summary>
	        [XmlElement("name_mode")]
	        public string NameMode { get; set; }
	
	        /// <summary>
	        /// 学段code。幼儿园：kindergarten  小学：primary_school  初中：  middle_school  高中：  high_school
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 学段名；幼儿园：kindergarten  小学：primary_school  初中：  middle_school  高中：  high_school
	        /// </summary>
	        [XmlElement("step")]
	        public string Step { get; set; }
}

	/// <summary>
/// OpenCampusDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCampusDomain : TopObject
{
	        /// <summary>
	        /// 校区名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学段列表
	        /// </summary>
	        [XmlArray("periods")]
	        [XmlArrayItem("open_period")]
	        public List<OpenPeriodDomain> Periods { get; set; }
}

        #endregion
    }
}
