using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.positions.add
    /// </summary>
    public class OapiAttendanceGroupPositionsAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupPositionsAddResponse>
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
        /// postion列表
        /// </summary>
        public string PositionList { get; set; }

        public List<PositionDomain> PositionList_ { set { this.PositionList = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.positions.add";
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
            parameters.Add("position_list", this.PositionList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_key", this.GroupKey);
            RequestValidator.ValidateRequired("position_list", this.PositionList);
            RequestValidator.ValidateObjectMaxListSize("position_list", this.PositionList, 100);
        }

	/// <summary>
/// PositionDomain Data Structure.
/// </summary>
[Serializable]

public class PositionDomain : TopObject
{
	        /// <summary>
	        /// 地址描述
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 业务方positionId
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// 纬度(支持6位小数)
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 经度(支持6位小数)
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 打卡位置允许的偏移量
	        /// </summary>
	        [XmlElement("offset")]
	        public Nullable<long> Offset { get; set; }
}

        #endregion
    }
}
