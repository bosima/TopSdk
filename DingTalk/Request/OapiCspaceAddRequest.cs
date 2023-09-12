using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.add
    /// </summary>
    public class OapiCspaceAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceAddResponse>
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 如果是微应用，code值为微应用免登授权码,如果是服务窗应用，code值为服务窗免登授权码。code为临时授权码，只能消费一次，下次请求需要重新获取新的code。
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 调用云盘选择控件后获取的用户钉盘空间ID
        /// </summary>
        public string FolderId { get; set; }

        /// <summary>
        /// 调用钉盘上传文件接口得到的mediaid, 需要utf-8 urlEncode
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 上传文件的名称，不能包含非法字符，需要utf-8 urlEncode
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 遇到同名文件是否覆盖，若不覆盖，则会自动重命名本次新增的文件，默认为false
        /// </summary>
        public Nullable<bool> Overwrite { get; set; }

        /// <summary>
        /// 调用云盘选择控件后获取的用户钉盘文件夹ID
        /// </summary>
        public string SpaceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("code", this.Code);
            parameters.Add("folder_id", this.FolderId);
            parameters.Add("media_id", this.MediaId);
            parameters.Add("name", this.Name);
            parameters.Add("overwrite", this.Overwrite);
            parameters.Add("space_id", this.SpaceId);
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
