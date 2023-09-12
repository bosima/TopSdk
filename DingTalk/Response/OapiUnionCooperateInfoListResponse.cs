using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUnionCooperateInfoListResponse.
    /// </summary>
    public class OapiUnionCooperateInfoListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 加入/申请加入空间信息
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_cooperate_union_vo")]
        public List<OpenCooperateUnionVoDomain> Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCooperateUnionVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCooperateUnionVoDomain : TopObject
{
	        /// <summary>
	        /// 加入企业认证等级0 未认证 1高级认证 2中级认证 3初级认证
	        /// </summary>
	        [XmlElement("auth_level")]
	        public long AuthLevel { get; set; }
	
	        /// <summary>
	        /// 挂载部门ID(在合作空间中的架构属性)
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 加入的部门列表(部门下的员工会全部加入)
	        /// </summary>
	        [XmlArray("dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIds { get; set; }
	
	        /// <summary>
	        /// 挂载部门名称(在合作空间中的架构属性)，不设置默认是加入企业的名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 加入企业的企业corpId
	        /// </summary>
	        [XmlElement("union_corp_id")]
	        public string UnionCorpId { get; set; }
	
	        /// <summary>
	        /// 加入企业的企业名称
	        /// </summary>
	        [XmlElement("union_org_name")]
	        public string UnionOrgName { get; set; }
	
	        /// <summary>
	        /// 加入的方式：1全部加入(不需要选择部门和员工) 2部分加入
	        /// </summary>
	        [XmlElement("union_type")]
	        public long UnionType { get; set; }
	
	        /// <summary>
	        /// 单独加入的员工(所在部门不需要加入的情况，直接选择的几个员工)
	        /// </summary>
	        [XmlArray("userids")]
	        [XmlArrayItem("string")]
	        public List<string> Userids { get; set; }
}

    }
}
