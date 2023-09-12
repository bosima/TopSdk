using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavVideoconfGetResponse.
    /// </summary>
    public class OapiKacDatavVideoconfGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errormsg")]
        public string Errormsg { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        [XmlElement("result")]
        public McsSummaryResponseDomain Result { get; set; }

	/// <summary>
/// McsSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class McsSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 视频会议企业的累积消耗时长（即参会者入会总时长，且算到发起企业上）(毫秒)
	        /// </summary>
	        [XmlElement("join_video_conf_len")]
	        public long JoinVideoConfLen { get; set; }
	
	        /// <summary>
	        /// 视频会议成功参与人次
	        /// </summary>
	        [XmlElement("join_video_conf_secc_usr_cnt")]
	        public long JoinVideoConfSeccUsrCnt { get; set; }
	
	        /// <summary>
	        /// 视频会议成功参与用户数
	        /// </summary>
	        [XmlElement("join_video_conf_secc_usr_num")]
	        public long JoinVideoConfSeccUsrNum { get; set; }
	
	        /// <summary>
	        /// 参与视频会议用户数
	        /// </summary>
	        [XmlElement("join_video_conf_usr_cnt")]
	        public long JoinVideoConfUsrCnt { get; set; }
	
	        /// <summary>
	        /// 视频会议发起次数
	        /// </summary>
	        [XmlElement("start_video_conf_cnt")]
	        public long StartVideoConfCnt { get; set; }
	
	        /// <summary>
	        /// 成功发起视频会议数
	        /// </summary>
	        [XmlElement("start_video_conf_secc_cnt")]
	        public long StartVideoConfSeccCnt { get; set; }
	
	        /// <summary>
	        /// 视频会议发起用户数
	        /// </summary>
	        [XmlElement("start_video_conf_usr_num")]
	        public long StartVideoConfUsrNum { get; set; }
	
	        /// <summary>
	        /// 视频会议平均每通参与人次
	        /// </summary>
	        [XmlElement("video_conf_ave_usr_num")]
	        public long VideoConfAveUsrNum { get; set; }
}

    }
}
