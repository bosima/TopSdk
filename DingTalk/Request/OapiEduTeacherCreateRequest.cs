using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.teacher.create
    /// </summary>
    public class OapiEduTeacherCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduTeacherCreateResponse>
    {
        /// <summary>
        /// 是否班主任；1:班主任；0:非班主任
        /// </summary>
        public Nullable<long> Adviser { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 老师id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.teacher.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adviser", this.Adviser);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("operator", this.Operator);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("adviser", this.Adviser);
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
