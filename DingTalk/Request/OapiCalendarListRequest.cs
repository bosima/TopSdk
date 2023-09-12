using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.calendar.list
    /// </summary>
    public class OapiCalendarListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCalendarListResponse>
    {
        /// <summary>
        /// 钉钉日历文件夹的对外id，默认是自己的默认文件夹
        /// </summary>
        public string CalendarFolderId { get; set; }

        /// <summary>
        /// 结果返回的最多数量，默认250，最多返回2500
        /// </summary>
        public Nullable<long> MaxResults { get; set; }

        /// <summary>
        /// 查询对应页，值有上一次请求返回的结果里对应nextPageToken
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// 是否需要展开循环日程
        /// </summary>
        public Nullable<bool> SingleEvents { get; set; }

        /// <summary>
        /// 查询时间上限
        /// </summary>
        public string TimeMax { get; set; }

        public DateTimeDomain TimeMax_ { set { this.TimeMax = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 查询时间下限
        /// </summary>
        public string TimeMin { get; set; }

        public DateTimeDomain TimeMin_ { set { this.TimeMin = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工ID
        /// </summary>
        public string UserId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.calendar.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("calendar_folder_id", this.CalendarFolderId);
            parameters.Add("max_results", this.MaxResults);
            parameters.Add("page_token", this.PageToken);
            parameters.Add("single_events", this.SingleEvents);
            parameters.Add("time_max", this.TimeMax);
            parameters.Add("time_min", this.TimeMin);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("user_id", this.UserId);
        }

	/// <summary>
/// DateTimeDomain Data Structure.
/// </summary>
[Serializable]

public class DateTimeDomain : TopObject
{
	        /// <summary>
	        /// 时间 'yyyy-MM-ddTHH:mm:ssZ',
	        /// </summary>
	        [XmlElement("date_time")]
	        public string DateTime_ { get; set; }
	
	        /// <summary>
	        /// 时区
	        /// </summary>
	        [XmlElement("time_zone")]
	        public string TimeZone { get; set; }
}

        #endregion
    }
}
