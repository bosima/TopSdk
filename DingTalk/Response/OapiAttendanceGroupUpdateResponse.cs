using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupUpdateResponse.
    /// </summary>
    public class OapiAttendanceGroupUpdateResponse : DingTalkResponse
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
        /// 考勤组
        /// </summary>
        [XmlElement("result")]
        public GroupDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GroupDomain Data Structure.
/// </summary>
[Serializable]

public class GroupDomain : TopObject
{
	        /// <summary>
	        /// 是否开启拍照打卡，默认false
	        /// </summary>
	        [XmlElement("enable_camera_check")]
	        public bool EnableCameraCheck { get; set; }
	
	        /// <summary>
	        /// 是否开启美颜，默认false
	        /// </summary>
	        [XmlElement("enable_face_beauty")]
	        public bool EnableFaceBeauty { get; set; }
	
	        /// <summary>
	        /// 是否开启笑脸打卡(若开启笑脸则默认开启拍照打卡)，默认false
	        /// </summary>
	        [XmlElement("enable_face_check")]
	        public bool EnableFaceCheck { get; set; }
	
	        /// <summary>
	        /// 扩展字段，JSON格式
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_key")]
	        public string GroupKey { get; set; }
	
	        /// <summary>
	        /// 打卡范围，单位：米
	        /// </summary>
	        [XmlElement("location_offset")]
	        public long LocationOffset { get; set; }
	
	        /// <summary>
	        /// 考勤组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
