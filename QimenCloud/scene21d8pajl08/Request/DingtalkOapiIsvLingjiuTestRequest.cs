using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace QimenCloud.Api.scene21d8pajl08.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.isv.lingjiu.test
    /// </summary>
    public class DingtalkOapiIsvLingjiuTestRequest : BaseQimenCloudRequest<QimenCloud.Api.scene21d8pajl08.Response.DingtalkOapiIsvLingjiuTestResponse>
    {
        #region IQimenCloudRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.isv.lingjiu.test";
        }
        
        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
