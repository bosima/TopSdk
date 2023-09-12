using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.department.update
    /// </summary>
    public class OapiDepartmentUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDepartmentUpdateResponse>
    {
        /// <summary>
        /// 如果有新人加入部门是否会自动加入部门群
        /// </summary>
        public Nullable<bool> AutoAddUser { get; set; }

        /// <summary>
        /// 是否创建一个关联此部门的企业群
        /// </summary>
        public Nullable<bool> CreateDeptGroup { get; set; }

        /// <summary>
        /// 是否隐藏部门, true表示隐藏, false表示显示
        /// </summary>
        public Nullable<bool> DeptHiding { get; set; }

        /// <summary>
        /// 部门的主管列表,取值为由主管的userid组成的字符串，不同的userid使用’| 符号进行分割
        /// </summary>
        public string DeptManagerUseridList { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用 | 符号进行分割。总数不能超过200。
        /// </summary>
        public string DeptPerimits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用 | 符号进行分割。总数不能超过200。
        /// </summary>
        public string DeptPermits { get; set; }

        /// <summary>
        /// 部门群是否包含隐藏部门
        /// </summary>
        public Nullable<bool> GroupContainHiddenDept { get; set; }

        /// <summary>
        /// 部门群是否包含外包部门
        /// </summary>
        public Nullable<bool> GroupContainOuterDept { get; set; }

        /// <summary>
        /// 本门群是否包含子部门
        /// </summary>
        public Nullable<bool> GroupContainSubDept { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN另外支持en_US)
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// 部门名称。长度限制为1~64个字符。不允许包含字符‘-’‘，’以及‘,’。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 在父部门中的次序值。order值小的排序靠前
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// 企业群群主
        /// </summary>
        public string OrgDeptOwner { get; set; }

        /// <summary>
        /// 是否本部门的员工仅可见员工自己, 为true时，本部门员工默认只能看到员工自己
        /// </summary>
        public Nullable<bool> OuterDept { get; set; }

        /// <summary>
        /// 是否只能看到所在部门及下级部门通讯录
        /// </summary>
        public Nullable<bool> OuterDeptOnlySelf { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门，值为部门id组成的的字符串，使用|符号进行分割。总数不能超过200。
        /// </summary>
        public string OuterPermitDepts { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员，值为userid组成的的字符串，使用|符号进行分割。总数不能超过200。
        /// </summary>
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// 父部门id。根部门id为1
        /// </summary>
        public string Parentid { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用| 符号进行分割。总数不能超过200。
        /// </summary>
        public string UserPerimits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用| 符号进行分割。总数不能超过200。
        /// </summary>
        public string UserPermits { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.department.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("autoAddUser", this.AutoAddUser);
            parameters.Add("createDeptGroup", this.CreateDeptGroup);
            parameters.Add("deptHiding", this.DeptHiding);
            parameters.Add("deptManagerUseridList", this.DeptManagerUseridList);
            parameters.Add("deptPerimits", this.DeptPerimits);
            parameters.Add("deptPermits", this.DeptPermits);
            parameters.Add("groupContainHiddenDept", this.GroupContainHiddenDept);
            parameters.Add("groupContainOuterDept", this.GroupContainOuterDept);
            parameters.Add("groupContainSubDept", this.GroupContainSubDept);
            parameters.Add("id", this.Id);
            parameters.Add("lang", this.Lang);
            parameters.Add("name", this.Name);
            parameters.Add("order", this.Order);
            parameters.Add("orgDeptOwner", this.OrgDeptOwner);
            parameters.Add("outerDept", this.OuterDept);
            parameters.Add("outerDeptOnlySelf", this.OuterDeptOnlySelf);
            parameters.Add("outerPermitDepts", this.OuterPermitDepts);
            parameters.Add("outerPermitUsers", this.OuterPermitUsers);
            parameters.Add("parentid", this.Parentid);
            parameters.Add("sourceIdentifier", this.SourceIdentifier);
            parameters.Add("userPerimits", this.UserPerimits);
            parameters.Add("userPermits", this.UserPermits);
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
