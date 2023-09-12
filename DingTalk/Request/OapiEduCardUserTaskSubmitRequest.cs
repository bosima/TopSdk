using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.card.user.task.submit
    /// </summary>
    public class OapiEduCardUserTaskSubmitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCardUserTaskSubmitResponse>
    {
        /// <summary>
        /// 参数
        /// </summary>
        public string Taskparam { get; set; }

        public OpenCardTaskSubmitParamDomain Taskparam_ { set { this.Taskparam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.card.user.task.submit";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("taskparam", this.Taskparam);
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
/// OpenCardTaskSubmitParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCardTaskSubmitParamDomain : TopObject
{
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("card_biz_id")]
	        public string CardBizId { get; set; }
	
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("card_bizcode")]
	        public string CardBizcode { get; set; }
	
	        /// <summary>
	        /// 卡片ID cardId
	        /// </summary>
	        [XmlElement("card_id")]
	        public Nullable<long> CardId { get; set; }
	
	        /// <summary>
	        /// 任务Code
	        /// </summary>
	        [XmlElement("card_task_code")]
	        public string CardTaskCode { get; set; }
	
	        /// <summary>
	        /// 当前人的任务ID
	        /// </summary>
	        [XmlElement("card_task_id")]
	        public Nullable<long> CardTaskId { get; set; }
	
	        /// <summary>
	        /// 打卡的内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 详情的URL
	        /// </summary>
	        [XmlElement("detail_url")]
	        public string DetailUrl { get; set; }
	
	        /// <summary>
	        /// 编辑的URL
	        /// </summary>
	        [XmlElement("edit_url")]
	        public string EditUrl { get; set; }
	
	        /// <summary>
	        /// 用户打卡传入的音视频类型
	        /// </summary>
	        [XmlElement("medias")]
	        public string Medias { get; set; }
	
	        /// <summary>
	        /// 计数
	        /// </summary>
	        [XmlElement("metering_number")]
	        public string MeteringNumber { get; set; }
	
	        /// <summary>
	        /// 当前是否为补卡
	        /// </summary>
	        [XmlElement("reissue_card")]
	        public Nullable<bool> ReissueCard { get; set; }
	
	        /// <summary>
	        /// 结果评定文案
	        /// </summary>
	        [XmlElement("result_evaluation")]
	        public string ResultEvaluation { get; set; }
	
	        /// <summary>
	        /// 内容来源,需申请
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 单位
	        /// </summary>
	        [XmlElement("unit_of_measurement")]
	        public string UnitOfMeasurement { get; set; }
	
	        /// <summary>
	        /// 当前人的staffId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
