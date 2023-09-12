using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.modify
    /// </summary>
    public class OapiAttendanceGroupModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupModifyResponse>
    {
        /// <summary>
        /// 操作人id
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 考勤组信息
        /// </summary>
        public string TopGroup { get; set; }

        public TopGroupVoDomain TopGroup_ { set { this.TopGroup = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.modify";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("top_group", this.TopGroup);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateRequired("top_group", this.TopGroup);
        }

	/// <summary>
/// TopShiftVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopShiftVoDomain : TopObject
{
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
}

	/// <summary>
/// TopPositionVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopPositionVoDomain : TopObject
{
	        /// <summary>
	        /// 精度
	        /// </summary>
	        [XmlElement("accuracy")]
	        public string Accuracy { get; set; }
	
	        /// <summary>
	        /// 地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 经度
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ResourcepermissionmapDomain Data Structure.
/// </summary>
[Serializable]

public class ResourcepermissionmapDomain : TopObject
{
	        /// <summary>
	        /// 设置拍照打卡规则
	        /// </summary>
	        [XmlElement("camera_check")]
	        public string CameraCheck { get; set; }
	
	        /// <summary>
	        /// 设置打卡方式
	        /// </summary>
	        [XmlElement("check_position_type")]
	        public string CheckPositionType { get; set; }
	
	        /// <summary>
	        /// 设置考勤时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 设置参与考勤人员
	        /// </summary>
	        [XmlElement("group_member")]
	        public string GroupMember { get; set; }
	
	        /// <summary>
	        /// 设置考勤类型
	        /// </summary>
	        [XmlElement("group_type")]
	        public string GroupType { get; set; }
	
	        /// <summary>
	        /// 设置外勤打卡
	        /// </summary>
	        [XmlElement("out_side_check")]
	        public string OutSideCheck { get; set; }
	
	        /// <summary>
	        /// 设置加班规则
	        /// </summary>
	        [XmlElement("over_time_rule")]
	        public string OverTimeRule { get; set; }
	
	        /// <summary>
	        /// 员工排班
	        /// </summary>
	        [XmlElement("schedule")]
	        public string Schedule { get; set; }
}

	/// <summary>
/// TopGroupVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupVoDomain : TopObject
{
	        /// <summary>
	        /// 休息日打卡需审批(true表示必须审批)
	        /// </summary>
	        [XmlElement("disable_check_when_rest")]
	        public Nullable<bool> DisableCheckWhenRest { get; set; }
	
	        /// <summary>
	        /// 未排班时是否禁止员工打卡
	        /// </summary>
	        [XmlElement("disable_check_without_schedule")]
	        public Nullable<bool> DisableCheckWithoutSchedule { get; set; }
	
	        /// <summary>
	        /// 是否开启拍照打卡，已废弃
	        /// </summary>
	        [XmlElement("enable_camera_check")]
	        public Nullable<bool> EnableCameraCheck { get; set; }
	
	        /// <summary>
	        /// 未排班时允许员工选择班次打卡
	        /// </summary>
	        [XmlElement("enable_emp_select_class")]
	        public Nullable<bool> EnableEmpSelectClass { get; set; }
	
	        /// <summary>
	        /// 是否开启人脸检测，已废弃
	        /// </summary>
	        [XmlElement("enable_face_check")]
	        public Nullable<bool> EnableFaceCheck { get; set; }
	
	        /// <summary>
	        /// 是否可以外勤打卡
	        /// </summary>
	        [XmlElement("enable_outside_check")]
	        public Nullable<bool> EnableOutsideCheck { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// 考勤组子管理员userid列表
	        /// </summary>
	        [XmlArray("manager_list")]
	        [XmlArrayItem("string")]
	        public List<string> ManagerList { get; set; }
	
	        /// <summary>
	        /// 考勤组名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 考勤范围
	        /// </summary>
	        [XmlElement("offset")]
	        public Nullable<long> Offset { get; set; }
	
	        /// <summary>
	        /// 是否开启拍照打卡
	        /// </summary>
	        [XmlElement("open_camera_check")]
	        public Nullable<bool> OpenCameraCheck { get; set; }
	
	        /// <summary>
	        /// 是否开启人脸检测
	        /// </summary>
	        [XmlElement("open_face_check")]
	        public Nullable<bool> OpenFaceCheck { get; set; }
	
	        /// <summary>
	        /// 考勤组主管理员
	        /// </summary>
	        [XmlElement("owner")]
	        public string Owner { get; set; }
	
	        /// <summary>
	        /// 考勤地址
	        /// </summary>
	        [XmlArray("positions")]
	        [XmlArrayItem("top_position_vo")]
	        public List<TopPositionVoDomain> Positions { get; set; }
	
	        /// <summary>
	        /// 子管理员权限范围（w表示可管理，r表示可读）
	        /// </summary>
	        [XmlElement("resource_permission_map")]
	        public ResourcepermissionmapDomain ResourcePermissionMap { get; set; }
	
	        /// <summary>
	        /// 班次信息
	        /// </summary>
	        [XmlArray("shift_vo_list")]
	        [XmlArrayItem("top_shift_vo")]
	        public List<TopShiftVoDomain> ShiftVoList { get; set; }
	
	        /// <summary>
	        /// 休息日自动排休
	        /// </summary>
	        [XmlElement("skip_holidays")]
	        public Nullable<bool> SkipHolidays { get; set; }
	
	        /// <summary>
	        /// 周班次列表
	        /// </summary>
	        [XmlArray("workday_class_list")]
	        [XmlArrayItem("number")]
	        public List<string> WorkdayClassList { get; set; }
}

        #endregion
    }
}
