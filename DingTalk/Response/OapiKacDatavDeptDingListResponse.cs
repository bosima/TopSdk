using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDeptDingListResponse.
    /// </summary>
    public class OapiKacDatavDeptDingListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误吗
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// resut
        /// </summary>
        [XmlElement("result")]
        public DingUsageDeptSummaryResponseDomain Result { get; set; }

	/// <summary>
/// DingUsageDeptSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class DingUsageDeptSummaryVoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 最近一天发送应用ding数量
	        /// </summary>
	        [XmlElement("ding_app_cnt")]
	        public long DingAppCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送应用ding人数
	        /// </summary>
	        [XmlElement("ding_app_user_cnt")]
	        public long DingAppUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送电话ding数量
	        /// </summary>
	        [XmlElement("ding_call_cnt")]
	        public long DingCallCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送电话ding人数
	        /// </summary>
	        [XmlElement("ding_call_user_cnt")]
	        public long DingCallUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送ding的数量
	        /// </summary>
	        [XmlElement("ding_cnt")]
	        public long DingCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送短信ding数量
	        /// </summary>
	        [XmlElement("ding_sms_cnt")]
	        public long DingSmsCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送短信ding人数
	        /// </summary>
	        [XmlElement("ding_sms_user_cnt")]
	        public long DingSmsUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送ding的人数
	        /// </summary>
	        [XmlElement("ding_user_cnt")]
	        public long DingUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送语音ding数量
	        /// </summary>
	        [XmlElement("ding_voip_cnt")]
	        public long DingVoipCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送语音ding人数
	        /// </summary>
	        [XmlElement("ding_voip_user_cnt")]
	        public long DingVoipUserCnt { get; set; }
	
	        /// <summary>
	        /// 历史累计发钉数
	        /// </summary>
	        [XmlElement("send_ding_total_cnt")]
	        public string SendDingTotalCnt { get; set; }
}

	/// <summary>
/// DingUsageDeptSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DingUsageDeptSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("ding_usage_dept_summary_vo")]
	        public List<DingUsageDeptSummaryVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
