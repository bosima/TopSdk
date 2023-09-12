using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.industry.studentpool.batchadd
    /// </summary>
    public class OapiIndustryStudentpoolBatchaddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiIndustryStudentpoolBatchaddResponse>
    {
        /// <summary>
        /// 业务code
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 学员列表
        /// </summary>
        public string StudentList { get; set; }

        public List<TrainingStudentDtoDomain> StudentList_ { set { this.StudentList = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.industry.studentpool.batchadd";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("student_list", this.StudentList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateObjectMaxListSize("student_list", this.StudentList, 20);
        }

	/// <summary>
/// PatriarchDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PatriarchDtoDomain : TopObject
{
	        /// <summary>
	        /// 联系人手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 联系人名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 联系人与学员的关系
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
}

	/// <summary>
/// TrainingStudentDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TrainingStudentDtoDomain : TopObject
{
	        /// <summary>
	        /// 学员手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 学员名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学员编号
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// 课包ID列表
	        /// </summary>
	        [XmlArray("package_ids")]
	        [XmlArrayItem("number")]
	        public List<string> PackageIds { get; set; }
	
	        /// <summary>
	        /// 学员联系人列表
	        /// </summary>
	        [XmlArray("patriarchs")]
	        [XmlArrayItem("patriarch_dto")]
	        public List<PatriarchDtoDomain> Patriarchs { get; set; }
}

        #endregion
    }
}
