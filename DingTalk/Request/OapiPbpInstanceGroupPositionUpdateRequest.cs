using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.group.position.update
    /// </summary>
    public class OapiPbpInstanceGroupPositionUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceGroupPositionUpdateResponse>
    {
        /// <summary>
        /// 同步参数
        /// </summary>
        public string SyncParam { get; set; }

        public PunchGroupSyncPositionParamDomain SyncParam_ { set { this.SyncParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.group.position.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sync_param", this.SyncParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("sync_param", this.SyncParam);
        }

	/// <summary>
/// PunchGroupPositionParamDomain Data Structure.
/// </summary>
[Serializable]

public class PunchGroupPositionParamDomain : TopObject
{
	        /// <summary>
	        /// 位置唯一标识
	        /// </summary>
	        [XmlElement("position_id")]
	        public string PositionId { get; set; }
	
	        /// <summary>
	        /// 位置名称
	        /// </summary>
	        [XmlElement("position_name")]
	        public string PositionName { get; set; }
	
	        /// <summary>
	        /// 位置类型，如101表示B1
	        /// </summary>
	        [XmlElement("position_type")]
	        public Nullable<long> PositionType { get; set; }
}

	/// <summary>
/// PunchGroupSyncPositionParamDomain Data Structure.
/// </summary>
[Serializable]

public class PunchGroupSyncPositionParamDomain : TopObject
{
	        /// <summary>
	        /// 新增位置列表
	        /// </summary>
	        [XmlArray("add_position_list")]
	        [XmlArrayItem("punch_group_position_param")]
	        public List<PunchGroupPositionParamDomain> AddPositionList { get; set; }
	
	        /// <summary>
	        /// 业务唯一标识
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 业务实例唯一标识
	        /// </summary>
	        [XmlElement("biz_inst_id")]
	        public string BizInstId { get; set; }
	
	        /// <summary>
	        /// 删除位置列表
	        /// </summary>
	        [XmlArray("delete_position_list")]
	        [XmlArrayItem("punch_group_position_param")]
	        public List<PunchGroupPositionParamDomain> DeletePositionList { get; set; }
	
	        /// <summary>
	        /// 打卡组唯一标识
	        /// </summary>
	        [XmlElement("punch_group_id")]
	        public string PunchGroupId { get; set; }
}

        #endregion
    }
}
