using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.create
    /// </summary>
    public class OapiEduClassCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassCreateResponse>
    {
        /// <summary>
        /// 班级
        /// </summary>
        public string OpenClass { get; set; }

        public OpenClassDomain OpenClass_ { set { this.OpenClass = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 年级id
        /// </summary>
        public Nullable<long> SuperId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_class", this.OpenClass);
            parameters.Add("operator", this.Operator);
            parameters.Add("super_id", this.SuperId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_class", this.OpenClass);
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("super_id", this.SuperId);
        }

	/// <summary>
/// OpenClassDomain Data Structure.
/// </summary>
[Serializable]

public class OpenClassDomain : TopObject
{
	        /// <summary>
	        /// 班级level
	        /// </summary>
	        [XmlElement("class_level")]
	        public Nullable<long> ClassLevel { get; set; }
	
	        /// <summary>
	        /// 班级名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 班级nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 是否只展现nick
	        /// </summary>
	        [XmlElement("only_use_nick")]
	        public string OnlyUseNick { get; set; }
}

        #endregion
    }
}
