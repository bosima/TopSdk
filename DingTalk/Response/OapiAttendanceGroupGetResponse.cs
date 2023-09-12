using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupGetResponse.
    /// </summary>
    public class OapiAttendanceGroupGetResponse : DingTalkResponse
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
	        /// 外勤打卡是否需要审批，默认false
	        /// </summary>
	        [XmlElement("enable_outside_apply")]
	        public bool EnableOutsideApply { get; set; }
	
	        /// <summary>
	        /// 外勤打卡需拍照备注，默认false
	        /// </summary>
	        [XmlElement("enable_outside_camera_check")]
	        public bool EnableOutsideCameraCheck { get; set; }
	
	        /// <summary>
	        /// 是否允许外勤打卡，默认false
	        /// </summary>
	        [XmlElement("enable_outside_check")]
	        public bool EnableOutsideCheck { get; set; }
	
	        /// <summary>
	        /// 外勤打卡需填写备注，默认false
	        /// </summary>
	        [XmlElement("enable_outside_remark")]
	        public bool EnableOutsideRemark { get; set; }
	
	        /// <summary>
	        /// 允许外勤卡更新内勤卡，默认false
	        /// </summary>
	        [XmlElement("enable_outside_update_normal_check")]
	        public bool EnableOutsideUpdateNormalCheck { get; set; }
	
	        /// <summary>
	        /// 允许地点微调距离，默认false
	        /// </summary>
	        [XmlElement("enable_trim_distance")]
	        public bool EnableTrimDistance { get; set; }
	
	        /// <summary>
	        /// 扩展字段，JSON格式
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 禁止员工隐藏详细地址，默认true
	        /// </summary>
	        [XmlElement("forbid_hide_outside_address")]
	        public bool ForbidHideOutsideAddress { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_key")]
	        public string GroupKey { get; set; }
	
	        /// <summary>
	        /// 打卡范围，单位：米(以考勤组下的地点列表的offset为准)
	        /// </summary>
	        [XmlElement("location_offset")]
	        public long LocationOffset { get; set; }
	
	        /// <summary>
	        /// 考勤组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// -1：关闭，0：先审批，再打卡，1：先打卡，再审批
	        /// </summary>
	        [XmlElement("outside_check_approve_mode")]
	        public long OutsideCheckApproveMode { get; set; }
	
	        /// <summary>
	        /// 地点微调范围，单位：米
	        /// </summary>
	        [XmlElement("trim_distance")]
	        public long TrimDistance { get; set; }
}

    }
}
