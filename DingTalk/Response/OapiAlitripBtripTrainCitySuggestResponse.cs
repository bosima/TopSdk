using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripTrainCitySuggestResponse.
    /// </summary>
    public class OapiAlitripBtripTrainCitySuggestResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SuggestRsDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CityVoDomain Data Structure.
/// </summary>
[Serializable]

public class CityVoDomain : TopObject
{
	        /// <summary>
	        /// 城市码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 城市名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// SuggestRsDomain Data Structure.
/// </summary>
[Serializable]

public class SuggestRsDomain : TopObject
{
	        /// <summary>
	        /// 城市列表
	        /// </summary>
	        [XmlArray("cities")]
	        [XmlArrayItem("city_vo")]
	        public List<CityVoDomain> Cities { get; set; }
}

    }
}
