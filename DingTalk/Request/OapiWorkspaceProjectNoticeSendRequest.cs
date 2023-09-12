using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.project.notice.send
    /// </summary>
    public class OapiWorkspaceProjectNoticeSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceProjectNoticeSendResponse>
    {
        /// <summary>
        /// 发送通知入参
        /// </summary>
        public string SendNoticeReq { get; set; }

        public OpenSendNoticeRequestDtoDomain SendNoticeReq_ { set { this.SendNoticeReq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.project.notice.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("send_notice_req", this.SendNoticeReq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("send_notice_req", this.SendNoticeReq);
        }

	/// <summary>
/// OpenSendNoticeRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSendNoticeRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// 圈子corpId+secret方式调用接口，没有agentId可以不传此时透出给用户是以圈子名字发通知。如果是isv方式的圈子应用，在圈子开通时会推送给isv agentID，必须传入agentId，会以圈子内应用的身份发通知
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 通知点击跳转的手机链接
	        /// </summary>
	        [XmlElement("mobile_url")]
	        public string MobileUrl { get; set; }
	
	        /// <summary>
	        /// 通知的下方按钮文案
	        /// </summary>
	        [XmlElement("msg_button")]
	        public string MsgButton { get; set; }
	
	        /// <summary>
	        /// 通知文本内容 1-512字符
	        /// </summary>
	        [XmlElement("msg_content")]
	        public string MsgContent { get; set; }
	
	        /// <summary>
	        /// 通知点击跳转的pc链接
	        /// </summary>
	        [XmlElement("pc_url")]
	        public string PcUrl { get; set; }
	
	        /// <summary>
	        /// 接收人在圈子组织内的userid
	        /// </summary>
	        [XmlArray("receiver_userids")]
	        [XmlArrayItem("string")]
	        public List<string> ReceiverUserids { get; set; }
	
	        /// <summary>
	        /// 是否在圈子入口展示数字红点+1，默认情况只是点进圈子在通知那一栏有数字红点，该值设为true后会在圈子入口也展示数字红点
	        /// </summary>
	        [XmlElement("show_red_point")]
	        public Nullable<bool> ShowRedPoint { get; set; }
	
	        /// <summary>
	        /// 防重复，如果2个请求传入同样的uuid，第二个请求会返回成功
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
