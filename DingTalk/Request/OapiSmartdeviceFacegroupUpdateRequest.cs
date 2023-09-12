using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.facegroup.update
    /// </summary>
    public class OapiSmartdeviceFacegroupUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFacegroupUpdateResponse>
    {
        /// <summary>
        /// M2上的定制UI
        /// </summary>
        public string BgImgUrl { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 识别成功后的问候语
        /// </summary>
        public string GreetingMsg { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 识别组启用状态：1-已启用；2未启用；
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 识别组的标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.facegroup.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bg_img_url", this.BgImgUrl);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("greeting_msg", this.GreetingMsg);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("status", this.Status);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxLength("bg_img_url", this.BgImgUrl, 512);
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateMaxLength("biz_id", this.BizId, 23);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateMaxLength("greeting_msg", this.GreetingMsg, 16);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateMaxValue("status", this.Status, 2);
            RequestValidator.ValidateMinValue("status", this.Status, 1);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 32);
        }

        #endregion
    }
}
