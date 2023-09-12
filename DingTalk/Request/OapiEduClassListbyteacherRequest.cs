using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.listbyteacher
    /// </summary>
    public class OapiEduClassListbyteacherRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassListbyteacherResponse>
    {
        /// <summary>
        /// 过滤入参
        /// </summary>
        public string FilterParam { get; set; }

        public OpenClassParamDomain FilterParam_ { set { this.FilterParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 是否跨组织查询
        /// </summary>
        public Nullable<bool> QueryFromAllOrgs { get; set; }

        /// <summary>
        /// 返回的扩展信息设置(不支持跨组织)
        /// </summary>
        public string RetExtFields { get; set; }

        public OpenEduSelectClassExtFieldsDomain RetExtFields_ { set { this.RetExtFields = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.listbyteacher";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("filter_param", this.FilterParam);
            parameters.Add("queryFromAllOrgs", this.QueryFromAllOrgs);
            parameters.Add("ret_ext_fields", this.RetExtFields);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OpenClassParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenClassParamDomain : TopObject
{
	        /// <summary>
	        /// 群类型
	        /// </summary>
	        [XmlElement("group_type")]
	        public string GroupType { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
}

	/// <summary>
/// OpenEduSelectClassExtFieldsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSelectClassExtFieldsDomain : TopObject
{
	        /// <summary>
	        /// 返回群信息
	        /// </summary>
	        [XmlElement("ret_conversation_list")]
	        public Nullable<bool> RetConversationList { get; set; }
}

        #endregion
    }
}
