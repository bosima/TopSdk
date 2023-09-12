using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.smartdevice.addface
    /// </summary>
    public class CorpSmartdeviceAddfaceRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpSmartdeviceAddfaceResponse>
    {
        /// <summary>
        /// 识别用户数据
        /// </summary>
        public string FaceVo { get; set; }

        public DidoFaceVODomain FaceVo_ { set { this.FaceVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.smartdevice.addface";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("face_vo", this.FaceVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("face_vo", this.FaceVo);
        }

	/// <summary>
/// DidoFaceVODomain Data Structure.
/// </summary>
[Serializable]

public class DidoFaceVODomain : TopObject
{
	        /// <summary>
	        /// 终端识别有效期截止时间 timestamp(毫秒)
	        /// </summary>
	        [XmlElement("end_date")]
	        public Nullable<long> EndDate { get; set; }
	
	        /// <summary>
	        /// 识别用照片id，安全考虑，获取成功后立即删除
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 终端识别有效期开始时间 timestamp(毫秒)
	        /// </summary>
	        [XmlElement("start_date")]
	        public Nullable<long> StartDate { get; set; }
	
	        /// <summary>
	        /// 用户类型，用于区别不同的识别问候语 如interview,friends,business,communication,training,inspection,other
	        /// </summary>
	        [XmlElement("user_type")]
	        public string UserType { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
