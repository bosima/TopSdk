using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;


namespace QimenCloud.Api.scene21d8pajl08.Response
{
    /// <summary>
    /// DingtalkOapiIsvLingjiuTestResponse.
    /// </summary>
    public class DingtalkOapiIsvLingjiuTestResponse : QimenCloudResponse
    {
        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

    }
}
