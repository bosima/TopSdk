using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasRelationGetResponse.
    /// </summary>
    public class OapiImpaasRelationGetResponse : DingTalkResponse
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
        [XmlArray("result")]
        [XmlArrayItem("relation_model")]
        public List<RelationModelDomain> Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// RelationModelDomain Data Structure.
/// </summary>
[Serializable]

public class RelationModelDomain : TopObject
{
	        /// <summary>
	        /// beginTime
	        /// </summary>
	        [XmlElement("begin_time")]
	        public long BeginTime { get; set; }
	
	        /// <summary>
	        /// dstImOpenid
	        /// </summary>
	        [XmlElement("dst_im_openid")]
	        public string DstImOpenid { get; set; }
	
	        /// <summary>
	        /// endTime
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// srcImOpenid
	        /// </summary>
	        [XmlElement("src_im_openid")]
	        public string SrcImOpenid { get; set; }
}

    }
}
