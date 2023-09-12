using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessListbyuseridResponse.
    /// </summary>
    public class OapiProcessListbyuseridResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public HomePageProcessTemplateVoDomain Result { get; set; }

	/// <summary>
/// ProcessTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessTopVoDomain : TopObject
{
	        /// <summary>
	        /// 图标url
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 模板唯一标识
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 模板url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HomePageProcessTemplateVoDomain Data Structure.
/// </summary>
[Serializable]

public class HomePageProcessTemplateVoDomain : TopObject
{
	        /// <summary>
	        /// 下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("process_list")]
	        [XmlArrayItem("process_top_vo")]
	        public List<ProcessTopVoDomain> ProcessList { get; set; }
}

    }
}
