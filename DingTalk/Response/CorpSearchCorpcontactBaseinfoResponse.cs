using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpSearchCorpcontactBaseinfoResponse.
    /// </summary>
    public class CorpSearchCorpcontactBaseinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// GroupContactResultDomain Data Structure.
/// </summary>
[Serializable]

public class GroupContactResultDomain : TopObject
{
	        /// <summary>
	        /// aliTmpDept
	        /// </summary>
	        [XmlElement("ali_tmp_dept")]
	        public string AliTmpDept { get; set; }
	
	        /// <summary>
	        /// flowerName
	        /// </summary>
	        [XmlElement("flower_name")]
	        public string FlowerName { get; set; }
	
	        /// <summary>
	        /// jobNumber
	        /// </summary>
	        [XmlElement("job_number")]
	        public string JobNumber { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// workStation
	        /// </summary>
	        [XmlElement("work_station")]
	        public string WorkStation { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下次翻页的入参
	        /// </summary>
	        [XmlElement("offset")]
	        public long Offset { get; set; }
	
	        /// <summary>
	        /// 能获取的总条数(offset+size不能超过这个值)
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
	
	        /// <summary>
	        /// value
	        /// </summary>
	        [XmlArray("value_list")]
	        [XmlArrayItem("group_contact_result")]
	        public List<GroupContactResultDomain> ValueList { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// pageResult
	        /// </summary>
	        [XmlElement("page_result")]
	        public PageResultDomain PageResult { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
