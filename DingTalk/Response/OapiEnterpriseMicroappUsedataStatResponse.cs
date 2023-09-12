using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEnterpriseMicroappUsedataStatResponse.
    /// </summary>
    public class OapiEnterpriseMicroappUsedataStatResponse : DingTalkResponse
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
        [XmlArrayItem("micro_app_data_v_o")]
        public List<MicroAppDataVODomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MicroAppDataVODomain Data Structure.
/// </summary>
[Serializable]

public class MicroAppDataVODomain : TopObject
{
	        /// <summary>
	        /// 组织微应用名称
	        /// </summary>
	        [XmlElement("agent_name")]
	        public string AgentName { get; set; }
	
	        /// <summary>
	        /// 企业ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 最近1天打开微应用用户数
	        /// </summary>
	        [XmlElement("open_micro_user_cnt_1d")]
	        public string OpenMicroUserCnt1d { get; set; }
	
	        /// <summary>
	        /// 最近7天打开微应用用户数
	        /// </summary>
	        [XmlElement("open_micro_user_cnt_1w")]
	        public string OpenMicroUserCnt1w { get; set; }
	
	        /// <summary>
	        /// 查询时间
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
}

    }
}
