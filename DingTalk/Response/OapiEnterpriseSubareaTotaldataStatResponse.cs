using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEnterpriseSubareaTotaldataStatResponse.
    /// </summary>
    public class OapiEnterpriseSubareaTotaldataStatResponse : DingTalkResponse
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
        [XmlArrayItem("area_stat_data_v_o")]
        public List<AreaStatDataVODomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AreaStatDataVODomain Data Structure.
/// </summary>
[Serializable]

public class AreaStatDataVODomain : TopObject
{
	        /// <summary>
	        /// 所辖区域活跃率
	        /// </summary>
	        [XmlElement("act_ratio_1d")]
	        public string ActRatio1d { get; set; }
	
	        /// <summary>
	        /// 活跃用户数最近1天
	        /// </summary>
	        [XmlElement("act_usr_cn_1d")]
	        public string ActUsrCn1d { get; set; }
	
	        /// <summary>
	        /// 历史截至当日激活会员数
	        /// </summary>
	        [XmlElement("active_mbr_cnt_std")]
	        public string ActiveMbrCntStd { get; set; }
	
	        /// <summary>
	        /// 所辖区域用户的激活率
	        /// </summary>
	        [XmlElement("active_mbr_ratio")]
	        public string ActiveMbrRatio { get; set; }
	
	        /// <summary>
	        /// 所属城市维度
	        /// </summary>
	        [XmlElement("city_lat")]
	        public string CityLat { get; set; }
	
	        /// <summary>
	        /// 所属城市经度
	        /// </summary>
	        [XmlElement("city_lng")]
	        public string CityLng { get; set; }
	
	        /// <summary>
	        /// 城市名称
	        /// </summary>
	        [XmlElement("city_name")]
	        public string CityName { get; set; }
	
	        /// <summary>
	        /// 企业ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 区/县纬度
	        /// </summary>
	        [XmlElement("county_lat")]
	        public string CountyLat { get; set; }
	
	        /// <summary>
	        /// 区/县经度
	        /// </summary>
	        [XmlElement("county_lng")]
	        public string CountyLng { get; set; }
	
	        /// <summary>
	        /// 城市所在区域
	        /// </summary>
	        [XmlElement("county_name")]
	        public string CountyName { get; set; }
	
	        /// <summary>
	        /// 历史截至当日企业会员数
	        /// </summary>
	        [XmlElement("mbr_cnt_std")]
	        public string MbrCntStd { get; set; }
	
	        /// <summary>
	        /// 所辖区域在线组织数
	        /// </summary>
	        [XmlElement("online_org_cnt")]
	        public string OnlineOrgCnt { get; set; }
	
	        /// <summary>
	        /// 所辖区域组织覆盖率
	        /// </summary>
	        [XmlElement("org_online_ratio")]
	        public string OrgOnlineRatio { get; set; }
	
	        /// <summary>
	        /// 所辖区域实际组织数
	        /// </summary>
	        [XmlElement("real_org_cnt")]
	        public string RealOrgCnt { get; set; }
	
	        /// <summary>
	        /// 发送消息数量
	        /// </summary>
	        [XmlElement("send_message_cnt_1d")]
	        public string SendMessageCnt1d { get; set; }
	
	        /// <summary>
	        /// 发送消息人数
	        /// </summary>
	        [XmlElement("send_message_user_cnt_1d")]
	        public string SendMessageUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 查询时间
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
}

    }
}
