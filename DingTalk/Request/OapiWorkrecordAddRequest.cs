using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workrecord.add
    /// </summary>
    public class OapiWorkrecordAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkrecordAddResponse>
    {
        /// <summary>
        /// 外部业务id，建议带上业务方来源字段，防止与其他业务方冲突
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 待办时间。Unix时间戳
        /// </summary>
        public Nullable<long> CreateTime { get; set; }

        /// <summary>
        /// 表单列表
        /// </summary>
        public string FormItemList { get; set; }

        public List<FormItemVoDomain> FormItemList_ { set { this.FormItemList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 发起人id
        /// </summary>
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// pc端跳转url，不传则使用url参数
        /// </summary>
        public string PcUrl { get; set; }

        /// <summary>
        /// 待办的pc打开方式。2表示在pc端打开，4表示在浏览器打开
        /// </summary>
        public Nullable<long> PcOpenType { get; set; }

        /// <summary>
        /// 待办来源名称
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 待办跳转url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workrecord.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("create_time", this.CreateTime);
            parameters.Add("formItemList", this.FormItemList);
            parameters.Add("originator_user_id", this.OriginatorUserId);
            parameters.Add("pcUrl", this.PcUrl);
            parameters.Add("pc_open_type", this.PcOpenType);
            parameters.Add("source_name", this.SourceName);
            parameters.Add("title", this.Title);
            parameters.Add("url", this.Url);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("create_time", this.CreateTime);
            RequestValidator.ValidateRequired("formItemList", this.FormItemList);
            RequestValidator.ValidateObjectMaxListSize("formItemList", this.FormItemList, 20);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateRequired("url", this.Url);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

	/// <summary>
/// FormItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormItemVoDomain : TopObject
{
	        /// <summary>
	        /// 内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
