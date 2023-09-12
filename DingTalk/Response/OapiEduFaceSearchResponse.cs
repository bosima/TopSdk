using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduFaceSearchResponse.
    /// </summary>
    public class OapiEduFaceSearchResponse : DingTalkResponse
    {
        /// <summary>
        /// 系统错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// response
        /// </summary>
        [XmlElement("result")]
        public TopSubmitFaceSearchResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FacesDomain Data Structure.
/// </summary>
[Serializable]

public class FacesDomain : TopObject
{
	        /// <summary>
	        /// 来自录入还是标记
	        /// </summary>
	        [XmlElement("face_type")]
	        public string FaceType { get; set; }
	
	        /// <summary>
	        /// 人脸相似度
	        /// </summary>
	        [XmlElement("score")]
	        public string Score { get; set; }
	
	        /// <summary>
	        /// 标签id
	        /// </summary>
	        [XmlElement("tag_id")]
	        public string TagId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// TopSubmitFaceSearchResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TopSubmitFaceSearchResponseDomain : TopObject
{
	        /// <summary>
	        /// 人脸列表
	        /// </summary>
	        [XmlArray("faces")]
	        [XmlArrayItem("faces")]
	        public List<FacesDomain> Faces { get; set; }
	
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
}

    }
}
