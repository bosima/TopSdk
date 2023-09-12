using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduMainDataGetResponse.
    /// </summary>
    public class OapiEduMainDataGetResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenEduBureauStatisticalDataResponseDomain Result { get; set; }

        /// <summary>
        /// 成功or失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduBureauStatisticalDataResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduBureauStatisticalDataResponseDomain : TopObject
{
	        /// <summary>
	        /// 最近1天活跃班级圈数
	        /// </summary>
	        [XmlElement("act_class_circle_cnt_1d")]
	        public string ActClassCircleCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃班级圈数
	        /// </summary>
	        [XmlElement("act_class_circle_cnt_7d")]
	        public string ActClassCircleCnt7d { get; set; }
	
	        /// <summary>
	        /// 最近1天活跃班级群数
	        /// </summary>
	        [XmlElement("act_class_group_cnt_1d")]
	        public string ActClassGroupCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃班级群数
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
	        /// 注册班级数
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
	        /// 局id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 注册家长数
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
	        /// 注册学校数
	        /// </summary>
	        [XmlElement("school_cnt_std")]
	        public string SchoolCntStd { get; set; }
	
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
	        /// 统计日期
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
	
	        /// <summary>
	        /// 注册学生数
	        /// </summary>
	        [XmlElement("student_cnt_std")]
	        public string StudentCntStd { get; set; }
	
	        /// <summary>
	        /// 注册教师数
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
}

    }
}
