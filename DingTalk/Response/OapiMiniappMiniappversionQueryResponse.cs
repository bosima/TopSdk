using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappMiniappversionQueryResponse.
    /// </summary>
    public class OapiMiniappMiniappversionQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public MiniAppVersionDoModelDomain Data { get; set; }

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
/// MiniAppVersionDoModelDomain Data Structure.
/// </summary>
[Serializable]

public class MiniAppVersionDoModelDomain : TopObject
{
	        /// <summary>
	        /// 应用ID
	        /// </summary>
	        [XmlElement("appId")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 审核结束时间
	        /// </summary>
	        [XmlElement("audit_finish_time")]
	        public long AuditFinishTime { get; set; }
	
	        /// <summary>
	        /// 审核提交时间
	        /// </summary>
	        [XmlElement("audit_submit_time")]
	        public long AuditSubmitTime { get; set; }
	
	        /// <summary>
	        /// 构建源
	        /// </summary>
	        [XmlElement("build_source")]
	        public string BuildSource { get; set; }
	
	        /// <summary>
	        /// 客户端类型
	        /// </summary>
	        [XmlElement("client_type")]
	        public long ClientType { get; set; }
	
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 过期版本
	        /// </summary>
	        [XmlElement("exp_version")]
	        public long ExpVersion { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("extra_info")]
	        public string ExtraInfo { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public long GmtModified { get; set; }
	
	        /// <summary>
	        /// 灰度开始时间
	        /// </summary>
	        [XmlElement("gray_start_time")]
	        public long GrayStartTime { get; set; }
	
	        /// <summary>
	        /// 灰度策略
	        /// </summary>
	        [XmlElement("gray_strategy")]
	        public string GrayStrategy { get; set; }
	
	        /// <summary>
	        /// ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("inst_id")]
	        public long InstId { get; set; }
	
	        /// <summary>
	        /// isDeleted
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public long IsDeleted { get; set; }
	
	        /// <summary>
	        /// 下线时间
	        /// </summary>
	        [XmlElement("offline_time")]
	        public long OfflineTime { get; set; }
	
	        /// <summary>
	        /// 包地址
	        /// </summary>
	        [XmlElement("package_url")]
	        public string PackageUrl { get; set; }
	
	        /// <summary>
	        /// 商户ID
	        /// </summary>
	        [XmlElement("pid")]
	        public string Pid { get; set; }
	
	        /// <summary>
	        /// 回滚时间
	        /// </summary>
	        [XmlElement("rollback_time")]
	        public long RollbackTime { get; set; }
	
	        /// <summary>
	        /// 上架时间
	        /// </summary>
	        [XmlElement("shelf_time")]
	        public long ShelfTime { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 子状态
	        /// </summary>
	        [XmlElement("sub_status")]
	        public string SubStatus { get; set; }
	
	        /// <summary>
	        /// 模板拓展参数
	        /// </summary>
	        [XmlElement("template_extra")]
	        public string TemplateExtra { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
}

    }
}
