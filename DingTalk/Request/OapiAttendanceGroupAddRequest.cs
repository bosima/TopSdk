using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.add
    /// </summary>
    public class OapiAttendanceGroupAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupAddResponse>
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
            return "dingtalk.oapi.attendance.group.add";
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
	        /// corpId
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
/// TopMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopMemberVoDomain : TopObject
{
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

	/// <summary>
/// TopGroupManageRolePermissionVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupManageRolePermissionVoDomain : TopObject
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
/// TopWifiVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopWifiVoDomain : TopObject
{
	        /// <summary>
	        /// 企业corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("mac_addr")]
	        public string MacAddr { get; set; }
	
	        /// <summary>
	        /// wifi的ssid
	        /// </summary>
	        [XmlElement("ssid")]
	        public string Ssid { get; set; }
}

	/// <summary>
/// TopAtBleDeviceVODomain Data Structure.
/// </summary>
[Serializable]

public class TopAtBleDeviceVODomain : TopObject
{
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("device_id")]
	        public Nullable<long> DeviceId { get; set; }
}

	/// <summary>
/// TopGroupVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupVoDomain : TopObject
{
	        /// <summary>
	        /// 蓝牙打卡信息
	        /// </summary>
	        [XmlArray("ble_device_list")]
	        [XmlArrayItem("top_at_ble_device_v_o")]
	        public List<TopAtBleDeviceVODomain> BleDeviceList { get; set; }
	
	        /// <summary>
	        /// 打卡是否需要健康码
	        /// </summary>
	        [XmlElement("check_need_healthy_code")]
	        public Nullable<bool> CheckNeedHealthyCode { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 默认班次id（固定班制必填）
	        /// </summary>
	        [XmlElement("default_class_id")]
	        public Nullable<long> DefaultClassId { get; set; }
	
	        /// <summary>
	        /// 休息日打卡是否需审批。true：需要  false：不需要
	        /// </summary>
	        [XmlElement("disable_check_when_rest")]
	        public Nullable<bool> DisableCheckWhenRest { get; set; }
	
	        /// <summary>
	        /// 未排班时是否禁止员工打卡
	        /// </summary>
	        [XmlElement("disable_check_without_schedule")]
	        public Nullable<bool> DisableCheckWithoutSchedule { get; set; }
	
	        /// <summary>
	        /// 是否开启拍照打卡
	        /// </summary>
	        [XmlElement("enable_camera_check")]
	        public Nullable<bool> EnableCameraCheck { get; set; }
	
	        /// <summary>
	        /// 未排班时允许员工选择班次打卡
	        /// </summary>
	        [XmlElement("enable_emp_select_class")]
	        public Nullable<bool> EnableEmpSelectClass { get; set; }
	
	        /// <summary>
	        /// 是否开启人脸检测
	        /// </summary>
	        [XmlElement("enable_face_check")]
	        public Nullable<bool> EnableFaceCheck { get; set; }
	
	        /// <summary>
	        /// 是否第二天生效
	        /// </summary>
	        [XmlElement("enable_next_day")]
	        public Nullable<bool> EnableNextDay { get; set; }
	
	        /// <summary>
	        /// 是否开启外勤打卡必须拍照
	        /// </summary>
	        [XmlElement("enable_outside_camera_check")]
	        public Nullable<bool> EnableOutsideCameraCheck { get; set; }
	
	        /// <summary>
	        /// 是否可以外勤打卡
	        /// </summary>
	        [XmlElement("enable_outside_check")]
	        public Nullable<bool> EnableOutsideCheck { get; set; }
	
	        /// <summary>
	        /// 是否启用蓝牙定位
	        /// </summary>
	        [XmlElement("enable_position_ble")]
	        public Nullable<bool> EnablePositionBle { get; set; }
	
	        /// <summary>
	        /// 自由工时考勤组考勤开始时间与当天0点偏移分钟数（如：240表示4:00）
	        /// </summary>
	        [XmlElement("freecheck_day_start_min_offset")]
	        public Nullable<long> FreecheckDayStartMinOffset { get; set; }
	
	        /// <summary>
	        /// 自由工时考勤组工作日（1表示周一，0表示周日）
	        /// </summary>
	        [XmlArray("freecheck_work_days")]
	        [XmlArrayItem("number")]
	        public List<string> FreecheckWorkDays { get; set; }
	
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
	        /// 考勤组成员
	        /// </summary>
	        [XmlArray("members")]
	        [XmlArrayItem("top_member_vo")]
	        public List<TopMemberVoDomain> Members { get; set; }
	
	        /// <summary>
	        /// 是否有修改考勤组成员相关信息
	        /// </summary>
	        [XmlElement("modify_member")]
	        public Nullable<bool> ModifyMember { get; set; }
	
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
	        /// 考勤组owner
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
	        public TopGroupManageRolePermissionVoDomain ResourcePermissionMap { get; set; }
	
	        /// <summary>
	        /// 班次信息
	        /// </summary>
	        [XmlArray("shift_vo_list")]
	        [XmlArrayItem("top_shift_vo")]
	        public List<TopShiftVoDomain> ShiftVoList { get; set; }
	
	        /// <summary>
	        /// 是否跳过节假日
	        /// </summary>
	        [XmlElement("skip_holidays")]
	        public Nullable<bool> SkipHolidays { get; set; }
	
	        /// <summary>
	        /// 特殊日期配置
	        /// </summary>
	        [XmlElement("special_days")]
	        public string SpecialDays { get; set; }
	
	        /// <summary>
	        /// 考勤组类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 考勤wifi打卡
	        /// </summary>
	        [XmlArray("wifis")]
	        [XmlArrayItem("top_wifi_vo")]
	        public List<TopWifiVoDomain> Wifis { get; set; }
	
	        /// <summary>
	        /// 周班次列表（固定班制必填，0表示休息）
	        /// </summary>
	        [XmlArray("workday_class_list")]
	        [XmlArrayItem("number")]
	        public List<string> WorkdayClassList { get; set; }
}

        #endregion
    }
}
