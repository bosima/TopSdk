using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavGroupGetResponse.
    /// </summary>
    public class OapiKacDatavGroupGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        [XmlElement("result")]
        public GroupStatisticalSummaryResponseDomain Result { get; set; }

	/// <summary>
/// GroupStatisticalSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GroupStatisticalSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 部门群数量
	        /// </summary>
	        [XmlElement("dept_group_cnt")]
	        public long DeptGroupCnt { get; set; }
	
	        /// <summary>
	        /// 内部群数量
	        /// </summary>
	        [XmlElement("inner_group_cnt")]
	        public long InnerGroupCnt { get; set; }
}

    }
}
