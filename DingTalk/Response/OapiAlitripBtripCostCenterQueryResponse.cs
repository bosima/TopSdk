using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripCostCenterQueryResponse.
    /// </summary>
    public class OapiAlitripBtripCostCenterQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 成本中心列表
        /// </summary>
        [XmlArray("cost_center_list")]
        [XmlArrayItem("open_cost_center_query_rs")]
        public List<OpenCostCenterQueryRsDomain> CostCenterList { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenOrgEntityDoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenOrgEntityDoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 用户/部门/角色id
	        /// </summary>
	        [XmlElement("entity_id")]
	        public string EntityId { get; set; }
	
	        /// <summary>
	        /// 人员类型：1用户，2部门，3角色
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 用户/部门/角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色/部门下面员工人数
	        /// </summary>
	        [XmlElement("user_num")]
	        public long UserNum { get; set; }
}

	/// <summary>
/// OpenCostCenterQueryRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterQueryRsDomain : TopObject
{
	        /// <summary>
	        /// 绑定支付宝账号
	        /// </summary>
	        [XmlElement("alipay_no")]
	        public string AlipayNo { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 绑定人员信息
	        /// </summary>
	        [XmlArray("entity_list")]
	        [XmlArrayItem("open_org_entity_do")]
	        public List<OpenOrgEntityDoDomain> EntityList { get; set; }
	
	        /// <summary>
	        /// 商旅成本中心id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 成本中心编号
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// 适用范围: 1全员，2部分员工
	        /// </summary>
	        [XmlElement("scope")]
	        public long Scope { get; set; }
	
	        /// <summary>
	        /// 第三方成本中心id
	        /// </summary>
	        [XmlElement("thirdpart_id")]
	        public string ThirdpartId { get; set; }
	
	        /// <summary>
	        /// 成本中心名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
