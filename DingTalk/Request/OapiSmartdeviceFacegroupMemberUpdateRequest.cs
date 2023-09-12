using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.facegroup.member.update
    /// </summary>
    public class OapiSmartdeviceFacegroupMemberUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceFacegroupMemberUpdateResponse>
    {
        /// <summary>
        /// 需新增的用户id列表
        /// </summary>
        public string AddUserIds { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 需移除的用户id列表
        /// </summary>
        public string DelUserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.facegroup.member.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_user_ids", this.AddUserIds);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("del_user_ids", this.DelUserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_user_ids", this.AddUserIds, 100);
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateMaxLength("biz_id", this.BizId, 23);
            RequestValidator.ValidateMaxListSize("del_user_ids", this.DelUserIds, 100);
        }

        #endregion
    }
}
