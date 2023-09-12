using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.track.entitycondition.list
    /// </summary>
    public class OapiRhinoMosExecTrackEntityconditionListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecTrackEntityconditionListResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public ListTrackRecordWithTrackIdsReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.track.entitycondition.list";
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
/// PageDomain Data Structure.
/// </summary>
[Serializable]

public class PageDomain : TopObject
{
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 起始位置
	        /// </summary>
	        [XmlElement("start")]
	        public Nullable<long> Start { get; set; }
}

	/// <summary>
/// ListTrackRecordWithTrackIdsReqDomain Data Structure.
/// </summary>
[Serializable]

public class ListTrackRecordWithTrackIdsReqDomain : TopObject
{
	        /// <summary>
	        /// 实体ID列表
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("number")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 实体类型
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 分页
	        /// </summary>
	        [XmlElement("page")]
	        public PageDomain Page { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 追踪类型
	        /// </summary>
	        [XmlArray("track_types")]
	        [XmlArrayItem("string")]
	        public List<string> TrackTypes { get; set; }
	
	        /// <summary>
	        /// 预留参数
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
