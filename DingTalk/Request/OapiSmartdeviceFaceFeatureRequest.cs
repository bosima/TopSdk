using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.face.feature
    /// </summary>
    public class OapiSmartdeviceFaceFeatureRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFaceFeatureResponse>
    {
        /// <summary>
        /// 算法模型
        /// </summary>
        public Nullable<long> ModelType { get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.face.feature";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("model_type", this.ModelType);
            parameters.Add("model_version", this.ModelVersion);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("model_type", this.ModelType);
            RequestValidator.ValidateRequired("model_version", this.ModelVersion);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 20);
        }

        #endregion
    }
}
