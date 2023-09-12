using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.cspace.grant_custom_space
    /// </summary>
    public class OapiCspaceGrantCustomSpaceRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCspaceGrantCustomSpaceResponse>
    {
        /// <summary>
        /// ISV调用时传入，授权访问指定微应用的自定义空间
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 企业调用时传入，授权访问该domain的自定义空间
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 权限有效时间，有效范围为0~3600秒，超出此范围或不传默认为30秒
        /// </summary>
        public Nullable<long> Duration { get; set; }

        /// <summary>
        /// 授权访问的文件id列表，id之间用英文逗号隔开，如“fileId1,fileId2”
        /// </summary>
        public string Fileids { get; set; }

        /// <summary>
        /// 授权访问的路径，如授权访问所有文件传“/”，授权访问/doc文件夹传“/doc/” 需要utf-8 urlEncode
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 权限类型，目前支持上传和下载，上传请传add，下载请传download
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 企业用户userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.cspace.grant_custom_space";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("domain", this.Domain);
            parameters.Add("duration", this.Duration);
            parameters.Add("fileids", this.Fileids);
            parameters.Add("path", this.Path);
            parameters.Add("type", this.Type);
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

        #endregion
    }
}
