using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDingtaxGroupdaudataGetResponse.
    /// </summary>
    public class OapiDingtaxGroupdaudataGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果返回一个记录列表，列表中每一项包含union_id，open_conversation_id，stat_date三个属性
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("dingtax_group_dau_record")]
        public List<DingtaxGroupDauRecordDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DingtaxGroupDauRecordDomain Data Structure.
/// </summary>
[Serializable]

public class DingtaxGroupDauRecordDomain : TopObject
{
	        /// <summary>
	        /// 开放群ID
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 统计日期(格式为 yyyymmdd)
	        /// </summary>
	        [XmlElement("stat_date")]
	        public string StatDate { get; set; }
	
	        /// <summary>
	        /// 用户的unionId
	        /// </summary>
	        [XmlElement("union_id")]
	        public string UnionId { get; set; }
}

    }
}
