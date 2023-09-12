using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.visitor.addvisitor
    /// </summary>
    public class OapiSmartdeviceVisitorAddvisitorRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceVisitorAddvisitorResponse>
    {
        /// <summary>
        /// 访客预约模型
        /// </summary>
        public string VisitorVo { get; set; }

        public DidoVisitorVoDomain VisitorVo_ { set { this.VisitorVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.visitor.addvisitor";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("visitor_vo", this.VisitorVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("visitor_vo", this.VisitorVo);
        }

	/// <summary>
/// DidoVisitorVoDomain Data Structure.
/// </summary>
[Serializable]

public class DidoVisitorVoDomain : TopObject
{
	        /// <summary>
	        /// 预约开始时间
	        /// </summary>
	        [XmlElement("appointed_endtime")]
	        public Nullable<long> AppointedEndtime { get; set; }
	
	        /// <summary>
	        /// 预约结束时间
	        /// </summary>
	        [XmlElement("appointed_starttime")]
	        public Nullable<long> AppointedStarttime { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("extra_info")]
	        public string ExtraInfo { get; set; }
	
	        /// <summary>
	        /// 可识别照片ID
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 访客手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 通知用户员工ID列表
	        /// </summary>
	        [XmlArray("notify_user_list")]
	        [XmlArrayItem("string")]
	        public List<string> NotifyUserList { get; set; }
	
	        /// <summary>
	        /// 识别开始时间
	        /// </summary>
	        [XmlElement("recognize_endtime")]
	        public Nullable<long> RecognizeEndtime { get; set; }
	
	        /// <summary>
	        /// 识别结束时间
	        /// </summary>
	        [XmlElement("recognize_starttime")]
	        public Nullable<long> RecognizeStarttime { get; set; }
	
	        /// <summary>
	        /// 访客姓名
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 来访目的
	        /// </summary>
	        [XmlElement("user_type")]
	        public string UserType { get; set; }
	
	        /// <summary>
	        /// 访客外部联系人userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
