using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDepartmentListIdsResponse.
    /// </summary>
    public class OapiDepartmentListIdsResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// sub_dept_id_list
        /// </summary>
        [XmlArray("sub_dept_id_list")]
        [XmlArrayItem("number")]
        public List<long> SubDeptIdList { get; set; }

    }
}
