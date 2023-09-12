using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.health.stepinfo.list
    /// </summary>
    public class CorpHealthStepinfoListRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpHealthStepinfoListResponse>
    {
        /// <summary>
        /// 可以传入用户userid或者部门id
        /// </summary>
        public string ObjectId { get; set; }

        /// <summary>
        /// 时间列表，注意时间格式是YYYYMMDD
        /// </summary>
        public string StatDates { get; set; }

        /// <summary>
        /// 0表示取用户步数，1表示取部门步数
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.health.stepinfo.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("object_id", this.ObjectId);
            parameters.Add("stat_dates", this.StatDates);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("object_id", this.ObjectId);
            RequestValidator.ValidateRequired("stat_dates", this.StatDates);
            RequestValidator.ValidateMaxListSize("stat_dates", this.StatDates, 31);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
