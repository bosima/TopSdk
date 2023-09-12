using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.update
    /// </summary>
    public class OapiWorkspaceUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceUpdateResponse>
    {
        /// <summary>
        /// 修改项目/圈子信息
        /// </summary>
        public string UpdateInfo { get; set; }

        public OpenUpdateWorkspaceDtoDomain UpdateInfo_ { set { this.UpdateInfo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("update_info", this.UpdateInfo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("update_info", this.UpdateInfo);
        }

	/// <summary>
/// OpenUpdateWorkspaceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUpdateWorkspaceDtoDomain : TopObject
{
	        /// <summary>
	        /// 非必填。描述，长度256字符以内
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 非必填。mediaId格式，参考https://ding-doc.dingtalk.com/doc#/serverapi2/bcmg0i
	        /// </summary>
	        [XmlElement("logo_media_id")]
	        public string LogoMediaId { get; set; }
	
	        /// <summary>
	        /// 非必填必填。组织名，长度3-50个字符以内，不允许中划线、下划线、逗号、空格
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 非必填。修改项目负责人，传新负责人在项目组织内的userId（注意不是归属组织的）
	        /// </summary>
	        [XmlElement("owner_userid")]
	        public string OwnerUserid { get; set; }
}

        #endregion
    }
}
