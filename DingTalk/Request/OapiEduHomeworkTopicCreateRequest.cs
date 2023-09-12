using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.topic.create
    /// </summary>
    public class OapiEduHomeworkTopicCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkTopicCreateResponse>
    {
        /// <summary>
        /// 题目列表
        /// </summary>
        public string TopicItems { get; set; }

        public List<SyncTopicItemDomain> TopicItems_ { set { this.TopicItems = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.topic.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("topic_items", this.TopicItems);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("topic_items", this.TopicItems, 20);
        }

	/// <summary>
/// SyncTopicItemDomain Data Structure.
/// </summary>
[Serializable]

public class SyncTopicItemDomain : TopObject
{
	        /// <summary>
	        /// 题目内容扩展
	        /// </summary>
	        [XmlElement("addition")]
	        public string Addition { get; set; }
	
	        /// <summary>
	        /// 解析
	        /// </summary>
	        [XmlElement("analysis")]
	        public string Analysis { get; set; }
	
	        /// <summary>
	        /// 答案
	        /// </summary>
	        [XmlElement("answer")]
	        public string Answer { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 业务编码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 知识点
	        /// </summary>
	        [XmlElement("point")]
	        public string Point { get; set; }
	
	        /// <summary>
	        /// 题目内容
	        /// </summary>
	        [XmlElement("question_content")]
	        public string QuestionContent { get; set; }
	
	        /// <summary>
	        /// 题目ID
	        /// </summary>
	        [XmlElement("question_id")]
	        public string QuestionId { get; set; }
	
	        /// <summary>
	        /// 题目类型
	        /// </summary>
	        [XmlElement("question_type")]
	        public string QuestionType { get; set; }
	
	        /// <summary>
	        /// 学科编码
	        /// </summary>
	        [XmlElement("subject_code")]
	        public string SubjectCode { get; set; }
}

        #endregion
    }
}
