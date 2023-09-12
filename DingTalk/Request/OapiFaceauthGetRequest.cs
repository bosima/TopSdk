using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.faceauth.get
    /// </summary>
    public class OapiFaceauthGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFaceauthGetResponse>
    {
        /// <summary>
        /// 业务方定义的id
        /// </summary>
        public string AppBizId { get; set; }

        /// <summary>
        /// 人脸扫描的授权码
        /// </summary>
        public string TmpAuthCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.faceauth.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_biz_id", this.AppBizId);
            parameters.Add("tmp_auth_code", this.TmpAuthCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("app_biz_id", this.AppBizId);
            RequestValidator.ValidateRequired("tmp_auth_code", this.TmpAuthCode);
        }

        #endregion
    }
}
