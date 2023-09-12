using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdevicePrintdetailGetResponse.
    /// </summary>
    public class OapiSmartdevicePrintdetailGetResponse : DingTalkResponse
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
/// PrintDetailVODomain Data Structure.
/// </summary>
[Serializable]

public class PrintDetailVODomain : TopObject
{
	        /// <summary>
	        /// 部门扩展信息
	        /// </summary>
	        [XmlElement("dept_ext_info")]
	        public string DeptExtInfo { get; set; }
	
	        /// <summary>
	        /// 部门全称
	        /// </summary>
	        [XmlElement("dept_full_name")]
	        public string DeptFullName { get; set; }
	
	        /// <summary>
	        /// 一级部门名
	        /// </summary>
	        [XmlElement("dept_level1_name")]
	        public string DeptLevel1Name { get; set; }
	
	        /// <summary>
	        /// 二级部门名
	        /// </summary>
	        [XmlElement("dept_level2_name")]
	        public string DeptLevel2Name { get; set; }
	
	        /// <summary>
	        /// 三级部门名
	        /// </summary>
	        [XmlElement("dept_level3_name")]
	        public string DeptLevel3Name { get; set; }
	
	        /// <summary>
	        /// 打印来源编号，0-5： 0-其他  1-pc驱动  2-二维码   3-审批   4-钉盘  5-IM
	        /// </summary>
	        [XmlElement("origin")]
	        public string Origin { get; set; }
	
	        /// <summary>
	        /// 彩色或黑白打印类型.0黑白，1彩色
	        /// </summary>
	        [XmlElement("page_color_type")]
	        public long PageColorType { get; set; }
	
	        /// <summary>
	        /// 单双面类型，0是单面，1是双面
	        /// </summary>
	        [XmlElement("page_double_type")]
	        public long PageDoubleType { get; set; }
	
	        /// <summary>
	        /// 纸张大小类型 A3
	        /// </summary>
	        [XmlElement("page_size_type")]
	        public string PageSizeType { get; set; }
	
	        /// <summary>
	        /// 打印总页数
	        /// </summary>
	        [XmlElement("pages")]
	        public long Pages { get; set; }
	
	        /// <summary>
	        /// 打印时间戳，单位是毫秒
	        /// </summary>
	        [XmlElement("print_date")]
	        public string PrintDate { get; set; }
	
	        /// <summary>
	        /// 打印机名称
	        /// </summary>
	        [XmlElement("printer_nick")]
	        public string PrinterNick { get; set; }
	
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
	        /// 打印详情列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("print_detail_v_o")]
	        public List<PrintDetailVODomain> List { get; set; }
	
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
