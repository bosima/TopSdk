using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.update
    /// </summary>
    public class OapiUserUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserUpdateResponse>
    {
        /// <summary>
        /// 部门列表
        /// </summary>
        public List<long> Department { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Extattr { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public Nullable<long> HiredDate { get; set; }

        /// <summary>
        /// 是否号码隐藏
        /// </summary>
        public Nullable<bool> IsHide { get; set; }

        /// <summary>
        /// 是否高管模式
        /// </summary>
        public Nullable<bool> IsSenior { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string Jobnumber { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN另外支持en_US)
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// 主管
        /// </summary>
        public string ManagerUserid { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 实际是Map的序列化字符串
        /// </summary>
        public string OrderInDepts { get; set; }

        /// <summary>
        /// 公司邮箱
        /// </summary>
        public string OrgEmail { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 实际是Map的序列化字符串
        /// </summary>
        public string PositionInDepts { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 分机号，长度为0~50个字符
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        public string WorkPlace { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department", TopUtils.ObjectToJson(this.Department));
            parameters.Add("email", this.Email);
            parameters.Add("extattr", this.Extattr);
            parameters.Add("hiredDate", this.HiredDate);
            parameters.Add("isHide", this.IsHide);
            parameters.Add("isSenior", this.IsSenior);
            parameters.Add("jobnumber", this.Jobnumber);
            parameters.Add("lang", this.Lang);
            parameters.Add("managerUserid", this.ManagerUserid);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("orderInDepts", this.OrderInDepts);
            parameters.Add("orgEmail", this.OrgEmail);
            parameters.Add("position", this.Position);
            parameters.Add("positionInDepts", this.PositionInDepts);
            parameters.Add("remark", this.Remark);
            parameters.Add("tel", this.Tel);
            parameters.Add("userid", this.Userid);
            parameters.Add("workPlace", this.WorkPlace);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("department", this.Department, 20);
        }

        #endregion
    }
}
