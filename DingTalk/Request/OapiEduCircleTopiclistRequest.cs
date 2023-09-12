using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.circle.topiclist
    /// </summary>
    public class OapiEduCircleTopiclistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCircleTopiclistResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.circle.topiclist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("class_id", this.ClassId);
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
