using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.guardian.create
    /// </summary>
    public class OapiEduGuardianCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduGuardianCreateResponse>
    {
        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 钉钉企业管理员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 关系code；关系枚举如下：  F:爸爸  M：妈妈  GF:爷爷  GM:奶奶  GFA:外公  GMA:外婆  U:叔叔  A:阿姨  B：哥哥  S:姐姐  O:其他
        /// </summary>
        public string Relation { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        public string StuId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.guardian.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("operator", this.Operator);
            parameters.Add("relation", this.Relation);
            parameters.Add("stu_id", this.StuId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("operator", this.Operator);
            RequestValidator.ValidateRequired("relation", this.Relation);
            RequestValidator.ValidateRequired("stu_id", this.StuId);
        }

        #endregion
    }
}
