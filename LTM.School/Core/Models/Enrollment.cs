// 课程登记关联表, 用于关联学生与课程.
// 每个学生的每一门课都有一个这样的关联表.
// 因此一个学生有多个课程时, 会对应多个此关联等级表项.

using LTM.School.Application.enumsType;
using System.ComponentModel.DataAnnotations;

namespace LTM.School.Core.Models {
    /// <summary>
    /// 课程登记关联表.
    /// </summary>
    public class Enrollment {
        /// <summary>
        /// 关联表项 ID.
        /// </summary>
        public int EnrollmentId { get; set; }

        /// <summary>
        /// 学生 ID.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// 课程 ID.
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// 课程成绩.
        /// </summary>
        public CourseGrade Grade { get; set; }
    }
}
