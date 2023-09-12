using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.create
    /// </summary>
    public class OapiUserCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserCreateResponse>
    {
        /// <summary>
        /// 数组类型，数组里面值为整型，成员所属部门id列表
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一，不可重复
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 扩展属性，可以设置多种属性(但手机上最多只能显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置)
        /// </summary>
        public string Extattr { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public Nullable<long> HiredDate { get; set; }

        /// <summary>
        /// 是否号码隐藏, true表示隐藏, false表示不隐藏。隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
        /// </summary>
        public Nullable<bool> IsHide { get; set; }

        /// <summary>
        /// 是否高管模式，true表示是，false表示不是。开启后，手机号码对所有员工隐藏。普通员工无法对其发DING、发起钉钉免费商务电话。高管之间不受影响。
        /// </summary>
        public Nullable<bool> IsSenior { get; set; }

        /// <summary>
        /// 员工工号。对应显示到OA后台和客户端个人资料的工号栏目。长度为0~64个字符
        /// </summary>
        public string Jobnumber { get; set; }

        /// <summary>
        /// 手机号码，企业内必须唯一，不可重复
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 在对应的部门中的排序, Map结构的json字符串, key是部门的Id, value是人员在这个部门的排序值
        /// </summary>
        public string OrderInDepts { get; set; }

        /// <summary>
        /// 员工的企业邮箱，员工的企业邮箱已开通，才能增加此字段， 否则会报错
        /// </summary>
        public string OrgEmail { get; set; }

        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 在对应的部门中的职位信息, Map结构的json字符串, key是部门的Id, value是人员在这个部门的职位
        /// </summary>
        public string PositionInDepts { get; set; }

        /// <summary>
        /// 备注，长度为0~1000个字符
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 分机号，长度为0~50个字符，企业内必须唯一，不可重复
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 员工唯一标识ID（不可修改），企业内必须唯一。长度为1~64个字符，如果不传，服务器将自动生成一个userid
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 办公地点，长度为0~50个字符
        /// </summary>
        public string WorkPlace { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department", this.Department);
            parameters.Add("email", this.Email);
            parameters.Add("extattr", this.Extattr);
            parameters.Add("hiredDate", this.HiredDate);
            parameters.Add("isHide", this.IsHide);
            parameters.Add("isSenior", this.IsSenior);
            parameters.Add("jobnumber", this.Jobnumber);
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
        }

        #endregion
    }
}
