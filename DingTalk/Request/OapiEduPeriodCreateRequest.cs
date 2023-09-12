using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.period.create
    /// </summary>
    public class OapiEduPeriodCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduPeriodCreateResponse>
    {
        /// <summary>
        /// 学段信息
        /// </summary>
        public string OpenPeriod { get; set; }

        public OpenPeriodDomain OpenPeriod_ { set { this.OpenPeriod = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 钉钉管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 校区id
        /// </summary>
        public Nullable<long> SuperId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.period.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_period", this.OpenPeriod);
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
            RequestValidator.ValidateRequired("open_period", this.OpenPeriod);
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("super_id", this.SuperId);
        }

	/// <summary>
/// GradesDomain Data Structure.
/// </summary>
[Serializable]

public class GradesDomain : TopObject
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

	/// <summary>
/// OpenPeriodDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPeriodDomain : TopObject
{
	        /// <summary>
	        /// 年级
	        /// </summary>
	        [XmlArray("grades")]
	        [XmlArrayItem("grades")]
	        public List<GradesDomain> Grades { get; set; }
	
	        /// <summary>
	        /// number: 初中按照1,2,3年级命名。默认。  text: 初中按照6,7,8,9年级命名
	        /// </summary>
	        [XmlElement("name_mode")]
	        public string NameMode { get; set; }
	
	        /// <summary>
	        /// 幼儿园：kindergarten  小学：primary_school  初中：  middle_school  高中：  high_school
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 学段名.  其枚举值：  幼儿园/小学/初中/高中
	        /// </summary>
	        [XmlElement("step")]
	        public string Step { get; set; }
}

        #endregion
    }
}
