using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.list
    /// </summary>
    public class OapiEduCourseListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseListResponse>
    {
        /// <summary>
        /// 按课程编码列表查询
        /// </summary>
        public string CourseCodes { get; set; }

        /// <summary>
        /// 表示分页游标，从0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 时间查询结束区间
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 按课程名称查询
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前操作人的用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 查询选项
        /// </summary>
        public string Option { get; set; }

        public QueryCourseOptionDomain Option_ { set { this.Option = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 参与方查询条件
        /// </summary>
        public string ParticipantCondition { get; set; }

        public QueryCourseParticipantConditionDomain ParticipantCondition_ { set { this.ParticipantCondition = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 查询的场景：当前有：manage(管理视角)，lecture(授课视角)
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// 表示分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 时间查询开始区间
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 课程状态值
        /// </summary>
        public string Statuses { get; set; }

        /// <summary>
        /// 按应用唯一标识列表查询
        /// </summary>
        public string SuiteKeys { get; set; }

        /// <summary>
        /// 授课老师查询条件
        /// </summary>
        public string TeacherConditions { get; set; }

        public List<QueryTeacherConditionDomain> TeacherConditions_ { set { this.TeacherConditions = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_codes", this.CourseCodes);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("name", this.Name);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("option", this.Option);
            parameters.Add("participant_condition", this.ParticipantCondition);
            parameters.Add("scene", this.Scene);
            parameters.Add("size", this.Size);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("statuses", this.Statuses);
            parameters.Add("suite_keys", this.SuiteKeys);
            parameters.Add("teacher_conditions", this.TeacherConditions);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("course_codes", this.CourseCodes, 100);
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateMinValue("cursor", this.Cursor, 0);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 100);
            RequestValidator.ValidateMinValue("size", this.Size, 1);
            RequestValidator.ValidateMaxListSize("statuses", this.Statuses, 5);
            RequestValidator.ValidateMaxListSize("suite_keys", this.SuiteKeys, 5);
            RequestValidator.ValidateObjectMaxListSize("teacher_conditions", this.TeacherConditions, 30);
        }

	/// <summary>
/// QueryCourseOptionDomain Data Structure.
/// </summary>
[Serializable]

public class QueryCourseOptionDomain : TopObject
{
	        /// <summary>
	        /// 是否连带查询课堂信息
	        /// </summary>
	        [XmlElement("b_fetch_classrooms")]
	        public Nullable<bool> BFetchClassrooms { get; set; }
}

	/// <summary>
/// QueryCourseParticipantConditionDomain Data Structure.
/// </summary>
[Serializable]

public class QueryCourseParticipantConditionDomain : TopObject
{
	        /// <summary>
	        /// 参与方角色选项
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
}

	/// <summary>
/// QueryTeacherConditionDomain Data Structure.
/// </summary>
[Serializable]

public class QueryTeacherConditionDomain : TopObject
{
	        /// <summary>
	        /// 授课老师组织CorpId
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 老师用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
