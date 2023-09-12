using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.unionexport
    /// </summary>
    public class OapiSmartworkHrmEmployeeUnionexportRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeUnionexportResponse>
    {
        /// <summary>
        /// 导出请求对象
        /// </summary>
        public string Param { get; set; }

        public UnionExportParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.unionexport";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// UnionExportParamDomain Data Structure.
/// </summary>
[Serializable]

public class UnionExportParamDomain : TopObject
{
	        /// <summary>
	        /// 业务唯一id，用于唯一标记一次导出，该参数多次请求幂等处理
	        /// </summary>
	        [XmlElement("biz_unique_id")]
	        public string BizUniqueId { get; set; }
	
	        /// <summary>
	        /// 失效策略(0上传后10分钟失效，1下载一次后失效)
	        /// </summary>
	        [XmlElement("expire_strategy")]
	        public Nullable<long> ExpireStrategy { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// top上传文件后的mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 权限策略(0谁发起谁下载)
	        /// </summary>
	        [XmlElement("permission_strategy")]
	        public Nullable<long> PermissionStrategy { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
