using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduSubDataGetResponse.
    /// </summary>
    public class OapiEduSubDataGetResponse : DingTalkResponse
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
        /// 结果集
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_edu_school_statistical_data_response")]
        public List<OpenEduSchoolStatisticalDataResponseDomain> Result { get; set; }

        /// <summary>
        /// 成功or失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduSchoolStatisticalDataResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSchoolStatisticalDataResponseDomain : TopObject
{
	        /// <summary>
	        /// 最近1天活跃的班级圈数
	        /// </summary>
	        [XmlElement("act_class_circle_cnt_1d")]
	        public string ActClassCircleCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃的班级圈数
	        /// </summary>
	        [XmlElement("act_class_circle_cnt_7d")]
	        public string ActClassCircleCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃的班级群数
	        /// </summary>
	        [XmlElement("act_class_group_cnt_1d")]
	        public string ActClassGroupCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃的班级群数
	        /// </summary>
	        [XmlElement("act_class_group_cnt_7d")]
	        public string ActClassGroupCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃家长数量
	        /// </summary>
	        [XmlElement("act_patriarch_cnt_1d")]
	        public string ActPatriarchCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃家长数量
	        /// </summary>
	        [XmlElement("act_patriarch_cnt_7d")]
	        public string ActPatriarchCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃教师数量
	        /// </summary>
	        [XmlElement("act_teacher_cnt_1d")]
	        public string ActTeacherCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃教师数量
	        /// </summary>
	        [XmlElement("act_teacher_cnt_7d")]
	        public string ActTeacherCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃用户数
	        /// </summary>
	        [XmlElement("act_usr_cnt_1d")]
	        public string ActUsrCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天总活跃用户数
	        /// </summary>
	        [XmlElement("act_usr_cnt_7d")]
	        public string ActUsrCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃率
	        /// </summary>
	        [XmlElement("act_usr_ratio_1d")]
	        public string ActUsrRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃率
	        /// </summary>
	        [XmlElement("act_usr_ratio_7d")]
	        public string ActUsrRatio7d { get; set; }
	
	        /// <summary>
	        /// 激活用户数
	        /// </summary>
	        [XmlElement("active_mbr_cnt_std")]
	        public string ActiveMbrCntStd { get; set; }
	
	        /// <summary>
	        /// 数字化教师数量
	        /// </summary>
	        [XmlElement("auth_teacher_cnt_std")]
	        public string AuthTeacherCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天班级打卡使用人数
	        /// </summary>
	        [XmlElement("class_card_user_cnt_1d")]
	        public string ClassCardUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天班级打卡使用人数
	        /// </summary>
	        [XmlElement("class_card_user_cnt_7d")]
	        public string ClassCardUserCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天班级圈使用人数
	        /// </summary>
	        [XmlElement("class_circle_user_cnt_1d")]
	        public string ClassCircleUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天班级圈使用人数
	        /// </summary>
	        [XmlElement("class_circle_user_cnt_7d")]
	        public string ClassCircleUserCnt7d { get; set; }
	
	        /// <summary>
	        /// 班级数量
	        /// </summary>
	        [XmlElement("class_cnt_std")]
	        public string ClassCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天班级群使用人数
	        /// </summary>
	        [XmlElement("class_group_user_cnt_1d")]
	        public string ClassGroupUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天班级群使用人数
	        /// </summary>
	        [XmlElement("class_group_user_cnt_7d")]
	        public string ClassGroupUserCnt7d { get; set; }
	
	        /// <summary>
	        /// 教育局ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 最近1天钉钉指数
	        /// </summary>
	        [XmlElement("ding_index_1d")]
	        public string DingIndex1d { get; set; }
	
	        /// <summary>
	        /// 最近7天钉钉指数
	        /// </summary>
	        [XmlElement("ding_index_7d")]
	        public string DingIndex7d { get; set; }
	
	        /// <summary>
	        /// 最近1天成功发起直播次数
	        /// </summary>
	        [XmlElement("live_launch_succ_cnt_1d")]
	        public string LiveLaunchSuccCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天成功发起直播次数
	        /// </summary>
	        [XmlElement("live_launch_succ_cnt_7d")]
	        public string LiveLaunchSuccCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天观看和回看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_cnt_1d")]
	        public string LivePlayUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天观看和回看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_cnt_7d")]
	        public string LivePlayUserCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天成功发起直播时长
	        /// </summary>
	        [XmlElement("live_succ_time_len_1d")]
	        public string LiveSuccTimeLen1d { get; set; }
	
	        /// <summary>
	        /// 最近7天成功发起直播时长
	        /// </summary>
	        [XmlElement("live_succ_time_len_7d")]
	        public string LiveSuccTimeLen7d { get; set; }
	
	        /// <summary>
	        /// 激活率
	        /// </summary>
	        [XmlElement("mbr_active_ratio")]
	        public string MbrActiveRatio { get; set; }
	
	        /// <summary>
	        /// 通讯录人数
	        /// </summary>
	        [XmlElement("mbr_cnt_std")]
	        public string MbrCntStd { get; set; }
	
	        /// <summary>
	        /// 多家长监管学生数
	        /// </summary>
	        [XmlElement("multi_patriarch_student_cnt")]
	        public string MultiPatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 多家长监管学生比率
	        /// </summary>
	        [XmlElement("multi_patriarch_student_ratio")]
	        public string MultiPatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 无家长监管学生数
	        /// </summary>
	        [XmlElement("none_patriarch_student_cnt")]
	        public string NonePatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 无家长监管学生比率
	        /// </summary>
	        [XmlElement("none_patriarch_student_ratio")]
	        public string NonePatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 家长数量
	        /// </summary>
	        [XmlElement("patriarch_cnt_std")]
	        public string PatriarchCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天接收DING的家长数
	        /// </summary>
	        [XmlElement("rcv_ding_patriarch_cnt_1d")]
	        public string RcvDingPatriarchCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天接收DING的家长数
	        /// </summary>
	        [XmlElement("rcv_ding_patriarch_cnt_7d")]
	        public string RcvDingPatriarchCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天班级圈发送数
	        /// </summary>
	        [XmlElement("send_circle_post_cnt_1d")]
	        public string SendCirclePostCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天班级圈发送数
	        /// </summary>
	        [XmlElement("send_circle_post_cnt_7d")]
	        public string SendCirclePostCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天沟通用户数
	        /// </summary>
	        [XmlElement("send_msg_user_cnt_1d")]
	        public string SendMsgUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天沟通用户数
	        /// </summary>
	        [XmlElement("send_msg_user_cnt_7d")]
	        public string SendMsgUserCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天沟通率
	        /// </summary>
	        [XmlElement("send_msg_user_ratio_1d")]
	        public string SendMsgUserRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天沟通率
	        /// </summary>
	        [XmlElement("send_msg_user_ratio_7d")]
	        public string SendMsgUserRatio7d { get; set; }
	
	        /// <summary>
	        /// 单家长监管学生数
	        /// </summary>
	        [XmlElement("single_patriarch_student_cnt")]
	        public string SinglePatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 单家长监管学生比率
	        /// </summary>
	        [XmlElement("single_patriarch_student_ratio")]
	        public string SinglePatriarchStudentRatio { get; set; }
	
	        /// <summary>
	        /// 统计日期
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
	
	        /// <summary>
	        /// 学生数量
	        /// </summary>
	        [XmlElement("student_cnt_std")]
	        public string StudentCntStd { get; set; }
	
	        /// <summary>
	        /// 所辖组织的地理纬度
	        /// </summary>
	        [XmlElement("sub_corp_area_lat")]
	        public string SubCorpAreaLat { get; set; }
	
	        /// <summary>
	        /// 所辖组织的地理经度
	        /// </summary>
	        [XmlElement("sub_corp_area_lng")]
	        public string SubCorpAreaLng { get; set; }
	
	        /// <summary>
	        /// 学校id
	        /// </summary>
	        [XmlElement("sub_corp_id")]
	        public string SubCorpId { get; set; }
	
	        /// <summary>
	        /// 学校名称
	        /// </summary>
	        [XmlElement("sub_corp_name")]
	        public string SubCorpName { get; set; }
	
	        /// <summary>
	        /// 教师数量
	        /// </summary>
	        [XmlElement("teacher_cnt_std")]
	        public string TeacherCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天教师钉消息发送数
	        /// </summary>
	        [XmlElement("teacher_send_ding_cnt_1d")]
	        public string TeacherSendDingCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天教师钉消息发送数
	        /// </summary>
	        [XmlElement("teacher_send_ding_cnt_7d")]
	        public string TeacherSendDingCnt7d { get; set; }
	
	        /// <summary>
	        /// 双家长监管学生数
	        /// </summary>
	        [XmlElement("two_patriarch_student_cnt")]
	        public string TwoPatriarchStudentCnt { get; set; }
	
	        /// <summary>
	        /// 双家长监管学生比率
	        /// </summary>
	        [XmlElement("two_patriarch_student_ratio")]
	        public string TwoPatriarchStudentRatio { get; set; }
}

    }
}
