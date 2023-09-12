using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.user.create
    /// </summary>
    public class OapiV2UserCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2UserCreateResponse>
    {
        /// <summary>
        /// 创建本组织专属帐号时可指定头像MediaId。只支持参考jpg/png，生成方法 https://developers.dingtalk.com/document/app/upload-media-files
        /// </summary>
        public string AvatarMediaId { get; set; }

        /// <summary>
        /// 所属部门id列表
        /// </summary>
        public string DeptIdList { get; set; }

        /// <summary>
        /// 员工在对应的部门中的排序。
        /// </summary>
        public string DeptOrderList { get; set; }

        public List<DeptOrderDomain> DeptOrderList_ { set { this.DeptOrderList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 部门内任职
        /// </summary>
        public string DeptPositionList { get; set; }

        public List<DeptPositionDomain> DeptPositionList_ { set { this.DeptPositionList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工在对应的部门中的职位。
        /// </summary>
        public string DeptTitleList { get; set; }

        public List<DeptTitleDomain> DeptTitleList_ { set { this.DeptTitleList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工邮箱，长度最大50个字符。企业内必须唯一，不可重复。
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 是否专属帐号（true时，不能指定loginEmail或mobile）
        /// </summary>
        public Nullable<bool> ExclusiveAccount { get; set; }

        /// <summary>
        /// 专属帐号类型：sso： 企业自建专属帐号；dingtalk：钉钉自建专属帐号。
        /// </summary>
        public string ExclusiveAccountType { get; set; }

        /// <summary>
        /// 专属帐号手机号
        /// </summary>
        public string ExclusiveMobile { get; set; }

        /// <summary>
        /// 专属帐号手机号验证状态
        /// </summary>
        public string ExclusiveMobileVerifyStatus { get; set; }

        /// <summary>
        /// 自定义字段列表
        /// </summary>
        public string ExtAttrs { get; set; }

        public List<EmpExtAttrDomain> ExtAttrs_ { set { this.ExtAttrs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 自定义字段更新模式，0-覆盖方式 1-追加方式 (默认是覆盖)
        /// </summary>
        public Nullable<long> ExtAttrsUpdateMode { get; set; }

        /// <summary>
        /// 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 自定义性别字段
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 是否号码隐藏。隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
        /// </summary>
        public Nullable<bool> HideMobile { get; set; }

        /// <summary>
        /// 入职时间，Unix时间戳，单位ms。
        /// </summary>
        public Nullable<long> HiredDate { get; set; }

        /// <summary>
        /// 钉钉专属帐号初始密码
        /// </summary>
        public string InitPassword { get; set; }

        /// <summary>
        /// 员工工号，长度最大50个字符。
        /// </summary>
        public string JobNumber { get; set; }

        /// <summary>
        /// 登录邮箱
        /// </summary>
        public string LoginEmail { get; set; }

        /// <summary>
        /// 钉钉专属帐号登录名
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 直属主管
        /// </summary>
        public string ManagerUserid { get; set; }

        /// <summary>
        /// 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 员工名称，长度最大80个字符。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建本组织专属帐号时可指定昵称
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// 员工的企业邮箱，长度最大100个字符。员工的企业邮箱已开通，才能增加此字段。
        /// </summary>
        public string OrgEmail { get; set; }

        /// <summary>
        /// 企业邮箱类型（profession：标准版，base：基础版）
        /// </summary>
        public string OrgEmailType { get; set; }

        /// <summary>
        /// 需要添加的专属帐号所属corpid
        /// </summary>
        public string OuterExclusiveCorpid { get; set; }

        /// <summary>
        /// 需要添加的专属帐号所属userid
        /// </summary>
        public string OuterExclusiveUserid { get; set; }

        /// <summary>
        /// 备注，长度最大2000个字符。
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否高管模式。开启后，手机号码对所有员工隐藏。普通员工无法对其发DING、发起钉钉免费商务电话。高管之间不受影响。
        /// </summary>
        public Nullable<bool> SeniorMode { get; set; }

        /// <summary>
        /// 分机号，长度最大50个字符。企业内必须唯一，不可重复
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 职位，长度最大200个字符。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 员工id，长度最大64个字符。员工在当前企业内的唯一标识。
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 办公地点，长度最大100个字符。
        /// </summary>
        public string WorkPlace { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.user.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("avatarMediaId", this.AvatarMediaId);
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("dept_order_list", this.DeptOrderList);
            parameters.Add("dept_position_list", this.DeptPositionList);
            parameters.Add("dept_title_list", this.DeptTitleList);
            parameters.Add("email", this.Email);
            parameters.Add("exclusive_account", this.ExclusiveAccount);
            parameters.Add("exclusive_account_type", this.ExclusiveAccountType);
            parameters.Add("exclusive_mobile", this.ExclusiveMobile);
            parameters.Add("exclusive_mobile_verify_status", this.ExclusiveMobileVerifyStatus);
            parameters.Add("ext_attrs", this.ExtAttrs);
            parameters.Add("ext_attrs_update_mode", this.ExtAttrsUpdateMode);
            parameters.Add("extension", this.Extension);
            parameters.Add("gender", this.Gender);
            parameters.Add("hide_mobile", this.HideMobile);
            parameters.Add("hired_date", this.HiredDate);
            parameters.Add("init_password", this.InitPassword);
            parameters.Add("job_number", this.JobNumber);
            parameters.Add("login_email", this.LoginEmail);
            parameters.Add("login_id", this.LoginId);
            parameters.Add("manager_userid", this.ManagerUserid);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("nickname", this.Nickname);
            parameters.Add("org_email", this.OrgEmail);
            parameters.Add("org_email_type", this.OrgEmailType);
            parameters.Add("outer_exclusive_corpid", this.OuterExclusiveCorpid);
            parameters.Add("outer_exclusive_userid", this.OuterExclusiveUserid);
            parameters.Add("remark", this.Remark);
            parameters.Add("senior_mode", this.SeniorMode);
            parameters.Add("telephone", this.Telephone);
            parameters.Add("title", this.Title);
            parameters.Add("userid", this.Userid);
            parameters.Add("work_place", this.WorkPlace);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 100);
            RequestValidator.ValidateObjectMaxListSize("dept_order_list", this.DeptOrderList, 100);
            RequestValidator.ValidateObjectMaxListSize("dept_position_list", this.DeptPositionList, 999);
            RequestValidator.ValidateObjectMaxListSize("dept_title_list", this.DeptTitleList, 100);
            RequestValidator.ValidateMaxLength("email", this.Email, 50);
            RequestValidator.ValidateObjectMaxListSize("ext_attrs", this.ExtAttrs, 999);
            RequestValidator.ValidateMinValue("hired_date", this.HiredDate, 1);
            RequestValidator.ValidateMaxLength("job_number", this.JobNumber, 50);
            RequestValidator.ValidateMaxLength("login_email", this.LoginEmail, 64);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 80);
            RequestValidator.ValidateMaxLength("org_email", this.OrgEmail, 100);
            RequestValidator.ValidateMaxLength("remark", this.Remark, 2000);
            RequestValidator.ValidateMaxLength("telephone", this.Telephone, 50);
            RequestValidator.ValidateMaxLength("title", this.Title, 200);
            RequestValidator.ValidateMaxLength("userid", this.Userid, 64);
            RequestValidator.ValidateMaxLength("work_place", this.WorkPlace, 100);
        }

	/// <summary>
/// DeptOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeptOrderDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 员工在部门中的排序。
	        /// </summary>
	        [XmlElement("order")]
	        public Nullable<long> Order { get; set; }
}

	/// <summary>
/// DeptTitleDomain Data Structure.
/// </summary>
[Serializable]

public class DeptTitleDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 员工在部门中的职位。
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// DeptPositionDomain Data Structure.
/// </summary>
[Serializable]

public class DeptPositionDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 是否是主任职
	        /// </summary>
	        [XmlElement("is_main")]
	        public Nullable<bool> IsMain { get; set; }
	
	        /// <summary>
	        /// 部门内职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 部门内办公地
	        /// </summary>
	        [XmlElement("work_place")]
	        public string WorkPlace { get; set; }
}

	/// <summary>
/// EmpExtAttrValueDomain Data Structure.
/// </summary>
[Serializable]

public class EmpExtAttrValueDomain : TopObject
{
	        /// <summary>
	        /// 自定义字段图片值
	        /// </summary>
	        [XmlArray("images")]
	        [XmlArrayItem("string")]
	        public List<string> Images { get; set; }
	
	        /// <summary>
	        /// 自定义字段文本值
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 自定义字段链接值
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// EmpExtAttrDomain Data Structure.
/// </summary>
[Serializable]

public class EmpExtAttrDomain : TopObject
{
	        /// <summary>
	        /// 自定义字段编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 自定义字段值
	        /// </summary>
	        [XmlElement("value")]
	        public EmpExtAttrValueDomain Value { get; set; }
}

        #endregion
    }
}
