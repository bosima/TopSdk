using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresEmployeeProductionteamListResponse.
    /// </summary>
    public class OapiRhinoHumanresEmployeeProductionteamListResponse : DingTalkResponse
    {
        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlArray("corp_employee_info")]
        [XmlArrayItem("model")]
        public List<ModelDomain> CorpEmployeeInfo { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
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
/// ProductionTeamListDomain Data Structure.
/// </summary>
[Serializable]

public class ProductionTeamListDomain : TopObject
{
	        /// <summary>
	        /// 生产组业务ID
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 产能类型
	        /// </summary>
	        [XmlElement("capacity_type")]
	        public string CapacityType { get; set; }
	
	        /// <summary>
	        /// 是否删除
	        /// </summary>
	        [XmlElement("deleted")]
	        public bool Deleted { get; set; }
	
	        /// <summary>
	        /// 员工数量
	        /// </summary>
	        [XmlElement("emp_num")]
	        public long EmpNum { get; set; }
	
	        /// <summary>
	        /// 分组code
	        /// </summary>
	        [XmlElement("group_code")]
	        public string GroupCode { get; set; }
	
	        /// <summary>
	        /// modifier
	        /// </summary>
	        [XmlElement("modifier")]
	        public string Modifier { get; set; }
	
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
}

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
	        /// bucId
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
	        /// 全局钉钉员工ID
	        /// </summary>
	        [XmlElement("dingtalk_no")]
	        public string DingtalkNo { get; set; }
	
	        /// <summary>
	        /// 企业下钉钉员工ID
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
	        /// 拥有的生产组
	        /// </summary>
	        [XmlArray("production_team_list")]
	        [XmlArrayItem("production_team_list")]
	        public List<ProductionTeamListDomain> ProductionTeamList { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 资产ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
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
	        /// 工作状态
	        /// </summary>
	        [XmlElement("work_status")]
	        public long WorkStatus { get; set; }
}

    }
}
