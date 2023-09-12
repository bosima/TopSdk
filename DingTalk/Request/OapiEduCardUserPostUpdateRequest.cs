using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.card.user.post.update
    /// </summary>
    public class OapiEduCardUserPostUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCardUserPostUpdateResponse>
    {
        /// <summary>
        /// 打卡动态修改入参
        /// </summary>
        public string UpdatePostParam { get; set; }

        public OpenUpdatePostParamDomain UpdatePostParam_ { set { this.UpdatePostParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.card.user.post.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("update_post_param", this.UpdatePostParam);
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
/// OpenUpdatePostParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUpdatePostParamDomain : TopObject
{
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("card_biz_code")]
	        public string CardBizCode { get; set; }
	
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("card_biz_id")]
	        public string CardBizId { get; set; }
	
	        /// <summary>
	        /// 卡片ID
	        /// </summary>
	        [XmlElement("card_id")]
	        public string CardId { get; set; }
	
	        /// <summary>
	        /// 提交的文本内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 详情的RUL
	        /// </summary>
	        [XmlElement("detail_url")]
	        public string DetailUrl { get; set; }
	
	        /// <summary>
	        /// 编辑的URL
	        /// </summary>
	        [XmlElement("edit_url")]
	        public string EditUrl { get; set; }
	
	        /// <summary>
	        /// 提交的多媒体信息
	        /// </summary>
	        [XmlElement("medias")]
	        public string Medias { get; set; }
	
	        /// <summary>
	        /// 打卡：计量数
	        /// </summary>
	        [XmlElement("metering_number")]
	        public string MeteringNumber { get; set; }
	
	        /// <summary>
	        /// 动态ID
	        /// </summary>
	        [XmlElement("post_id")]
	        public Nullable<long> PostId { get; set; }
	
	        /// <summary>
	        /// 打卡：补卡标示
	        /// </summary>
	        [XmlElement("reissue_card")]
	        public Nullable<bool> ReissueCard { get; set; }
	
	        /// <summary>
	        /// 打卡：展示名称
	        /// </summary>
	        [XmlElement("show_name")]
	        public string ShowName { get; set; }
	
	        /// <summary>
	        /// 内容来源
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// 打卡：单位
	        /// </summary>
	        [XmlElement("unit_of_measurement")]
	        public string UnitOfMeasurement { get; set; }
	
	        /// <summary>
	        /// 当前登录用户的staffId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
