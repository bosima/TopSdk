using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.face.recognition
    /// </summary>
    public class OapiAttendanceFaceRecognitionRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceFaceRecognitionResponse>
    {
        /// <summary>
        /// 钉钉mediaId
        /// </summary>
        public string MediaId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.face.recognition";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("media_id", this.MediaId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("media_id", this.MediaId);
        }

        #endregion
    }
}
