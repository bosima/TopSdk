using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceAtmachineGetByDeptidResponse.
    /// </summary>
    public class OapiSmartdeviceAtmachineGetByDeptidResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务调用结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务调用结果码描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 查询智能考勤机列表结果模型
        /// </summary>
        [XmlElement("result")]
        public MachineInfoResultVoDomain Result { get; set; }

	/// <summary>
/// MachineVoDomain Data Structure.
/// </summary>
[Serializable]

public class MachineVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤机名称
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 考勤机唯一标识id，字符串类型
	        /// </summary>
	        [XmlElement("deviceid")]
	        public string Deviceid { get; set; }
	
	        /// <summary>
	        /// 考勤机唯一标识id，Long类型
	        /// </summary>
	        [XmlElement("devid")]
	        public long Devid { get; set; }
	
	        /// <summary>
	        /// 考勤机类型名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
}

	/// <summary>
/// MachineInfoResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class MachineInfoResultVoDomain : TopObject
{
	        /// <summary>
	        /// 分页查询中，后页是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 考勤机列表
	        /// </summary>
	        [XmlArray("machine_list")]
	        [XmlArrayItem("machine_vo")]
	        public List<MachineVoDomain> MachineList { get; set; }
}

    }
}
