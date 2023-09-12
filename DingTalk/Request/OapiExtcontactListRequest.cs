using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.extcontact.list
    /// </summary>
    public class OapiExtcontactListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiExtcontactListResponse>
    {
        /// <summary>
        /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100。
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.extcontact.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMinValue("offset", this.Offset, 0);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
        }

        #endregion
    }
}
