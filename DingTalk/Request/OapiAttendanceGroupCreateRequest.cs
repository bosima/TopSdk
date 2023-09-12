using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.create
    /// </summary>
    public class OapiAttendanceGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupCreateResponse>
    {
        /// <summary>
        /// 考勤组
        /// </summary>
        public string Group { get; set; }

        public GroupDomain Group_ { set { this.Group = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group", this.Group);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group", this.Group);
        }

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
	        public Nullable<bool> EnableCameraCheck { get; set; }
	
	        /// <summary>
	        /// 是否开启美颜，默认false
	        /// </summary>
	        [XmlElement("enable_face_beauty")]
	        public Nullable<bool> EnableFaceBeauty { get; set; }
	
	        /// <summary>
	        /// 是否开启笑脸打卡(若开启笑脸则默认开启拍照打卡)，默认false
	        /// </summary>
	        [XmlElement("enable_face_check")]
	        public Nullable<bool> EnableFaceCheck { get; set; }
	
	        /// <summary>
	        /// 扩展字段，JSON格式
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 打卡范围，单位：米
	        /// </summary>
	        [XmlElement("location_offset")]
	        public Nullable<long> LocationOffset { get; set; }
	
	        /// <summary>
	        /// 考勤组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

        #endregion
    }
}
