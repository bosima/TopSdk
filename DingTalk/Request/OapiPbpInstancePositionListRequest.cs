using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.position.list
    /// </summary>
    public class OapiPbpInstancePositionListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstancePositionListResponse>
    {
        /// <summary>
        /// 业务唯一标识，由系统分配
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 业务实例唯一标识，由创建示例接口返回
        /// </summary>
        public string BizInstId { get; set; }

        /// <summary>
        /// 游标，用于分页查询
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 查询数据量
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 位置类型，如100代表硬件B1设备
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.position.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("biz_inst_id", this.BizInstId);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("size", this.Size);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateRequired("biz_inst_id", this.BizInstId);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
