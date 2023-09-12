using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.card.create
    /// </summary>
    public class OapiEduCardCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCardCreateResponse>
    {
        /// <summary>
        /// 参数
        /// </summary>
        public string Opencardcreateparam { get; set; }

        public OpenCardCreateParamDomain Opencardcreateparam_ { set { this.Opencardcreateparam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.card.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("opencardcreateparam", this.Opencardcreateparam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OpenCreateDetailItemDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCreateDetailItemDomain : TopObject
{
	        /// <summary>
	        /// 是否可以补卡
	        /// </summary>
	        [XmlElement("can_reissue_card")]
	        public Nullable<bool> CanReissueCard { get; set; }
	
	        /// <summary>
	        /// 打卡周期
	        /// </summary>
	        [XmlElement("card_cycle")]
	        public Nullable<long> CardCycle { get; set; }
	
	        /// <summary>
	        /// 打卡频次的设置?"cardFrequency":[  ?????????? 1,//周天  ?????????? 2,//周一  ?????????? 3,//周二  ?????????? 4,//周三  ?????????? 5,//周四  ?????????? 6,//周五  ?????????? 7//周六  ???????]
	        /// </summary>
	        [XmlArray("card_frequency")]
	        [XmlArrayItem("number")]
	        public List<string> CardFrequency { get; set; }
	
	        /// <summary>
	        /// 用于记录每天打卡规则
	        /// </summary>
	        [XmlArray("card_rule_Item_paramlist")]
	        [XmlArrayItem("json")]
	        public List<string> CardRuleItemParamlist { get; set; }
	
	        /// <summary>
	        /// 班级Id列表
	        /// </summary>
	        [XmlArray("class_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ClassIds { get; set; }
	
	        /// <summary>
	        /// 班级名称列表（与ID 列表一一对应）
	        /// </summary>
	        [XmlArray("class_names")]
	        [XmlArrayItem("string")]
	        public List<string> ClassNames { get; set; }
	
	        /// <summary>
	        /// 指定人发布打卡 人员列表{ ????????????"378537900":[ //班级 ????????????????{ ????????????????????"stuId":"15953231155863104", ????????????????????"stuName":"aa" ????????????????}... ???????????????? ????????????] ????????}
	        /// </summary>
	        [XmlElement("class_selected_students")]
	        public string ClassSelectedStudents { get; set; }
	
	        /// <summary>
	        /// 打卡内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 打卡开始时间
	        /// </summary>
	        [XmlElement("effect_date")]
	        public Nullable<DateTime> EffectDate { get; set; }
	
	        /// <summary>
	        /// 上传相册，图片，录音，盯盘的信息
	        /// </summary>
	        [XmlElement("medias")]
	        public string Medias { get; set; }
	
	        /// <summary>
	        /// 是否需要计量
	        /// </summary>
	        [XmlElement("need_metering")]
	        public string NeedMetering { get; set; }
	
	        /// <summary>
	        /// 提醒的小时
	        /// </summary>
	        [XmlElement("remind_hour")]
	        public Nullable<long> RemindHour { get; set; }
	
	        /// <summary>
	        /// 提醒分钟设置
	        /// </summary>
	        [XmlElement("remind_minute")]
	        public Nullable<long> RemindMinute { get; set; }
	
	        /// <summary>
	        /// 选择的角色
	        /// </summary>
	        [XmlElement("target_role")]
	        public string TargetRole { get; set; }
	
	        /// <summary>
	        /// 模板ID
	        /// </summary>
	        [XmlElement("template_id")]
	        public Nullable<long> TemplateId { get; set; }
	
	        /// <summary>
	        /// 打卡名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 计量单位
	        /// </summary>
	        [XmlElement("unit_of_measurement")]
	        public string UnitOfMeasurement { get; set; }
}

	/// <summary>
/// OpenCardCreateParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCardCreateParamDomain : TopObject
{
	        /// <summary>
	        /// 业务code
	        /// </summary>
	        [XmlElement("card_bizcode")]
	        public string CardBizcode { get; set; }
	
	        /// <summary>
	        /// 卡片的具体信息
	        /// </summary>
	        [XmlElement("data")]
	        public OpenCreateDetailItemDomain Data { get; set; }
	
	        /// <summary>
	        /// 创建打卡的请求ID
	        /// </summary>
	        [XmlElement("identifier")]
	        public string Identifier { get; set; }
	
	        /// <summary>
	        /// 前端版本
	        /// </summary>
	        [XmlElement("jsversion")]
	        public Nullable<long> Jsversion { get; set; }
	
	        /// <summary>
	        /// 内容来源,需要注册
	        /// </summary>
	        [XmlElement("sourcetype")]
	        public string Sourcetype { get; set; }
	
	        /// <summary>
	        /// 当前登录的 staffId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
