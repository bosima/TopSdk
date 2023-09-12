using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.blackboard.update
    /// </summary>
    public class OapiBlackboardUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBlackboardUpdateResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string UpdateRequest { get; set; }

        public OapiUpdateBlackboardVoDomain UpdateRequest_ { set { this.UpdateRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.blackboard.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("update_request", this.UpdateRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OapiUpdateBlackboardVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiUpdateBlackboardVoDomain : TopObject
{
	        /// <summary>
	        /// 公告作者
	        /// </summary>
	        [XmlElement("author")]
	        public string Author { get; set; }
	
	        /// <summary>
	        /// 公告id
	        /// </summary>
	        [XmlElement("blackboard_id")]
	        public string BlackboardId { get; set; }
	
	        /// <summary>
	        /// 公告分类id，可以通过https://oapi.dingtalk.com/blackboard/category/get获取有效值
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 公告内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 封面图,需要使用mediaId,可以通过https://oapi.dingtalk.com/media/upload上传图片获取mediaId
	        /// </summary>
	        [XmlElement("coverpic_mediaid")]
	        public string CoverpicMediaid { get; set; }
	
	        /// <summary>
	        /// 是否发送应用内钉提醒
	        /// </summary>
	        [XmlElement("ding")]
	        public Nullable<bool> Ding { get; set; }
	
	        /// <summary>
	        /// 修改后是否再次通知接收人
	        /// </summary>
	        [XmlElement("notify")]
	        public Nullable<bool> Notify { get; set; }
	
	        /// <summary>
	        /// 操作人userId(必须是公告管理员)
	        /// </summary>
	        [XmlElement("operation_userid")]
	        public string OperationUserid { get; set; }
	
	        /// <summary>
	        /// 公告标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
