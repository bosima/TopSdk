using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.atmachine.get_by_userid
    /// </summary>
    public class OapiSmartdeviceAtmachineGetByUseridRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceAtmachineGetByUseridResponse>
    {
        /// <summary>
        /// 查询智能考勤机列表参数模型
        /// </summary>
        public string Param { get; set; }

        public UserMachineInfoRequestVoDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.atmachine.get_by_userid";
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
        }

	/// <summary>
/// UserMachineInfoRequestVoDomain Data Structure.
/// </summary>
[Serializable]

public class UserMachineInfoRequestVoDomain : TopObject
{
	        /// <summary>
	        /// 偏移值
	        /// </summary>
	        [XmlElement("offset")]
	        public Nullable<long> Offset { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
