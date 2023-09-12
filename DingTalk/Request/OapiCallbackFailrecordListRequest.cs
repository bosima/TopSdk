using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.callback.failrecord.list
    /// </summary>
    public class OapiCallbackFailrecordListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCallbackFailrecordListResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string Req { get; set; }

        public ReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.callback.failrecord.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("req", this.Req);
        }

	/// <summary>
/// ReqDomain Data Structure.
/// </summary>
[Serializable]

public class ReqDomain : TopObject
{
	        /// <summary>
	        /// 开始时间(单位：秒)。空表示不限，左闭右开。PS：当前只保留了7天的记录
	        /// </summary>
	        [XmlElement("begin_time")]
	        public Nullable<long> BeginTime { get; set; }
	
	        /// <summary>
	        /// 此次查询成功后，是否立即将状态改为“已确认”。传空取默认值false
	        /// </summary>
	        [XmlElement("confirm")]
	        public Nullable<bool> Confirm { get; set; }
	
	        /// <summary>
	        /// 分页查询，上次查询结果中的最后一个id
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 结束时间(单位：秒)。空表示不限，左闭右开
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 分页大小，最大支持100
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 确认状态，0-已确认 1-未确认，不填表示不区分
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 回调事件类型
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
}

        #endregion
    }
}
