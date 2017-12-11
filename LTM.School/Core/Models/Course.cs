using LTM.School.Application.enumsType;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTM.School.Core.Models {
    public class Course {
        /// <summary>
        /// 课程 ID.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  // 这是 C# 的 Attribute（注解属性）.
                                                           // Entity Framework 的 Code First 会将以类似 "Id" 结尾的字段作为主键, 且如果此属性为 int, 则自动设置为自增类型.
                                                           // 这里可设置为 None, 表明此键值为手工处理, 不需要自增. 默认值为 "Identity".
                                                           // https://www.cnblogs.com/Gyoung/archive/2013/01/18/2865998.html
                                                           // https://www.cnblogs.com/TianFang/archive/2013/04/09/3011099.html
        public int Id { get; set; }

        /// <summary>
        /// 课程名称.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 课程学分.
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// 包含本课程的课程登记表关联表.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
