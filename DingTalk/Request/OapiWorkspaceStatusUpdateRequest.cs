using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.status.update
    /// </summary>
    public class OapiWorkspaceStatusUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceStatusUpdateResponse>
    {
        /// <summary>
        /// 更新状态
        /// </summary>
        public string UpdateStatus { get; set; }

        public OpenWorkspaceUpdateStatusDtoDomain UpdateStatus_ { set { this.UpdateStatus = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.status.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("update_status", this.UpdateStatus);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("update_status", this.UpdateStatus);
        }

	/// <summary>
/// OpenWorkspaceUpdateStatusDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenWorkspaceUpdateStatusDtoDomain : TopObject
{
	        /// <summary>
	        /// 对于项目有如下状态： WORKING进行中 DISBANDED解散 CLOSE归档 RECYCLE回收站状态 新建项目后状态是WORKING，WORKING/CLOSE/RECYCLE回收站状态可以切换，但是一旦成为DISBANDED则说明项目已销毁无法变更状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

        #endregion
    }
}
