using System;
using System.Windows.Forms;
using System.Drawing;

namespace spz_lb2
{
    public partial class MainWindow : Form
    {
        static Universities university = new Universities();
        private static int _index = 0;
        private int UniversityIndex;
        public MainWindow()
        {
            InitializeComponent();
            Constructor.Click += OnConstructorClick;
            cbxUniversities.Click += CbxUniversities_Click;
            cbxUniversities.SelectedIndexChanged += CbxUniversities_SelectedIndexChanged;
            btAddStudent.Click += BtAddStudent_Click;
            btKickStudent.Click += BtKickStudent_Click;
            btAddAuditory.Click += BtAddAuditory_Click;
            btAddLaboratory.Click += BtAddLaboratory_Click;
            btHireTeacher.Click += BtHireTeacher_Click;
            btKickTeacher.Click += BtKickTeacher_Click;
            btHireStuff.Click += BtHireStuff_Click;
            btKickStuff.Click += BtKickStuff_Click;
            btAddStudentSubmit.Click += BtAddStudentSubmit_Click;
            btKickStudentSubmit.Click += BtKickStudentSubmit_Click;
            btAddAuditorySubmit.Click += BtAddAuditorySubmit_Click;
            btAddLaboratorySubmit.Click += BtAddLaboratorySubmit_Click;
            btHireTeacherSubmit.Click += BtHireTeacherSubmit_Click;
            btKickTeacherSubmit.Click += BtKickTeacherSubmit_Click;
            btHireStuffSubmit.Click += BtHireStuffSubmit_Click;
            btKickStuffSubmit.Click += BtKickStuffSubmit_Click;
            btBack.Click += BtBack_Click;
            btCombine.Click += BtCombine_Click;
            cbxU1.Click += CbxU1_Click;
            cbxU2.Click += CbxU2_Click;
            btCombineSubmit.Click += BtCombineSubmit_Click;
            cbxClone.Click += CbxClone_Click;
            btClone.Click += BtClone_Click;
            btCloneSubmit.Click += BtCloneSubmit_Click;
        }

        private void BtCloneSubmit_Click(object sender, EventArgs e)
        {
            if (university.Length() != 0)
                university[_index++] = new University(university[cbxClone.SelectedIndex]);
            cbxClone.Hide();
            btCloneSubmit.Hide();
            Constructor.Enabled = true;
            btCombine.Enabled = true;
            cbxUniversities.Enabled = true;
        }

        private void BtClone_Click(object sender, EventArgs e)
        {
            cbxClone.Show();
            btCloneSubmit.Show();
            Constructor.Enabled = false;
            btCombine.Enabled = false;
            cbxUniversities.Enabled = false;
        }

        private void CbxClone_Click(object sender, EventArgs e)
        {
            cbxClone.Items.Clear();
            var length = university.Length();
            if (length != 0)
                for (int i = 0; i < length; i++)
                    cbxClone.Items.Add(university[i].Name);
        }

        private void BtCombineSubmit_Click(object sender, EventArgs e)
        {
            if (university.Length() != 0)
                university[_index++] = university[cbxU1.SelectedIndex] + university[cbxU2.SelectedIndex];
            cbxU1.Hide();
            cbxU2.Hide();
            lbPlus.Hide();
            btCombineSubmit.Hide();
            Constructor.Enabled = true;
            btClone.Enabled = true;
            cbxUniversities.Enabled = true;
        }

        private void CbxU2_Click(object sender, EventArgs e)
        {
            cbxU2.Items.Clear();
            var length = university.Length();
            if (length != 0)
                for (int i = 0; i < length; i++)
                    cbxU2.Items.Add(university[i].Name);
        }

        private void CbxU1_Click(object sender, EventArgs e)
        {
            cbxU1.Items.Clear();
            var length = university.Length();
            if (length != 0)
                for (int i = 0; i < length; i++)
                    cbxU1.Items.Add(university[i].Name);
        }

        private void BtCombine_Click(object sender, EventArgs e)
        {
            cbxU1.Show();
            cbxU2.Show();
            lbPlus.Show();
            btCombineSubmit.Show();
            Constructor.Enabled = false;
            btClone.Enabled = false;
            cbxUniversities.Enabled = false;
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            lbAuditoryAmount.Hide();
            lbFacultyAmount.Hide();
            lbName.Hide();
            lbStuffAmount.Hide();
            lbTeachersAmount.Hide();
            lbLaboratoryAmount.Hide();
            lbStudentAmount.Hide();
            btAddStudent.Hide();
            btAddLaboratory.Hide();
            btAddAuditory.Hide();
            btKickStudent.Hide();
            btHireStuff.Hide();
            btKickStudent.Hide();
            btKickStuff.Hide();
            btHireTeacher.Hide();
            btKickTeacher.Hide();
            btBack.Hide();
            Constructor.Show();
            btClone.Show();
            btCombine.Show();
            cbxUniversities.Show();
            lbChoise.Show();
        }

        private void BtKickStuffSubmit_Click(object sender, EventArgs e)
        {
            int n = university[UniversityIndex].StuffAmount - int.Parse(NumberUD.Text);
            university[UniversityIndex].StuffAmount = n > 0 ? n : 0;
            NumberUD.Hide();
            btKickStuffSubmit.Hide();
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btKickStudent.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickTeacher.Enabled = true;
            NumberUD.Text = "0";
            lbStuffAmount.Text = $"Персонал: {university[UniversityIndex].StuffAmount.ToString()}";
            Update();
        }

        private void BtKickStuff_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 281);
            NumberUD.Show();
            btKickStuffSubmit.Show();
            btAddStudent.Enabled = false;
            btKickStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btAddLaboratory.Enabled = false;
            btHireTeacher.Enabled = false;
            btKickTeacher.Enabled = false;
            btHireStuff.Enabled = false;
        }

        private void BtHireStuffSubmit_Click(object sender, EventArgs e)
        {
            university[UniversityIndex].StuffAmount += int.Parse(NumberUD.Text);
            NumberUD.Hide();
            btHireStuffSubmit.Hide();
            btKickStuff.Location = new Point(260, 248);
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btKickStudent.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btKickTeacher.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
            lbStuffAmount.Text = $"Персонал: {university[UniversityIndex].StuffAmount.ToString()}";
            Update();
        }

        private void BtHireStuff_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 248);
            NumberUD.Show();
            btHireStuffSubmit.Show();
            btKickStuff.Location = new Point(260, 268);
            btAddStudent.Enabled = false;
            btKickStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btAddLaboratory.Enabled = false;
            btHireTeacher.Enabled = false;
            btKickTeacher.Enabled = false;
            btKickStuff.Enabled = false;
        }

        private void BtKickTeacherSubmit_Click(object sender, EventArgs e)
        {
            int n = university[UniversityIndex].TeacherAmount - int.Parse(NumberUD.Text);
            university[UniversityIndex].TeacherAmount = n > 0 ? n : 0;
            NumberUD.Hide();
            btKickTeacherSubmit.Hide();
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btKickStudent.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
            lbTeachersAmount.Text = $"Преподаватели: {university[UniversityIndex].TeacherAmount.ToString()}";
            Update();
        }

        private void BtKickTeacher_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 215);
            NumberUD.Show();
            btKickTeacherSubmit.Show();
            btHireStuff.Location = new Point(260, 235);
            btKickStuff.Location = new Point(260, 268);
            btAddStudent.Enabled = false;
            btKickStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btAddLaboratory.Enabled = false;
            btHireTeacher.Enabled = false;
            btHireStuff.Enabled = false;
            btKickStuff.Enabled = false;
        }

        private void BtHireTeacherSubmit_Click(object sender, EventArgs e)
        {
            university[UniversityIndex].TeacherAmount += int.Parse(NumberUD.Text);
            NumberUD.Hide();
            btHireTeacherSubmit.Hide();
            btKickTeacher.Location = new Point(260, 182);
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btAddStudent.Location = new Point(260, 48);
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btKickStudent.Enabled = true;
            btAddLaboratory.Enabled = true;
            btKickTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
            lbTeachersAmount.Text = $"Преподаватели: {university[UniversityIndex].TeacherAmount.ToString()}";
            Update();
        }

        private void BtHireTeacher_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 182);
            NumberUD.Show();
            btHireTeacherSubmit.Show();
            btKickTeacher.Location = new Point(260, 202);
            btHireStuff.Location = new Point(260, 235);
            btKickStuff.Location = new Point(260, 268);
            btAddStudent.Enabled = false;
            btKickStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btAddLaboratory.Enabled = false;
            btKickTeacher.Enabled = false;
            btHireStuff.Enabled = false;
            btKickStuff.Enabled = false;
        }

        private void BtAddLaboratorySubmit_Click(object sender, EventArgs e)
        {
            university[UniversityIndex].LaboratoryAmount += int.Parse(NumberUD.Text);
            NumberUD.Hide();
            btAddLaboratorySubmit.Hide();
            btHireTeacher.Location = new Point(260, 149);
            btKickTeacher.Location = new Point(260, 182);
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btAddStudent.Location = new Point(260, 48);
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btKickStudent.Enabled = true;
            btHireTeacher.Enabled = true;
            btKickTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
            lbLaboratoryAmount.Text = $"Лаборатории: {university[UniversityIndex].LaboratoryAmount.ToString()}";
            Update();
        }

        private void BtAddLaboratory_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 149);
            NumberUD.Show();
            btAddLaboratorySubmit.Show();
            btHireTeacher.Location = new Point(260, 169);
            btKickTeacher.Location = new Point(260, 202);
            btHireStuff.Location = new Point(260, 235);
            btKickStuff.Location = new Point(260, 268);
            btAddStudent.Enabled = false;
            btKickStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btHireTeacher.Enabled = false;
            btKickTeacher.Enabled = false;
            btHireStuff.Enabled = false;
            btKickStuff.Enabled = false;
        }

        private void BtAddAuditory_Click(object sender, EventArgs e)
        {
            if (university[UniversityIndex].AuditoryAmount < university[UniversityIndex].StuffAmount * 2)
            {
                NumberUD.Location = new Point(260, 116);
                NumberUD.Show();
                btAddAuditorySubmit.Show();
                btAddLaboratory.Location = new Point(260, 136);
                btHireTeacher.Location = new Point(260, 169);
                btKickTeacher.Location = new Point(260, 202);
                btHireStuff.Location = new Point(260, 235);
                btKickStuff.Location = new Point(260, 268);
                btAddStudent.Enabled = false;
                btKickStudent.Enabled = false;
                btAddLaboratory.Enabled = false;
                btHireTeacher.Enabled = false;
                btKickTeacher.Enabled = false;
                btHireStuff.Enabled = false;
                btKickStuff.Enabled = false;
            }
            else
                MessageBox.Show("Недостаточно сотрудников!");
        }

        private void BtAddAuditorySubmit_Click(object sender, EventArgs e)
        {
            if ((int.Parse(NumberUD.Text) + university[UniversityIndex].AuditoryAmount)
                <= university[UniversityIndex].StuffAmount * 2)
            {
                university[UniversityIndex].AuditoryAmount += int.Parse(NumberUD.Text);
                lbAuditoryAmount.Text = $"Аудитории: {university[UniversityIndex].AuditoryAmount.ToString()}";
                Update();
            }
            else
                MessageBox.Show("Недостаточно сотрудников!");
            btAddAuditorySubmit.Hide();
            NumberUD.Hide();
            btAddLaboratory.Location = new Point(260, 116);
            btHireTeacher.Location = new Point(260, 149);
            btKickTeacher.Location = new Point(260, 182);
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btKickStudent.Enabled = true;
            btAddStudent.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btKickTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
        }

        private void BtKickStudentSubmit_Click(object sender, EventArgs e)
        {
            int n = university[UniversityIndex].StudentAmount - int.Parse(NumberUD.Text);
            university[UniversityIndex].StudentAmount = n > 0 ? n : 0;
            NumberUD.Hide();
            btKickStudentSubmit.Hide();
            btAddAuditory.Location = new Point(260, 82);
            btAddLaboratory.Location = new Point(260, 116);
            btHireTeacher.Location = new Point(260, 149);
            btKickTeacher.Location = new Point(260, 182);
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btAddStudent.Location = new Point(260, 48);
            btAddStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btKickTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
            lbStudentAmount.Text = $"Студенты: {university[UniversityIndex].StudentAmount.ToString()}";
            Update();
        }

        private void BtAddStudentSubmit_Click(object sender, EventArgs e)
        {
            if ((int.Parse(NumberUD.Text) + university[UniversityIndex].StudentAmount)
                <= university[UniversityIndex].TeacherAmount * 10)
            {
                university[UniversityIndex].StudentAmount += int.Parse(NumberUD.Text);
                lbStudentAmount.Text = $"Студенты: {university[UniversityIndex].StudentAmount.ToString()}";
                Update();
            }
            else
                MessageBox.Show("Недостаточно преподавателей!");
            btAddStudentSubmit.Hide();
            NumberUD.Hide();
            btAddAuditory.Location = new Point(260, 82);
            btAddLaboratory.Location = new Point(260, 116);
            btHireTeacher.Location = new Point(260, 149);
            btKickTeacher.Location = new Point(260, 182);
            btHireStuff.Location = new Point(260, 215);
            btKickStuff.Location = new Point(260, 248);
            btKickStudent.Enabled = true;
            btAddAuditory.Enabled = true;
            btAddLaboratory.Enabled = true;
            btHireTeacher.Enabled = true;
            btKickTeacher.Enabled = true;
            btHireStuff.Enabled = true;
            btKickStuff.Enabled = true;
            NumberUD.Text = "0";
        }

        private void BtKickStudent_Click(object sender, EventArgs e)
        {
            NumberUD.Location = new Point(260, 46);
            NumberUD.Show();
            btKickStudentSubmit.Show();
            btAddAuditory.Location = new Point(260, 102);
            btAddLaboratory.Location = new Point(260, 136);
            btHireTeacher.Location = new Point(260, 169);
            btKickTeacher.Location = new Point(260, 202);
            btHireStuff.Location = new Point(260, 235);
            btKickStuff.Location = new Point(260, 268);
            btAddStudent.Location = new Point(260, 68);
            btAddStudent.Enabled = false;
            btAddAuditory.Enabled = false;
            btAddLaboratory.Enabled = false;
            btHireTeacher.Enabled = false;
            btKickTeacher.Enabled = false;
            btHireStuff.Enabled = false;
            btKickStuff.Enabled = false;
        }

        private void BtAddStudent_Click(object sender, EventArgs e)
        {
            if (university[UniversityIndex].StudentAmount < university[UniversityIndex].TeacherAmount * 10)
            {
                NumberUD.Location = new Point(260, 80);
                btAddStudentSubmit.Show();
                NumberUD.Show();
                btAddAuditory.Location = new Point(260, 102);
                btAddLaboratory.Location = new Point(260, 136);
                btHireTeacher.Location = new Point(260, 169);
                btKickTeacher.Location = new Point(260, 202);
                btHireStuff.Location = new Point(260, 235);
                btKickStuff.Location = new Point(260, 268);
                btKickStudent.Enabled = false;
                btAddAuditory.Enabled = false;
                btAddLaboratory.Enabled = false;
                btHireTeacher.Enabled = false;
                btKickTeacher.Enabled = false;
                btHireStuff.Enabled = false;
                btKickStuff.Enabled = false;
            }
            else
                MessageBox.Show("Недостаточно преподавателей!");
        }

        private void CbxUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversityIndex = cbxUniversities.SelectedIndex;
            Constructor.Hide();
            cbxUniversities.Hide();
            lbChoise.Hide();
            btClone.Hide();
            btCombine.Hide();
            btKickStudent.Show();
            btAddStudent.Show();
            btAddLaboratory.Show();
            btAddAuditory.Show();
            btHireTeacher.Show();
            btHireStuff.Show();
            btKickTeacher.Show();
            btKickStuff.Show();
            lbStudentAmount.Text = $"Студенты: {university[UniversityIndex].StudentAmount.ToString()}";
            lbAuditoryAmount.Text = $"Аудитории: {university[UniversityIndex].AuditoryAmount.ToString()}";
            lbLaboratoryAmount.Text = $"Лаборатории: {university[UniversityIndex].LaboratoryAmount.ToString()}";
            lbTeachersAmount.Text = $"Преподаватели: {university[UniversityIndex].TeacherAmount.ToString()}";
            lbStuffAmount.Text = $"Персонал: {university[UniversityIndex].StuffAmount.ToString()}";
            lbFacultyAmount.Text = $"Факультеты: {university[UniversityIndex].FacultiesAmount.ToString()}";
            lbStudentAmount.Show();
            lbAuditoryAmount.Show();
            lbLaboratoryAmount.Show();
            lbTeachersAmount.Show();
            lbStuffAmount.Show();
            lbFacultyAmount.Show();
            lbName.Text = university[UniversityIndex].Name;
            lbName.Show();
            btBack.Show();
        }

        private void CbxUniversities_Click(object sender, EventArgs e)
        {
            cbxUniversities.Items.Clear();
            var length = university.Length();
            if (length != 0)
                for (int i = 0; i < length; i++)
                    cbxUniversities.Items.Add(university[i].Name);
        }

        public void Filler(int fcltyA, int lbA, int audA, int stdntA, int tchrA, int stfA, string name)
        {
            university[_index++] = new University(fcltyA, lbA, audA, stdntA, tchrA, stfA, name);
        }

        private void OnConstructorClick(object sender, EventArgs e)
        {
            var window = new AddUniversity();
            window.Show();
        }
    }
}
