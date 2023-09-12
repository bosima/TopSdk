using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCallBackGetCallBackResponse.
    /// </summary>
    public class OapiCallBackGetCallBackResponse : DingTalkResponse
    {
        /// <summary>
        /// 数据加密密钥。用于回调数据的加密，长度固定为43个字符，从a-z, A-Z, 0-9共62个字符中选取,您可以随机生成，ISV(服务提供商)推荐使用注册套件时填写的EncodingAESKey
        /// </summary>
        [XmlElement("aes_key")]
        public string AesKey { get; set; }

        /// <summary>
        /// 需要监听的事件类型，有20种，“user_add_org”, “user_modify_org”, “user_leave_org”,“org_admin_add”, “org_admin_remove”, “org_dept_create”, “org_dept_modify”, “org_dept_remove”, “org_remove”, “chat_add_member”, “chat_remove_member”, “chat_quit”, “chat_update_owner”, “chat_update_title”, “chat_disband”, “chat_disband_microapp”, “check_in”,“bpms_task_change”,“bpms_instance_change”,,“label_user_change”,“label_conf_add”, “label_conf_modify”,“label_conf_del”,
        /// </summary>
        [XmlArray("call_back_tag")]
        [XmlArrayItem("string")]
        public List<string> CallBackTag { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 加解密需要用到的token，ISV(服务提供商)推荐使用注册套件时填写的token，普通企业可以随机填写
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }

        /// <summary>
        /// 接收事件回调的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

    }
}
