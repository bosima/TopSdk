using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace QimenCloud.Api.scenen95wrxpkif.Request
{
    /// <summary>
    /// TOP API: cilai.dingtalk.test
    /// </summary>
    public class CilaiDingtalkTestRequest : BaseQimenCloudRequest<QimenCloud.Api.scenen95wrxpkif.Response.CilaiDingtalkTestResponse>
    {
        #region IQimenCloudRequest Members

        public override string GetApiName()
        {
            return "cilai.dingtalk.test";
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
