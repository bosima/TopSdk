using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavAnnualReportGetResponse.
    /// </summary>
    public class OapiKacDatavAnnualReportGetResponse : DingTalkResponse
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
        /// 返回结果对象
        /// </summary>
        [XmlElement("result")]
        public AnnualReportResponseDomain Result { get; set; }

	/// <summary>
/// AnnualReportResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AnnualReportResponseDomain : TopObject
{
	        /// <summary>
	        /// 年累计活跃天数
	        /// </summary>
	        [XmlElement("act_usr_days_1y")]
	        public long ActUsrDays1y { get; set; }
	
	        /// <summary>
	        /// 年累计打卡天数
	        /// </summary>
	        [XmlElement("at_check_days_1y")]
	        public long AtCheckDays1y { get; set; }
	
	        /// <summary>
	        /// 年累计被at数
	        /// </summary>
	        [XmlElement("at_me_msg_cnt_1y")]
	        public long AtMeMsgCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计审批平均处理时间（分钟）
	        /// </summary>
	        [XmlElement("avg_process_duration_1y")]
	        public string AvgProcessDuration1y { get; set; }
	
	        /// <summary>
	        /// 年累计企业自建应用发起的审批数
	        /// </summary>
	        [XmlElement("corp_app_process_inst_cnt_1y")]
	        public long CorpAppProcessInstCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计创建文档数
	        /// </summary>
	        [XmlElement("create_doc_cnt_1y")]
	        public long CreateDocCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计创建审批数
	        /// </summary>
	        [XmlElement("create_process_cnt_1y")]
	        public long CreateProcessCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计创建智能填表数
	        /// </summary>
	        [XmlElement("create_smartwork_cnt_1y")]
	        public long CreateSmartworkCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计智能填表的人次，仅当type=1时有效
	        /// </summary>
	        [XmlElement("general_form_user_cnt_1y")]
	        public long GeneralFormUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计新增内部群聊数量，仅当type=3时有效
	        /// </summary>
	        [XmlElement("inner_group_cnt_1y")]
	        public long InnerGroupCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计阅读互动服务窗文章数量
	        /// </summary>
	        [XmlElement("isw_msg_click_cnt_1y")]
	        public string IswMsgClickCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参加日程数
	        /// </summary>
	        [XmlElement("join_calendar_cnt_1y")]
	        public long JoinCalendarCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参加日程人数
	        /// </summary>
	        [XmlElement("join_calendar_user_cnt_1y")]
	        public long JoinCalendarUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计加入群数
	        /// </summary>
	        [XmlElement("join_group_cnt_1y")]
	        public long JoinGroupCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发起视频会议时长（分钟）
	        /// </summary>
	        [XmlElement("join_succ_video_conf_len_1y")]
	        public string JoinSuccVideoConfLen1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与（含发起）视频会议次数
	        /// </summary>
	        [XmlElement("join_succ_video_conf_num_1y")]
	        public long JoinSuccVideoConfNum1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与（含发起）视频会议人次，仅当type=1时有效
	        /// </summary>
	        [XmlElement("join_succ_video_conf_user_cnt_1y")]
	        public long JoinSuccVideoConfUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与（含发起）语音会议时长（分钟）
	        /// </summary>
	        [XmlElement("join_succ_voip_conf_len_1y")]
	        public string JoinSuccVoipConfLen1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与（含发起）语音会议次数
	        /// </summary>
	        [XmlElement("join_succ_voip_conf_num_1y")]
	        public long JoinSuccVoipConfNum1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与（含发起）语音会议人次，仅当type=1时有效
	        /// </summary>
	        [XmlElement("join_succ_voip_conf_user_cnt_1y")]
	        public long JoinSuccVoipConfUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与直播次数
	        /// </summary>
	        [XmlElement("live_join_succ_cnt_1y")]
	        public long LiveJoinSuccCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与直播时长（分钟）
	        /// </summary>
	        [XmlElement("live_join_succ_time_len_1y")]
	        public string LiveJoinSuccTimeLen1y { get; set; }
	
	        /// <summary>
	        /// 年累计最高运动步数
	        /// </summary>
	        [XmlElement("max_step_count_1y")]
	        public long MaxStepCount1y { get; set; }
	
	        /// <summary>
	        /// 年累计审批最短处理时间（分钟）
	        /// </summary>
	        [XmlElement("min_process_duration_1y")]
	        public string MinProcessDuration1y { get; set; }
	
	        /// <summary>
	        /// 年累计新增群数
	        /// </summary>
	        [XmlElement("new_group_cnt_1y")]
	        public long NewGroupCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计外勤天数
	        /// </summary>
	        [XmlElement("outside_days_1y")]
	        public long OutsideDays1y { get; set; }
	
	        /// <summary>
	        /// 处理审批数
	        /// </summary>
	        [XmlElement("process_inst_operate_cnt_1y")]
	        public long ProcessInstOperateCnt1y { get; set; }
	
	        /// <summary>
	        /// 发起审批数
	        /// </summary>
	        [XmlElement("process_inst_submit_cnt_1y")]
	        public long ProcessInstSubmitCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计接收DING数
	        /// </summary>
	        [XmlElement("recv_ding_cnt_1y")]
	        public long RecvDingCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计新建日程数
	        /// </summary>
	        [XmlElement("send_calendar_cnt_1y")]
	        public long SendCalendarCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计新建日程人数
	        /// </summary>
	        [XmlElement("send_calendar_user_cnt_1y")]
	        public long SendCalendarUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送DING数
	        /// </summary>
	        [XmlElement("send_ding_cnt_1y")]
	        public long SendDingCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送DING人数
	        /// </summary>
	        [XmlElement("send_ding_user_cnt_1y")]
	        public long SendDingUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送群文件数
	        /// </summary>
	        [XmlElement("send_group_file_message_cnt_1y")]
	        public long SendGroupFileMessageCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送群聊消息数
	        /// </summary>
	        [XmlElement("send_group_msg_cnt_1y")]
	        public long SendGroupMsgCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送群聊人数
	        /// </summary>
	        [XmlElement("send_group_msg_user_cnt_1y")]
	        public long SendGroupMsgUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计活跃群数（发消息群）
	        /// </summary>
	        [XmlElement("send_message_group_cnt_1y")]
	        public long SendMessageGroupCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送日志数
	        /// </summary>
	        [XmlElement("send_report_cnt_1y")]
	        public long SendReportCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计发送日志人数
	        /// </summary>
	        [XmlElement("send_report_user_cnt_1y")]
	        public long SendReportUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 发起视频会议时长（分钟）
	        /// </summary>
	        [XmlElement("start_succ_video_conf_len_1y")]
	        public long StartSuccVideoConfLen1y { get; set; }
	
	        /// <summary>
	        /// 使用文档用户数（创建、编辑、分享、阅读）
	        /// </summary>
	        [XmlElement("use_doc_user_cnt_1y")]
	        public long UseDocUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计使用的应用数量
	        /// </summary>
	        [XmlElement("use_micro_app_cnt_1y")]
	        public long UseMicroAppCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计使用的应用人数，仅当type=1,2时有效
	        /// </summary>
	        [XmlElement("use_micro_user_cnt_1y")]
	        public long UseMicroUserCnt1y { get; set; }
	
	        /// <summary>
	        /// 年累计参与智能填表数
	        /// </summary>
	        [XmlElement("use_smartwork_cnt_1y")]
	        public long UseSmartworkCnt1y { get; set; }
}

    }
}
