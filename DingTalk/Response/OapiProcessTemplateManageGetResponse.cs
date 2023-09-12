using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessTemplateManageGetResponse.
    /// </summary>
    public class OapiProcessTemplateManageGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 模版对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("process_simple_v_o")]
        public List<ProcessSimpleVODomain> Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ProcessSimpleVODomain Data Structure.
/// </summary>
[Serializable]

public class ProcessSimpleVODomain : TopObject
{
	        /// <summary>
	        /// 关联考勤类型 ，0: 无 ；1：补卡申请 ；2：请假。。。
	        /// </summary>
	        [XmlElement("attendance_type")]
	        public long AttendanceType { get; set; }
	
	        /// <summary>
	        /// 模版名
	        /// </summary>
	        [XmlElement("flow_title")]
	        public string FlowTitle { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 图标名
	        /// </summary>
	        [XmlElement("icon_name")]
	        public string IconName { get; set; }
	
	        /// <summary>
	        /// 图标地址
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 是否新模版
	        /// </summary>
	        [XmlElement("is_new_process")]
	        public bool IsNewProcess { get; set; }
	
	        /// <summary>
	        /// 模版code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

    }
}
