using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.detaildata.list
    /// </summary>
    public class OapiEduCourseDetaildataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseDetaildataListResponse>
    {
        /// <summary>
        /// 数据类别编码
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// 课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 分页游标，从0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 数据因子编码数组，不填的话自动填充类别下全部的明细因子
        /// </summary>
        public string FactorCodes { get; set; }

        /// <summary>
        /// 当前操作人的用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 需要获取的用户CropId（必须和用户ID同时传值或同时为空）
        /// </summary>
        public string UserCropid { get; set; }

        /// <summary>
        /// 需要获取的用户ID
        /// </summary>
        public string UserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.detaildata.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_code", this.CategoryCode);
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("factor_codes", this.FactorCodes);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("size", this.Size);
            parameters.Add("user_cropid", this.UserCropid);
            parameters.Add("user_ids", this.UserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("category_code", this.CategoryCode);
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateMinValue("cursor", this.Cursor, 0);
            RequestValidator.ValidateMaxListSize("factor_codes", this.FactorCodes, 100);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 100);
        }

        #endregion
    }
}
