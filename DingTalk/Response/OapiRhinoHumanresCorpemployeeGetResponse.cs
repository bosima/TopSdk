using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresCorpemployeeGetResponse.
    /// </summary>
    public class OapiRhinoHumanresCorpemployeeGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 员工详情
        /// </summary>
        [XmlElement("corp_employee_info")]
        public ModelDomain CorpEmployeeInfo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// status_code
        /// </summary>
        [XmlElement("status_code")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ModelDomain Data Structure.
/// </summary>
[Serializable]

public class ModelDomain : TopObject
{
	        /// <summary>
	        /// 部门邮箱
	        /// </summary>
	        [XmlElement("bu_mail")]
	        public string BuMail { get; set; }
	
	        /// <summary>
	        /// buc ID
	        /// </summary>
	        [XmlElement("buc_id")]
	        public long BucId { get; set; }
	
	        /// <summary>
	        /// 企业ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 离职日期
	        /// </summary>
	        [XmlElement("departure_date")]
	        public string DepartureDate { get; set; }
	
	        /// <summary>
	        /// 钉钉全局员工ID
	        /// </summary>
	        [XmlElement("dingtalk_no")]
	        public string DingtalkNo { get; set; }
	
	        /// <summary>
	        /// 钉钉企业下员工ID
	        /// </summary>
	        [XmlElement("dingtalk_user_id")]
	        public string DingtalkUserId { get; set; }
	
	        /// <summary>
	        /// 入职日期
	        /// </summary>
	        [XmlElement("hire_date")]
	        public string HireDate { get; set; }
	
	        /// <summary>
	        /// 主键ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("img_url")]
	        public string ImgUrl { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("job")]
	        public string Job { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// uic ID
	        /// </summary>
	        [XmlElement("uic_id")]
	        public long UicId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
	
	        /// <summary>
	        /// 工作状态
	        /// </summary>
	        [XmlElement("work_status")]
	        public long WorkStatus { get; set; }
}

    }
}
