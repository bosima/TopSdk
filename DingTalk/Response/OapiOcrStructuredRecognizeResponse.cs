using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiOcrStructuredRecognizeResponse.
    /// </summary>
    public class OapiOcrStructuredRecognizeResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public OcrStructuredResultDomain Result { get; set; }

	/// <summary>
/// OcrStructuredResultDomain Data Structure.
/// </summary>
[Serializable]

public class OcrStructuredResultDomain : TopObject
{
	        /// <summary>
	        /// 旋转度
	        /// </summary>
	        [XmlElement("angle")]
	        public long Angle { get; set; }
	
	        /// <summary>
	        /// 图片识别内容json字符串，不同的类型有不同的字段，例如身份证{"姓名":"王xx","性别":"男","民族":"汉","出生日期":"1986年1月9日","住址":"四川省攀枝xxxx","身份证号码":"5101241988xxxxx"}
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// 旋转后图片高度
	        /// </summary>
	        [XmlElement("height")]
	        public long Height { get; set; }
	
	        /// <summary>
	        /// 原始图片高度
	        /// </summary>
	        [XmlElement("original_height")]
	        public long OriginalHeight { get; set; }
	
	        /// <summary>
	        /// 原始图片宽度
	        /// </summary>
	        [XmlElement("original_width")]
	        public long OriginalWidth { get; set; }
	
	        /// <summary>
	        /// 旋转后图片宽度
	        /// </summary>
	        [XmlElement("width")]
	        public long Width { get; set; }
}

    }
}
