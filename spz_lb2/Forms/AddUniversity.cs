using System;
using System.Windows.Forms;

namespace spz_lb2
{
    public partial class AddUniversity : Form
    {
        static Universities university = new Universities();
        private static int _index = 0;
        public AddUniversity()
        {
            InitializeComponent();
            StudentsUD.Click += StudentsUD_Click;
            AuditoryUD.Click += AuditoryUD_Click;
            tbName.KeyPress += TbName_KeyPress;
            btAdd.Click += BtAdd_Click;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                University uni = new University(int.Parse(FacultiesUD.Text),
                    int.Parse(LaboratoryUD.Text),
                    int.Parse(AuditoryUD.Text),
                    int.Parse(StudentsUD.Text),
                    int.Parse(TeachersUD.Text),
                    int.Parse(StuffUD.Text),
                    tbName.Text);
                if (!university.EachCompare(uni))
                {
                    university[_index++] = uni;
                    MainWindow main = new MainWindow();
                    main.Filler(int.Parse(FacultiesUD.Text),
                        int.Parse(LaboratoryUD.Text),
                        int.Parse(AuditoryUD.Text),
                        int.Parse(StudentsUD.Text),
                        int.Parse(TeachersUD.Text),
                        int.Parse(StuffUD.Text),
                        tbName.Text);
                    Close();
                }
                else
                    MessageBox.Show("Такой университет уже сушествует!");
            }
            else
                MessageBox.Show("Введите название!");
        }

        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AuditoryUD_Click(object sender, EventArgs e)
        {
           AuditoryUD.Maximum = int.Parse(StuffUD.Text) * 2;
        }

        private void StudentsUD_Click(object sender, EventArgs e)
        {
            StudentsUD.Maximum = int.Parse(TeachersUD.Text) * 10;
        }

    }
}
