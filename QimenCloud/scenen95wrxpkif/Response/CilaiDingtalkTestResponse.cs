using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;


namespace QimenCloud.Api.scenen95wrxpkif.Response
{
    /// <summary>
    /// CilaiDingtalkTestResponse.
    /// </summary>
    public class CilaiDingtalkTestResponse : QimenCloudResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public string Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
