using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEnterpriseFamilydrListResponse.
    /// </summary>
    public class OapiEnterpriseFamilydrListResponse : DingTalkResponse
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
        [XmlArrayItem("family_doctor_data_vo")]
        public List<FamilyDoctorDataVoDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FamilyDoctorDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class FamilyDoctorDataVoDomain : TopObject
{
	        /// <summary>
	        /// 企业ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 二级部门名称
	        /// </summary>
	        [XmlElement("dept_name_lv2")]
	        public string DeptNameLv2 { get; set; }
	
	        /// <summary>
	        /// 三级部门名称
	        /// </summary>
	        [XmlElement("dept_name_lv3")]
	        public string DeptNameLv3 { get; set; }
	
	        /// <summary>
	        /// 最近1天成功发起直播人数
	        /// </summary>
	        [XmlElement("live_launch_succ_user_cnt_1d")]
	        public string LiveLaunchSuccUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天成功发起直播人数
	        /// </summary>
	        [XmlElement("live_launch_succ_user_cnt_1w")]
	        public string LiveLaunchSuccUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 最近1天观看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_cnt_1d")]
	        public string LivePlayUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天观看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_cnt_1w")]
	        public string LivePlayUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 查询时间
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
}

    }
}
