using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.hrm.employee.setuserworkdata
    /// </summary>
    public class CorpHrmEmployeeSetuserworkdataRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpHrmEmployeeSetuserworkdataResponse>
    {
        /// <summary>
        /// 员工信息对象，被操作人userid是必填
        /// </summary>
        public string HrmApiUserDataModel { get; set; }

        public HrmApiUserDataModelDomain HrmApiUserDataModel_ { set { this.HrmApiUserDataModel = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作人userid，必须是拥有被操作人操作权限的管理员userid
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.hrm.employee.setuserworkdata";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hrm_api_user_data_model", this.HrmApiUserDataModel);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("hrm_api_user_data_model", this.HrmApiUserDataModel);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

	/// <summary>
/// HrmApiUserDataModelDomain Data Structure.
/// </summary>
[Serializable]

public class HrmApiUserDataModelDomain : TopObject
{
	        /// <summary>
	        /// 数据项描述信息
	        /// </summary>
	        [XmlElement("data_desc")]
	        public string DataDesc { get; set; }
	
	        /// <summary>
	        /// 数据值,可以为数值或者字符串
	        /// </summary>
	        [XmlElement("data_value")]
	        public string DataValue { get; set; }
	
	        /// <summary>
	        /// 被操作人userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
