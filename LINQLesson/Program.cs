using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLesson
{
    class Program
    {
        dbSchoolDataContext dtb = new dbSchoolDataContext();
        private static void Main()
        {

            student st = new student();

            st.StudentID = 1;
            st.StudentName = "George";
            st.StudentAddress = "Kandal";
            st.Sex = "Male";
            st.DepartmentID = 1;
        }
    }
}
