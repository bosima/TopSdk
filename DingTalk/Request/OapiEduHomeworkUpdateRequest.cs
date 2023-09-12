using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.update
    /// </summary>
    public class OapiEduHomeworkUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkUpdateResponse>
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        public Nullable<long> HwId { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 老师UserId
        /// </summary>
        public string TeacherUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("hw_id", this.HwId);
            parameters.Add("identifier", this.Identifier);
            parameters.Add("status", this.Status);
            parameters.Add("teacher_userid", this.TeacherUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("hw_id", this.HwId);
            RequestValidator.ValidateRequired("identifier", this.Identifier);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

        #endregion
    }
}
