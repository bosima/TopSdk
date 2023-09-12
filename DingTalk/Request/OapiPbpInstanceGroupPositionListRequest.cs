using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.group.position.list
    /// </summary>
    public class OapiPbpInstanceGroupPositionListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceGroupPositionListResponse>
    {
        /// <summary>
        /// 业务唯一标识
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 游标，用于分页查询
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 打卡组唯一标识，由创建打卡组接口返回
        /// </summary>
        public string PunchGroupId { get; set; }

        /// <summary>
        /// 分页请求数量
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.group.position.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("punch_group_id", this.PunchGroupId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("punch_group_id", this.PunchGroupId);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
