using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripFlightCitySuggestResponse.
    /// </summary>
    public class OapiAlitripBtripFlightCitySuggestResponse : DingTalkResponse
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
	        /// 三字码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 与搜索城市距离，单位千米，只在邻近机场推荐有值
	        /// </summary>
	        [XmlElement("distance")]
	        public long Distance { get; set; }
	
	        /// <summary>
	        /// 城市名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 邻近机场城市，只在邻近机场推荐有值
	        /// </summary>
	        [XmlElement("travel_name")]
	        public string TravelName { get; set; }
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
	
	        /// <summary>
	        /// 是否为邻近城市
	        /// </summary>
	        [XmlElement("nearby")]
	        public bool Nearby { get; set; }
}

    }
}
