using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEnterpriseMainorgTotaldataStatResponse.
    /// </summary>
    public class OapiEnterpriseMainorgTotaldataStatResponse : DingTalkResponse
    {
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
        /// 系统自动生成
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("main_stat_data_vo")]
        public List<MainStatDataVoDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MainStatDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class MainStatDataVoDomain : TopObject
{
	        /// <summary>
	        /// 在线组织激活用户数
	        /// </summary>
	        [XmlElement("active_mbr_cnt_std")]
	        public string ActiveMbrCntStd { get; set; }
	
	        /// <summary>
	        /// 全员群数量
	        /// </summary>
	        [XmlElement("all_group_cnt")]
	        public string AllGroupCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天降低碳排量G
	        /// </summary>
	        [XmlElement("carbon_amount_1d")]
	        public string CarbonAmount1d { get; set; }
	
	        /// <summary>
	        /// 最近7天降低碳排量G
	        /// </summary>
	        [XmlElement("carbon_amount_1w")]
	        public string CarbonAmount1w { get; set; }
	
	        /// <summary>
	        /// 企业ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 部门群数量
	        /// </summary>
	        [XmlElement("dept_group_cnt")]
	        public string DeptGroupCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天钉办节约小时
	        /// </summary>
	        [XmlElement("ding_save_hour_1d")]
	        public string DingSaveHour1d { get; set; }
	
	        /// <summary>
	        /// 最近7天钉办节约小时
	        /// </summary>
	        [XmlElement("ding_save_hour_1w")]
	        public string DingSaveHour1w { get; set; }
	
	        /// <summary>
	        /// 最近7天发送消息人数
	        /// </summary>
	        [XmlElement("end_message_user_cnt_1w")]
	        public string EndMessageUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 内部群数量
	        /// </summary>
	        [XmlElement("innerGroupCnt")]
	        public string InnerGroupCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天成功发起直播次数
	        /// </summary>
	        [XmlElement("liveLaunchSuccCnt1d")]
	        public string LiveLaunchSuccCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天成功发起直播次数
	        /// </summary>
	        [XmlElement("liveLaunchSuccCnt1w")]
	        public string LiveLaunchSuccCnt1w { get; set; }
	
	        /// <summary>
	        /// 在线组织通讯录人数
	        /// </summary>
	        [XmlElement("mbr_cnt_std")]
	        public string MbrCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天在线会议次数
	        /// </summary>
	        [XmlElement("online_conference_cnt_1d")]
	        public string OnlineConferenceCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天在线会议次数
	        /// </summary>
	        [XmlElement("online_conference_cnt_7d")]
	        public string OnlineConferenceCnt7d { get; set; }
	
	        /// <summary>
	        /// 在线组织数
	        /// </summary>
	        [XmlElement("online_org_nt")]
	        public string OnlineOrgNt { get; set; }
	
	        /// <summary>
	        /// 组织覆盖率
	        /// </summary>
	        [XmlElement("org_online_ratio")]
	        public string OrgOnlineRatio { get; set; }
	
	        /// <summary>
	        /// 实际组织数
	        /// </summary>
	        [XmlElement("real_org_cnt")]
	        public string RealOrgCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天接收DING的用户数
	        /// </summary>
	        [XmlElement("receive_ding_user_cnt_1d")]
	        public string ReceiveDingUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天接收DING的用户数
	        /// </summary>
	        [XmlElement("receive_ding_user_cnt_1w")]
	        public string ReceiveDingUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 关联组织数
	        /// </summary>
	        [XmlElement("rel_org_nt")]
	        public string RelOrgNt { get; set; }
	
	        /// <summary>
	        /// 最近1天发送消息人数
	        /// </summary>
	        [XmlElement("send_message_user_cnt_1d")]
	        public string SendMessageUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 统计日期
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
}

    }
}
