using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProjectPointRuleListResponse.
    /// </summary>
    public class OapiProjectPointRuleListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 积分（获取/增加）规则
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 组织ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 单日计次上限，0表示无上限
	        /// </summary>
	        [XmlElement("day_limit_times")]
	        public long DayLimitTimes { get; set; }
	
	        /// <summary>
	        /// 扩展字段,JSONMap格式
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 分组ID, 默认写入为0
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 排序ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 规则代码（有唯一约束）
	        /// </summary>
	        [XmlElement("rule_code")]
	        public string RuleCode { get; set; }
	
	        /// <summary>
	        /// 规则名称
	        /// </summary>
	        [XmlElement("rule_name")]
	        public string RuleName { get; set; }
	
	        /// <summary>
	        /// 分数:正数表示增加/负数表示扣减
	        /// </summary>
	        [XmlElement("score")]
	        public long Score { get; set; }
	
	        /// <summary>
	        /// 生效状态 0：不生效，1：生效
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

    }
}
