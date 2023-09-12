using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.conference.participant.sync
    /// </summary>
    public class OapiConferenceParticipantSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiConferenceParticipantSyncResponse>
    {
        /// <summary>
        /// 全量同步id，第一批上传时为空，后续批次需要带上
        /// </summary>
        public string BatchId { get; set; }

        /// <summary>
        /// 标识批次，从1递增
        /// </summary>
        public Nullable<long> BatchIndex { get; set; }

        /// <summary>
        /// 会务id
        /// </summary>
        public string ConferenceId { get; set; }

        /// <summary>
        /// 是否最后一批
        /// </summary>
        public Nullable<bool> IsFinished { get; set; }

        /// <summary>
        /// 参会人员id列表
        /// </summary>
        public string ParticipantUseridList { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.conference.participant.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("batch_id", this.BatchId);
            parameters.Add("batch_index", this.BatchIndex);
            parameters.Add("conference_id", this.ConferenceId);
            parameters.Add("is_finished", this.IsFinished);
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
            RequestValidator.ValidateRequired("batch_index", this.BatchIndex);
            RequestValidator.ValidateRequired("conference_id", this.ConferenceId);
            RequestValidator.ValidateRequired("is_finished", this.IsFinished);
            RequestValidator.ValidateRequired("participant_userid_list", this.ParticipantUseridList);
            RequestValidator.ValidateMaxListSize("participant_userid_list", this.ParticipantUseridList, 1000);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
