using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.advanced.service.isbound
    /// </summary>
    public class OapiAttendanceAdvancedServiceIsboundRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceAdvancedServiceIsboundResponse>
    {
        /// <summary>
        /// 操作者userid
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        public string Param { get; set; }

        public IsBoundParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.advanced.service.isbound";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// IsBoundParamDomain Data Structure.
/// </summary>
[Serializable]

public class IsBoundParamDomain : TopObject
{
	        /// <summary>
	        /// 实体id列表
	        /// </summary>
	        [XmlArray("entity_ids")]
	        [XmlArrayItem("string")]
	        public List<string> EntityIds { get; set; }
	
	        /// <summary>
	        /// 实体类型，可取值user,group,corp
	        /// </summary>
	        [XmlElement("entity_type")]
	        public string EntityType { get; set; }
	
	        /// <summary>
	        /// 服务id
	        /// </summary>
	        [XmlElement("service_id")]
	        public Nullable<long> ServiceId { get; set; }
}

        #endregion
    }
}
