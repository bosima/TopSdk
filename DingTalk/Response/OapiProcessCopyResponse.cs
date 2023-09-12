using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessCopyResponse.
    /// </summary>
    public class OapiProcessCopyResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ProcessVoDomain Result { get; set; }

	/// <summary>
/// ProcessVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessVoDomain : TopObject
{
	        /// <summary>
	        /// bizCategoryId
	        /// </summary>
	        [XmlElement("biz_category_id")]
	        public string BizCategoryId { get; set; }
	
	        /// <summary>
	        /// description
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// formContent
	        /// </summary>
	        [XmlElement("form_content")]
	        public string FormContent { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// processCode
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

    }
}
