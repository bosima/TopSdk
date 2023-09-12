using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.group.create
    /// </summary>
    public class OapiPbpInstanceGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceGroupCreateResponse>
    {
        /// <summary>
        /// 打卡组创建参数
        /// </summary>
        public string GroupParam { get; set; }

        public PunchGroupCreateParamDomain GroupParam_ { set { this.GroupParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.group.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_param", this.GroupParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_param", this.GroupParam);
        }

	/// <summary>
/// PunchGroupCreateParamDomain Data Structure.
/// </summary>
[Serializable]

public class PunchGroupCreateParamDomain : TopObject
{
	        /// <summary>
	        /// 业务唯一标识
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 业务实例id
	        /// </summary>
	        [XmlElement("biz_inst_id")]
	        public string BizInstId { get; set; }
}

        #endregion
    }
}
