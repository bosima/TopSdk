using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.studentinfo.get
    /// </summary>
    public class OapiEduClassStudentinfoGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassStudentinfoGetResponse>
    {
        /// <summary>
        /// isv应用id
        /// </summary>
        public Nullable<long> AppId { get; set; }

        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.studentinfo.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_id", this.AppId);
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
