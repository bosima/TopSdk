using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.call.removeuserlist
    /// </summary>
    public class OapiCallRemoveuserlistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCallRemoveuserlistResponse>
    {
        /// <summary>
        /// 要删除的员工userid列表
        /// </summary>
        public string StaffIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.call.removeuserlist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("staff_id_list", this.StaffIdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("staff_id_list", this.StaffIdList);
            RequestValidator.ValidateMaxListSize("staff_id_list", this.StaffIdList, 20);
        }

        #endregion
    }
}
