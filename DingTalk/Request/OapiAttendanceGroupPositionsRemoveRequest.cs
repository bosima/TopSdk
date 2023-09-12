using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.positions.remove
    /// </summary>
    public class OapiAttendanceGroupPositionsRemoveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupPositionsRemoveResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 位置key列表
        /// </summary>
        public string PositionKeyList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.positions.remove";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_key", this.GroupKey);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("position_key_list", this.PositionKeyList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
            RequestValidator.ValidateRequired("position_key_list", this.PositionKeyList);
            RequestValidator.ValidateMaxListSize("position_key_list", this.PositionKeyList, 100);
        }

        #endregion
    }
}
