using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFacegroupGetResponse.
    /// </summary>
    public class OapiSmartdeviceFacegroupGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代号
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement("result")]
        public FaceGroupDtoDomain Result { get; set; }

        /// <summary>
        /// API调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FaceGroupDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FaceGroupDtoDomain : TopObject
{
	        /// <summary>
	        /// M2上的定制UI
	        /// </summary>
	        [XmlElement("bg_img_url")]
	        public string BgImgUrl { get; set; }
	
	        /// <summary>
	        /// 业务id
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// 识别成功后的问候语
	        /// </summary>
	        [XmlElement("greeting_msg")]
	        public string GreetingMsg { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 识别组启用状态：1-已启用；2未启用；
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 识别组的标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
