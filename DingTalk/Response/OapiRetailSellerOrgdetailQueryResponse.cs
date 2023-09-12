using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRetailSellerOrgdetailQueryResponse.
    /// </summary>
    public class OapiRetailSellerOrgdetailQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 组织列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("org_dto")]
        public List<OrgDtoDomain> Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ShopEmpDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ShopEmpDtoDomain : TopObject
{
	        /// <summary>
	        /// 主子账号
	        /// </summary>
	        [XmlElement("emp_type")]
	        public string EmpType { get; set; }
	
	        /// <summary>
	        /// 员工姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 卖家ID
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 卖家子账号ID
	        /// </summary>
	        [XmlElement("outer_sub_id")]
	        public string OuterSubId { get; set; }
	
	        /// <summary>
	        /// 绑定淘宝账号nick
	        /// </summary>
	        [XmlElement("seller_nick")]
	        public string SellerNick { get; set; }
	
	        /// <summary>
	        /// staffId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// SellerDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SellerDtoDomain : TopObject
{
	        /// <summary>
	        /// 卖家ID
	        /// </summary>
	        [XmlElement("seller_id")]
	        public long SellerId { get; set; }
	
	        /// <summary>
	        /// 卖家昵称
	        /// </summary>
	        [XmlElement("seller_nick")]
	        public string SellerNick { get; set; }
	
	        /// <summary>
	        /// 卖家绑定的员工list
	        /// </summary>
	        [XmlArray("shop_emp_list")]
	        [XmlArrayItem("shop_emp_dto")]
	        public List<ShopEmpDtoDomain> ShopEmpList { get; set; }
	
	        /// <summary>
	        /// 天猫店 淘宝店
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// staffId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OrgDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrgDtoDomain : TopObject
{
	        /// <summary>
	        /// 组织绑定卖家List
	        /// </summary>
	        [XmlArray("bind_sellers")]
	        [XmlArrayItem("seller_dto")]
	        public List<SellerDtoDomain> BindSellers { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 组织创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 组织名
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
}

    }
}
