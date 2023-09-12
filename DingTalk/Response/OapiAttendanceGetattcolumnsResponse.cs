using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetattcolumnsResponse.
    /// </summary>
    public class OapiAttendanceGetattcolumnsResponse : DingTalkResponse
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
        public AttColumnsForTopVoDomain Result { get; set; }

	/// <summary>
/// ColumnForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ColumnForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列别名
	        /// </summary>
	        [XmlElement("alias")]
	        public string Alias { get; set; }
	
	        /// <summary>
	        /// 列表达式id
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
	        /// 列名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 列的状态
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
/// AttColumnsForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AttColumnsForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 列信息
	        /// </summary>
	        [XmlArray("columns")]
	        [XmlArrayItem("column_for_top_vo")]
	        public List<ColumnForTopVoDomain> Columns { get; set; }
}

    }
}
