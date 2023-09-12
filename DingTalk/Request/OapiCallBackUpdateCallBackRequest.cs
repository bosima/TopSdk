using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.call_back.update_call_back
    /// </summary>
    public class OapiCallBackUpdateCallBackRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCallBackUpdateCallBackResponse>
    {
        /// <summary>
        /// 数据加密密钥。用于回调数据的加密，长度固定为43个字符，从a-z, A-Z, 0-9共62个字符中选取,您可以随机生成，ISV(服务提供商)推荐使用注册套件时填写的EncodingAESKey
        /// </summary>
        public string AesKey { get; set; }

        /// <summary>
        /// 需要监听的事件类型，有20种，“user_add_org”, “user_modify_org”, “user_leave_org”,“org_admin_add”, “org_admin_remove”, “org_dept_create”, “org_dept_modify”, “org_dept_remove”, “org_remove”, “chat_add_member”, “chat_remove_member”, “chat_quit”, “chat_update_owner”, “chat_update_title”, “chat_disband”, “chat_disband_microapp”, “check_in”,“bpms_task_change”,“bpms_instance_change”,,“label_user_change”,“label_conf_add”, “label_conf_modify”,“label_conf_del”,
        /// </summary>
        public List<string> CallBackTag { get; set; }

        /// <summary>
        /// 加解密需要用到的token，ISV(服务提供商)推荐使用注册套件时填写的token，普通企业可以随机填写
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 更新事件回调接口
        /// </summary>
        public string Url { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.call_back.update_call_back";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aes_key", this.AesKey);
            parameters.Add("call_back_tag", TopUtils.ObjectToJson(this.CallBackTag));
            parameters.Add("token", this.Token);
            parameters.Add("url", this.Url);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("call_back_tag", this.CallBackTag, 20);
        }

        #endregion
    }
}
