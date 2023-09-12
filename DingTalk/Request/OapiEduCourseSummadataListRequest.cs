using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.summadata.list
    /// </summary>
    public class OapiEduCourseSummadataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseSummadataListResponse>
    {
        /// <summary>
        /// 数据类别编码数组
        /// </summary>
        public string CategoryCodes { get; set; }

        /// <summary>
        /// 课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 分页游标，从0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 当前操作人的用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.summadata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_codes", this.CategoryCodes);
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("category_codes", this.CategoryCodes);
            RequestValidator.ValidateMaxListSize("category_codes", this.CategoryCodes, 100);
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateMinValue("cursor", this.Cursor, 0);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
        }

        #endregion
    }
}
