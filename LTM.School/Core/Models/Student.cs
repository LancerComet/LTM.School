using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models {
    /// <summary>
    /// 学生表实体.
    /// </summary>
    public class Student {
        /// <summary>
        /// 学生 ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 学生名称.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// 学生登记日期.
        /// </summary>
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// 学生已经登记的课程的 Enrollment.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
