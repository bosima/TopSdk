using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.conference.participant.delete
    /// </summary>
    public class OapiConferenceParticipantDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiConferenceParticipantDeleteResponse>
    {
        /// <summary>
        /// 会务id
        /// </summary>
        public string ConferenceId { get; set; }

        /// <summary>
        /// 参会人员列表
        /// </summary>
        public string ParticipantUseridList { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.conference.participant.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conference_id", this.ConferenceId);
            parameters.Add("participant_userid_list", this.ParticipantUseridList);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("conference_id", this.ConferenceId);
            RequestValidator.ValidateRequired("participant_userid_list", this.ParticipantUseridList);
            RequestValidator.ValidateMaxListSize("participant_userid_list", this.ParticipantUseridList, 1000);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
