using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetleavetimebynamesResponse.
    /// </summary>
    public class OapiAttendanceGetleavetimebynamesResponse : DingTalkResponse
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
/// ColumnForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 别名
	        /// </summary>
	        [XmlElement("alias")]
	        public string Alias { get; set; }
	
	        /// <summary>
	        /// 表达式id
	        /// </summary>
	        [XmlElement("expression_id")]
	        public long ExpressionId { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 列id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 列状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 子类型
	        /// </summary>
	        [XmlElement("sub_type")]
	        public long SubType { get; set; }
	
	        /// <summary>
	        /// 列类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

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
/// ColumnValForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnValForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列值数据
	        /// </summary>
	        [XmlArray("columnvals")]
	        [XmlArrayItem("column_day_and_val")]
	        public List<ColumnDayAndValDomain> Columnvals { get; set; }
	
	        /// <summary>
	        /// 列信息
	        /// </summary>
	        [XmlElement("columnvo")]
	        public ColumnForTopVoDomain Columnvo { get; set; }
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
	        [XmlArray("columns")]
	        [XmlArrayItem("column_val_for_top_vo")]
	        public List<ColumnValForTopVoDomain> Columns { get; set; }
}

    }
}
