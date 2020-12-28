using System.Collections.Generic;

namespace spz_lb2
{
    class UniversityEqualityComparer : IEqualityComparer<University>
    {
        public bool Equals(University u1, University u2)
        {
            if (u1.FacultiesAmount == u2.FacultiesAmount &&
                u1.AuditoryAmount == u2.AuditoryAmount &&
                u1.LaboratoryAmount == u2.LaboratoryAmount &&
                u1.StudentAmount == u2.StudentAmount &&
                u1.StuffAmount == u2.StuffAmount &&
                u1.TeacherAmount == u2.TeacherAmount &&
                u1.Name == u2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(University uni)
        {
            int hCode = uni.LaboratoryAmount ^ uni.AuditoryAmount ^ uni.StuffAmount ^
                uni.StudentAmount ^ uni.TeacherAmount ^ uni.FacultiesAmount;
            return hCode.GetHashCode();
        }
    }
}
