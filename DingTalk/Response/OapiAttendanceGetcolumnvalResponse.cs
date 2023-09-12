using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetcolumnvalResponse.
    /// </summary>
    public class OapiAttendanceGetcolumnvalResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ColumnValListForTopVoDomain Result { get; set; }

	/// <summary>
/// ColumnDayAndValDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnDayAndValDomain : TopObject
{
	        /// <summary>
	        /// 时间
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 列值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ColumnForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

	/// <summary>
/// ColumnValForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnValForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列值数据
	        /// </summary>
	        [XmlArray("column_vals")]
	        [XmlArrayItem("column_day_and_val")]
	        public List<ColumnDayAndValDomain> ColumnVals { get; set; }
	
	        /// <summary>
	        /// 列信息
	        /// </summary>
	        [XmlElement("column_vo")]
	        public ColumnForTopVoDomain ColumnVo { get; set; }
	
	        /// <summary>
	        /// 一些不需要计算得固定值，如出勤天数等
	        /// </summary>
	        [XmlElement("fixed_value")]
	        public string FixedValue { get; set; }
}

	/// <summary>
/// ColumnValListForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnValListForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列信息与列值数据
	        /// </summary>
	        [XmlArray("column_vals")]
	        [XmlArrayItem("column_val_for_top_vo")]
	        public List<ColumnValForTopVoDomain> ColumnVals { get; set; }
}

    }
}
