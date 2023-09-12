using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.dentry.auth
    /// </summary>
    public class OapiProcessDentryAuthRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessDentryAuthResponse>
    {
        /// <summary>
        /// 入参VO
        /// </summary>
        public string Request { get; set; }

        public GrantCspaceRequestV2Domain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.dentry.auth";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
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
/// FileInfoDomain Data Structure.
/// </summary>
[Serializable]

public class FileInfoDomain : TopObject
{
	        /// <summary>
	        /// 文件fileId
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 文件spaceId
	        /// </summary>
	        [XmlElement("space_id")]
	        public Nullable<long> SpaceId { get; set; }
}

	/// <summary>
/// GrantCspaceRequestV2Domain Data Structure.
/// </summary>
[Serializable]

public class GrantCspaceRequestV2Domain : TopObject
{
	        /// <summary>
	        /// 授权的钉盘文件信息
	        /// </summary>
	        [XmlArray("file_infos")]
	        [XmlArrayItem("file_info")]
	        public List<FileInfoDomain> FileInfos { get; set; }
	
	        /// <summary>
	        /// 授权的userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
