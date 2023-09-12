using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripCostCenterEntitySetResponse.
    /// </summary>
    public class OapiAlitripBtripCostCenterEntitySetResponse : DingTalkResponse
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
        public OpenCostCenterSetEntityRsDomain Result { get; set; }

        /// <summary>
        /// 成本标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCostCenterSetEntityRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterSetEntityRsDomain : TopObject
{
	        /// <summary>
	        /// 增加的人员信息条数
	        /// </summary>
	        [XmlElement("add_num")]
	        public long AddNum { get; set; }
	
	        /// <summary>
	        /// 删除的人员信息条数
	        /// </summary>
	        [XmlElement("remove_num")]
	        public long RemoveNum { get; set; }
	
	        /// <summary>
	        /// 该成本中心下员工总数
	        /// </summary>
	        [XmlElement("selected_user_num")]
	        public long SelectedUserNum { get; set; }
}

    }
}
