using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecClothesGroupbyoperationCountResponse.
    /// </summary>
    public class OapiRhinoMosExecClothesGroupbyoperationCountResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("count_group_by_id_dto")]
        public List<CountGroupByIdDtoDomain> Model { get; set; }

	/// <summary>
/// CountGroupByIdDtoDomain Data Structure.
/// </summary>
[Serializable]

public class CountGroupByIdDtoDomain : TopObject
{
	        /// <summary>
	        /// 完成数量
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
	
	        /// <summary>
	        /// 工序uid
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

    }
}
