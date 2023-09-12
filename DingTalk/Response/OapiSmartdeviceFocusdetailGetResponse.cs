using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFocusdetailGetResponse.
    /// </summary>
    public class OapiSmartdeviceFocusdetailGetResponse : DingTalkResponse
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
        /// 页数据结果
        /// </summary>
        [XmlElement("result")]
        public PageVODomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FocusDetailVODomain Data Structure.
/// </summary>
[Serializable]

public class FocusDetailVODomain : TopObject
{
	        /// <summary>
	        /// 投屏时间，单位毫秒
	        /// </summary>
	        [XmlElement("create_date")]
	        public string CreateDate { get; set; }
	
	        /// <summary>
	        /// 部门全称
	        /// </summary>
	        [XmlElement("dept_full_name")]
	        public string DeptFullName { get; set; }
	
	        /// <summary>
	        /// 投屏设备呢称
	        /// </summary>
	        [XmlElement("nick_name")]
	        public string NickName { get; set; }
	
	        /// <summary>
	        /// 会议室
	        /// </summary>
	        [XmlElement("room")]
	        public string Room { get; set; }
	
	        /// <summary>
	        /// 用户名
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
}

	/// <summary>
/// PageVODomain Data Structure.
/// </summary>
[Serializable]

public class PageVODomain : TopObject
{
	        /// <summary>
	        /// 是否有更多记录
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 投屏数据列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("focus_detail_v_o")]
	        public List<FocusDetailVODomain> List { get; set; }
	
	        /// <summary>
	        /// 下一个游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 下一游标
	        /// </summary>
	        [XmlElement("next_cursor_string")]
	        public string NextCursorString { get; set; }
}

    }
}
