using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCertGetResponse.
    /// </summary>
    public class OapiEduCertGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果值
        /// </summary>
        [XmlElement("result")]
        public OpenQueryCertResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CertdataDomain Data Structure.
/// </summary>
[Serializable]

public class CertdataDomain : TopObject
{
	        /// <summary>
	        /// 当前认证考试是否可以参加。true：可以；false：敬请期待；
	        /// </summary>
	        [XmlElement("can_cert")]
	        public bool CanCert { get; set; }
	
	        /// <summary>
	        /// 认证等级。0:没有认证；1:初级；2:中级；3:高级；
	        /// </summary>
	        [XmlElement("cert_level")]
	        public long CertLevel { get; set; }
	
	        /// <summary>
	        /// 当前等级认证状态。0:未获取；1:认证中；2:证书制作中；3:已获取
	        /// </summary>
	        [XmlElement("cert_status")]
	        public long CertStatus { get; set; }
}

	/// <summary>
/// OpenPracticalTaskDataDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPracticalTaskDataDomain : TopObject
{
	        /// <summary>
	        /// true表示完成，false表示未完成
	        /// </summary>
	        [XmlElement("finish")]
	        public bool Finish { get; set; }
	
	        /// <summary>
	        /// 实操任务code，sendCard表示发布打卡，sendImMsg表示发布消息
	        /// </summary>
	        [XmlElement("task_code")]
	        public string TaskCode { get; set; }
}

	/// <summary>
/// OpenQueryCertResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenQueryCertResponseDomain : TopObject
{
	        /// <summary>
	        /// 认证明细
	        /// </summary>
	        [XmlArray("cert_datas")]
	        [XmlArrayItem("certdata")]
	        public List<CertdataDomain> CertDatas { get; set; }
	
	        /// <summary>
	        /// 当前用户最高认证等级。0:没有认证；1:初级；2:中级；3:高级；
	        /// </summary>
	        [XmlElement("current_cert_level")]
	        public long CurrentCertLevel { get; set; }
	
	        /// <summary>
	        /// 实操任务完成信息
	        /// </summary>
	        [XmlArray("practical_task_data")]
	        [XmlArrayItem("open_practical_task_data")]
	        public List<OpenPracticalTaskDataDomain> PracticalTaskData { get; set; }
}

    }
}
