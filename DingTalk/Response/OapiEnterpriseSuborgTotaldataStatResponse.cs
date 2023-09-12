using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEnterpriseSuborgTotaldataStatResponse.
    /// </summary>
    public class OapiEnterpriseSuborgTotaldataStatResponse : DingTalkResponse
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
	        /// 最近1天活跃率
	        /// </summary>
	        [XmlElement("act_ratio_1d")]
	        public string ActRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃率
	        /// </summary>
	        [XmlElement("act_ratio_1w")]
	        public string ActRatio1w { get; set; }
	
	        /// <summary>
	        /// 活跃用户数最近1天
	        /// </summary>
	        [XmlElement("act_usr_cnt_1d")]
	        public string ActUsrCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天活跃用户数
	        /// </summary>
	        [XmlElement("act_usr_cnt_1w")]
	        public string ActUsrCnt1w { get; set; }
	
	        /// <summary>
	        /// 历史截至当日激活会员数
	        /// </summary>
	        [XmlElement("active_mbr_cnt_std")]
	        public string ActiveMbrCntStd { get; set; }
	
	        /// <summary>
	        /// 激活率
	        /// </summary>
	        [XmlElement("active_ratio")]
	        public string ActiveRatio { get; set; }
	
	        /// <summary>
	        /// 企业ID
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
	        [XmlElement("ding_index_1w")]
	        public string DingIndex1w { get; set; }
	
	        /// <summary>
	        /// 历史截至当日企业会员数
	        /// </summary>
	        [XmlElement("mbr_cnt_std")]
	        public string MbrCntStd { get; set; }
	
	        /// <summary>
	        /// 最近1天使用钉钉微应用用户比率
	        /// </summary>
	        [XmlElement("micro_app_use_ratio_1d")]
	        public string MicroAppUseRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天使用钉钉微应用用户比率
	        /// </summary>
	        [XmlElement("micro_app_use_ratio_1w")]
	        public string MicroAppUseRatio1w { get; set; }
	
	        /// <summary>
	        /// 最近1天使用钉钉微应用用户数
	        /// </summary>
	        [XmlElement("micro_app_user_cnt_1d")]
	        public string MicroAppUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天使用钉钉微应用用户数
	        /// </summary>
	        [XmlElement("micro_app_user_cnt_1w")]
	        public string MicroAppUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 审批模板数
	        /// </summary>
	        [XmlElement("pm_form_cnt_001")]
	        public string PmFormCnt001 { get; set; }
	
	        /// <summary>
	        /// 自定义模板数
	        /// </summary>
	        [XmlElement("pm_form_cnt_002")]
	        public string PmFormCnt002 { get; set; }
	
	        /// <summary>
	        /// 自定义模板比率
	        /// </summary>
	        [XmlElement("pm_form_self_def_ratio")]
	        public string PmFormSelfDefRatio { get; set; }
	
	        /// <summary>
	        /// 最近1天使用审批用户数
	        /// </summary>
	        [XmlElement("process_user_cnt_1d")]
	        public string ProcessUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天使用审批用户数
	        /// </summary>
	        [XmlElement("process_user_cnt_1w")]
	        public string ProcessUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 最近1天使用审批的用户比率
	        /// </summary>
	        [XmlElement("process_user_ratio_1d")]
	        public string ProcessUserRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天使用审批的用户比率
	        /// </summary>
	        [XmlElement("process_user_ratio_1w")]
	        public string ProcessUserRatio1w { get; set; }
	
	        /// <summary>
	        /// 最近1天沟通用户数
	        /// </summary>
	        [XmlElement("send_message_user_cnt_1d")]
	        public string SendMessageUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天沟通用户数
	        /// </summary>
	        [XmlElement("send_message_user_cnt_1w")]
	        public string SendMessageUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 最近1天沟通率
	        /// </summary>
	        [XmlElement("send_message_user_ratio_1d")]
	        public string SendMessageUserRatio1d { get; set; }
	
	        /// <summary>
	        /// 最近7天沟通率
	        /// </summary>
	        [XmlElement("send_message_user_ratio_1w")]
	        public string SendMessageUserRatio1w { get; set; }
	
	        /// <summary>
	        /// 查询时间
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
	
	        /// <summary>
	        /// 所辖组织的地理纬度
	        /// </summary>
	        [XmlElement("sub_org_area_lat")]
	        public string SubOrgAreaLat { get; set; }
	
	        /// <summary>
	        /// 所辖组织的地理经度
	        /// </summary>
	        [XmlElement("sub_org_area_lng")]
	        public string SubOrgAreaLng { get; set; }
	
	        /// <summary>
	        /// 所辖组织名称
	        /// </summary>
	        [XmlElement("sub_org_name")]
	        public string SubOrgName { get; set; }
}

    }
}
