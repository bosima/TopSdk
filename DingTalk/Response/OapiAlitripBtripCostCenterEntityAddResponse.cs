using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripCostCenterEntityAddResponse.
    /// </summary>
    public class OapiAlitripBtripCostCenterEntityAddResponse : DingTalkResponse
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
        public OpenCostCenterAddEntityRsDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCostCenterAddEntityRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterAddEntityRsDomain : TopObject
{
	        /// <summary>
	        /// 增加的人员信息条数
	        /// </summary>
	        [XmlElement("add_num")]
	        public long AddNum { get; set; }
	
	        /// <summary>
	        /// 该成本中心下员工总数
	        /// </summary>
	        [XmlElement("selected_user_num")]
	        public long SelectedUserNum { get; set; }
}

    }
}
