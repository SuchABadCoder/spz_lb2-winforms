using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spz_lb2
{
    class University
    {
        public string Name;
        public int FacultiesAmount { get; set; }
        public int LaboratoryAmount { get; set; }
        public int AuditoryAmount { get; set; }
        public int StudentAmount { get; set; }
        public int TeacherAmount { get; set; }
        public int StuffAmount { get; set; }

        public University(int fcltyA, int lbA, int audA, int stdntA, int tchrA, int stfA, string name)
        {
            Name = name;
            FacultiesAmount = fcltyA;
            LaboratoryAmount = lbA;
            AuditoryAmount = audA;
            StudentAmount = stdntA;
            StuffAmount = stfA;
            TeacherAmount = tchrA;
        }

        public University(University src)//копирующий конструктор
        {
            Name = src.Name;
            FacultiesAmount = src.FacultiesAmount;
            LaboratoryAmount = src.LaboratoryAmount;
            AuditoryAmount = src.AuditoryAmount;
            StudentAmount = src.StudentAmount;
            StuffAmount = src.StuffAmount;
            TeacherAmount = src.TeacherAmount;
        }

        public static University operator +(University u1, University u2)//перегрузка оператора
        {
            int fcltyA = u1.FacultiesAmount + u2.FacultiesAmount;
            int lbA = u1.LaboratoryAmount + u2.LaboratoryAmount;
            int audA = u1.AuditoryAmount + u2.AuditoryAmount;
            int stdntA = u1.StudentAmount + u2.StudentAmount;
            int tchrA = u1.TeacherAmount + u2.TeacherAmount;
            int stfA = u1.StuffAmount + u2.StuffAmount;
            return new University(fcltyA, lbA, audA, stdntA, tchrA, stfA, u1.Name);
        } 
    }

    class Universities
    {
        University[] data;
        
        public Universities()
        {
            data = new University[0];
        }

        public University this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                Array.Resize(ref data, data.Length + 1);
                data[index] = value;
            }
        }
        
        public University this[int Auditory, int Laboratory]
        {
            get
            {
                University university = null;
                foreach (var p in data)
                {
                    if (p?.AuditoryAmount == Auditory && p?.LaboratoryAmount == Laboratory)
                    {
                        university = p;
                        break;
                    }
                }
                return university;
            }
        }

        public bool EachCompare(University src)
        {
            if (data.Length == 0)
                return false;
            UniversityEqualityComparer UniEqC = new UniversityEqualityComparer();
            foreach (var p in data)
            {
                if (UniEqC.Equals(p, src))
                    return true;
            }
            return false;
        }
        
        public int Length()
        {
            return data.Length;
        }
    }
}
