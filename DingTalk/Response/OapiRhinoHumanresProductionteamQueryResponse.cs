using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresProductionteamQueryResponse.
    /// </summary>
    public class OapiRhinoHumanresProductionteamQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
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
        /// model
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("model")]
        public List<ModelDomain> Model { get; set; }

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
/// EmpListDomain Data Structure.
/// </summary>
[Serializable]

public class EmpListDomain : TopObject
{
	        /// <summary>
	        /// 部门邮箱
	        /// </summary>
	        [XmlElement("bu_mail")]
	        public string BuMail { get; set; }
	
	        /// <summary>
	        /// BUC员工ID
	        /// </summary>
	        [XmlElement("buc_id")]
	        public long BucId { get; set; }
	
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
	        /// 企业下员工id
	        /// </summary>
	        [XmlElement("dingtalk_user_id")]
	        public string DingtalkUserId { get; set; }
	
	        /// <summary>
	        /// 入职日期
	        /// </summary>
	        [XmlElement("hire_date")]
	        public string HireDate { get; set; }
	
	        /// <summary>
	        /// 头像地址
	        /// </summary>
	        [XmlElement("img_url")]
	        public string ImgUrl { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("job")]
	        public string Job { get; set; }
	
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
	        /// uicId
	        /// </summary>
	        [XmlElement("uic_id")]
	        public long UicId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
	
	        /// <summary>
	        /// 在岗状态
	        /// </summary>
	        [XmlElement("work_status")]
	        public long WorkStatus { get; set; }
}

	/// <summary>
/// WeekdayConfigListDomain Data Structure.
/// </summary>
[Serializable]

public class WeekdayConfigListDomain : TopObject
{
	        /// <summary>
	        /// 星期
	        /// </summary>
	        [XmlElement("day")]
	        public long Day { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 生产组code
	        /// </summary>
	        [XmlElement("production_team_code")]
	        public string ProductionTeamCode { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 工作日
	        /// </summary>
	        [XmlElement("week_day")]
	        public string WeekDay { get; set; }
}

	/// <summary>
/// ModelDomain Data Structure.
/// </summary>
[Serializable]

public class ModelDomain : TopObject
{
	        /// <summary>
	        /// 业务ID
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 产能类型
	        /// </summary>
	        [XmlElement("capacity_type")]
	        public string CapacityType { get; set; }
	
	        /// <summary>
	        /// 员工列表
	        /// </summary>
	        [XmlArray("empList")]
	        [XmlArrayItem("emp_list")]
	        public List<EmpListDomain> EmpList { get; set; }
	
	        /// <summary>
	        /// 拥有的员工数量
	        /// </summary>
	        [XmlElement("emp_num")]
	        public long EmpNum { get; set; }
	
	        /// <summary>
	        /// 分组code
	        /// </summary>
	        [XmlElement("group_code")]
	        public string GroupCode { get; set; }
	
	        /// <summary>
	        /// 系统自动生成
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 生产组code
	        /// </summary>
	        [XmlElement("production_team_code")]
	        public string ProductionTeamCode { get; set; }
	
	        /// <summary>
	        /// 生产组名称
	        /// </summary>
	        [XmlElement("production_team_name")]
	        public string ProductionTeamName { get; set; }
	
	        /// <summary>
	        /// 资产ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 工作日配置
	        /// </summary>
	        [XmlArray("weekday_config_list")]
	        [XmlArrayItem("weekday_config_list")]
	        public List<WeekdayConfigListDomain> WeekdayConfigList { get; set; }
	
	        /// <summary>
	        /// 工段列表
	        /// </summary>
	        [XmlArray("workshop_section_code_list")]
	        [XmlArrayItem("string")]
	        public List<string> WorkshopSectionCodeList { get; set; }
}

    }
}
