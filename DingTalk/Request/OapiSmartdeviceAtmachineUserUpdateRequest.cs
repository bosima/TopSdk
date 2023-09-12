using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.atmachine.user.update
    /// </summary>
    public class OapiSmartdeviceAtmachineUserUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceAtmachineUserUpdateResponse>
    {
        /// <summary>
        /// 变更智能考勤机员工参数模型
        /// </summary>
        public string Param { get; set; }

        public MachineUsersUpdateRequestVoDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.atmachine.user.update";
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
/// MachineUsersUpdateRequestVoDomain Data Structure.
/// </summary>
[Serializable]

public class MachineUsersUpdateRequestVoDomain : TopObject
{
	        /// <summary>
	        /// 新增的员工id列表
	        /// </summary>
	        [XmlArray("add_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> AddUseridList { get; set; }
	
	        /// <summary>
	        /// 移除的员工id列表
	        /// </summary>
	        [XmlArray("del_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> DelUseridList { get; set; }
	
	        /// <summary>
	        /// 设备唯一标识id列表，字符串数组
	        /// </summary>
	        [XmlArray("deviceid_list")]
	        [XmlArrayItem("string")]
	        public List<string> DeviceidList { get; set; }
	
	        /// <summary>
	        /// 设备唯一标识id列表，Long数组
	        /// </summary>
	        [XmlArray("devid_list")]
	        [XmlArrayItem("number")]
	        public List<string> DevidList { get; set; }
}

        #endregion
    }
}
