using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.project.invite.data.query
    /// </summary>
    public class OapiProjectInviteDataQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProjectInviteDataQueryResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string InviteDataQuery { get; set; }

        public InviteDataQueryDomain InviteDataQuery_ { set { this.InviteDataQuery = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.project.invite.data.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("invite_data_query", this.InviteDataQuery);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("invite_data_query", this.InviteDataQuery);
        }

	/// <summary>
/// InviteDataQueryDomain Data Structure.
/// </summary>
[Serializable]

public class InviteDataQueryDomain : TopObject
{
	        /// <summary>
	        /// 数据游标，初始传0。后续传入返回参数中的next_cursor值
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 每次查询数据量，最大100
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 状态0:无效（包括过程数据），1:有效(默认)，不传表示查询全部
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
}

        #endregion
    }
}
