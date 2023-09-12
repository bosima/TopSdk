using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.mcs.conference.create
    /// </summary>
    public class OapiMcsConferenceCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMcsConferenceCreateResponse>
    {
        /// <summary>
        /// 由MCS颁发给调用三方的使用凭证
        /// </summary>
        public string BizKey { get; set; }

        /// <summary>
        /// 是否推送通话记录
        /// </summary>
        public Nullable<bool> IsPushRecord { get; set; }

        /// <summary>
        /// 倾向发起地 目前支持 CN-HZ/CN-HK/CN-BJ
        /// </summary>
        public string PreferenceRegion { get; set; }

        /// <summary>
        /// 视频会议从创建之时起的最多保留时间
        /// </summary>
        public Nullable<long> RoomValidTime { get; set; }

        /// <summary>
        /// 视频会议标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.mcs.conference.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_key", this.BizKey);
            parameters.Add("is_push_record", this.IsPushRecord);
            parameters.Add("preference_region", this.PreferenceRegion);
            parameters.Add("room_valid_time", this.RoomValidTime);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_key", this.BizKey);
            RequestValidator.ValidateRequired("room_valid_time", this.RoomValidTime);
            RequestValidator.ValidateRequired("title", this.Title);
        }

        #endregion
    }
}
