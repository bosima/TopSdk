using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.relation.remark.modify
    /// </summary>
    public class OapiRelationRemarkModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRelationRemarkModifyResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Markees { get; set; }

        public List<RemarkModelDomain> Markees_ { set { this.Markees = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 修改者的userid
        /// </summary>
        public string Markers { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.relation.remark.modify";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("markees", this.Markees);
            parameters.Add("markers", this.Markers);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("markees", this.Markees);
            RequestValidator.ValidateObjectMaxListSize("markees", this.Markees, 100);
            RequestValidator.ValidateRequired("markers", this.Markers);
            RequestValidator.ValidateMaxListSize("markers", this.Markers, 100);
        }

	/// <summary>
/// RemarkModelDomain Data Structure.
/// </summary>
[Serializable]

public class RemarkModelDomain : TopObject
{
	        /// <summary>
	        /// 被修改的备注名
	        /// </summary>
	        [XmlElement("remark_name")]
	        public string RemarkName { get; set; }
	
	        /// <summary>
	        /// 被修改的userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
