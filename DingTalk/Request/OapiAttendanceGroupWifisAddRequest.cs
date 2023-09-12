using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.wifis.add
    /// </summary>
    public class OapiAttendanceGroupWifisAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupWifisAddResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// wifi列表
        /// </summary>
        public string WifiList { get; set; }

        public List<WifiDomain> WifiList_ { set { this.WifiList = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.wifis.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_key", this.GroupKey);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("wifi_list", this.WifiList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
            RequestValidator.ValidateRequired("wifi_list", this.WifiList);
            RequestValidator.ValidateObjectMaxListSize("wifi_list", this.WifiList, 100);
        }

	/// <summary>
/// WifiDomain Data Structure.
/// </summary>
[Serializable]

public class WifiDomain : TopObject
{
	        /// <summary>
	        /// 业务方wifiId
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("mac_addr")]
	        public string MacAddr { get; set; }
	
	        /// <summary>
	        /// mac名称
	        /// </summary>
	        [XmlElement("ssid")]
	        public string Ssid { get; set; }
}

        #endregion
    }
}
