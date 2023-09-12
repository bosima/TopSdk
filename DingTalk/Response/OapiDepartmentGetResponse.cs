using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiDepartmentGetResponse.
    /// </summary>
    public class OapiDepartmentGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 当群已经创建后，是否有新人加入部门会自动加入该群, true表示是, false表示不是
        /// </summary>
        [XmlElement("autoAddUser")]
        public bool AutoAddUser { get; set; }

        /// <summary>
        /// 是否同步创建一个关联此部门的企业群, true表示是, false表示不是
        /// </summary>
        [XmlElement("createDeptGroup")]
        public bool CreateDeptGroup { get; set; }

        /// <summary>
        /// 是否隐藏部门, true表示隐藏, false表示显示
        /// </summary>
        [XmlElement("deptHiding")]
        public bool DeptHiding { get; set; }

        /// <summary>
        /// 部门的主管列表,取值为由主管的userid组成的字符串，不同的userid使用|符号进行分割
        /// </summary>
        [XmlElement("deptManagerUseridList")]
        public string DeptManagerUseridList { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用|符号进行分割
        /// </summary>
        [XmlElement("deptPerimits")]
        public string DeptPerimits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用|符号进行分割
        /// </summary>
        [XmlElement("deptPermits")]
        public string DeptPermits { get; set; }

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
        /// 部门群是否包含子部门
        /// </summary>
        [XmlElement("groupContainSubDept")]
        public bool GroupContainSubDept { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 部门是否来自关联组织
        /// </summary>
        [XmlElement("isFromUnionOrg")]
        public bool IsFromUnionOrg { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 在父部门中的次序值
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 企业群群主
        /// </summary>
        [XmlElement("orgDeptOwner")]
        public string OrgDeptOwner { get; set; }

        /// <summary>
        /// 是否本部门的员工仅可见员工自己, 为true时，本部门员工默认只能看到员工自己
        /// </summary>
        [XmlElement("outerDept")]
        public bool OuterDept { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门，值为部门id组成的的字符串，使用|符号进行分割
        /// </summary>
        [XmlElement("outerPermitDepts")]
        public string OuterPermitDepts { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员，值为userid组成的的字符串，使用| 符号进行分割
        /// </summary>
        [XmlElement("outerPermitUsers")]
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// 父部门id，根部门为1
        /// </summary>
        [XmlElement("parentid")]
        public long Parentid { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        [XmlElement("sourceIdentifier")]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用|符号进行分割
        /// </summary>
        [XmlElement("userPerimits")]
        public string UserPerimits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用|符号进行分割
        /// </summary>
        [XmlElement("userPermits")]
        public string UserPermits { get; set; }

    }
}
