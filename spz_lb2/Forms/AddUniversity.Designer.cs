namespace spz_lb2
{
    partial class AddUniversity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeachersUD = new System.Windows.Forms.NumericUpDown();
            this.StudentsUD = new System.Windows.Forms.NumericUpDown();
            this.lbTeachers = new System.Windows.Forms.Label();
            this.lbStudents = new System.Windows.Forms.Label();
            this.lbStuff = new System.Windows.Forms.Label();
            this.StuffUD = new System.Windows.Forms.NumericUpDown();
            this.lbAuditory = new System.Windows.Forms.Label();
            this.AuditoryUD = new System.Windows.Forms.NumericUpDown();
            this.FacultiesUD = new System.Windows.Forms.NumericUpDown();
            this.LaboratoryUD = new System.Windows.Forms.NumericUpDown();
            this.lbLaboratory = new System.Windows.Forms.Label();
            this.lbFaculties = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuffUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultiesUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersUD
            // 
            this.TeachersUD.Location = new System.Drawing.Point(294, 67);
            this.TeachersUD.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TeachersUD.Name = "TeachersUD";
            this.TeachersUD.Size = new System.Drawing.Size(160, 23);
            this.TeachersUD.TabIndex = 0;
            // 
            // StudentsUD
            // 
            this.StudentsUD.Location = new System.Drawing.Point(294, 111);
            this.StudentsUD.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsUD.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.StudentsUD.Name = "StudentsUD";
            this.StudentsUD.Size = new System.Drawing.Size(160, 23);
            this.StudentsUD.TabIndex = 1;
            // 
            // lbTeachers
            // 
            this.lbTeachers.AutoSize = true;
            this.lbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTeachers.Location = new System.Drawing.Point(61, 67);
            this.lbTeachers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(132, 20);
            this.lbTeachers.TabIndex = 2;
            this.lbTeachers.Text = "Преподаватели";
            this.lbTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStudents
            // 
            this.lbStudents.AutoSize = true;
            this.lbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudents.Location = new System.Drawing.Point(61, 114);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(85, 20);
            this.lbStudents.TabIndex = 3;
            this.lbStudents.Text = "Студенты";
            this.lbStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStuff
            // 
            this.lbStuff.AutoSize = true;
            this.lbStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStuff.Location = new System.Drawing.Point(61, 157);
            this.lbStuff.Name = "lbStuff";
            this.lbStuff.Size = new System.Drawing.Size(100, 20);
            this.lbStuff.TabIndex = 4;
            this.lbStuff.Text = "Сотрудники";
            this.lbStuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StuffUD
            // 
            this.StuffUD.Location = new System.Drawing.Point(294, 154);
            this.StuffUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StuffUD.Name = "StuffUD";
            this.StuffUD.Size = new System.Drawing.Size(160, 23);
            this.StuffUD.TabIndex = 5;
            // 
            // lbAuditory
            // 
            this.lbAuditory.AutoSize = true;
            this.lbAuditory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuditory.Location = new System.Drawing.Point(61, 202);
            this.lbAuditory.Name = "lbAuditory";
            this.lbAuditory.Size = new System.Drawing.Size(92, 20);
            this.lbAuditory.TabIndex = 6;
            this.lbAuditory.Text = "Аудитории";
            this.lbAuditory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuditoryUD
            // 
            this.AuditoryUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditoryUD.Location = new System.Drawing.Point(294, 199);
            this.AuditoryUD.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AuditoryUD.Name = "AuditoryUD";
            this.AuditoryUD.Size = new System.Drawing.Size(160, 23);
            this.AuditoryUD.TabIndex = 7;
            // 
            // FacultiesUD
            // 
            this.FacultiesUD.Location = new System.Drawing.Point(294, 287);
            this.FacultiesUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FacultiesUD.Name = "FacultiesUD";
            this.FacultiesUD.Size = new System.Drawing.Size(160, 23);
            this.FacultiesUD.TabIndex = 8;
            // 
            // LaboratoryUD
            // 
            this.LaboratoryUD.Location = new System.Drawing.Point(294, 243);
            this.LaboratoryUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LaboratoryUD.Name = "LaboratoryUD";
            this.LaboratoryUD.Size = new System.Drawing.Size(160, 23);
            this.LaboratoryUD.TabIndex = 9;
            // 
            // lbLaboratory
            // 
            this.lbLaboratory.AutoSize = true;
            this.lbLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLaboratory.Location = new System.Drawing.Point(61, 246);
            this.lbLaboratory.Name = "lbLaboratory";
            this.lbLaboratory.Size = new System.Drawing.Size(111, 20);
            this.lbLaboratory.TabIndex = 10;
            this.lbLaboratory.Text = "Лаборатории";
            this.lbLaboratory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFaculties
            // 
            this.lbFaculties.AutoSize = true;
            this.lbFaculties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFaculties.Location = new System.Drawing.Point(61, 290);
            this.lbFaculties.Name = "lbFaculties";
            this.lbFaculties.Size = new System.Drawing.Size(105, 20);
            this.lbFaculties.TabIndex = 11;
            this.lbFaculties.Text = "Факультеты";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(133, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(97, 24);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Название";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(236, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(129, 26);
            this.tbName.TabIndex = 13;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(183, 332);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 34);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Подтвердить";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // AddUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 378);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbFaculties);
            this.Controls.Add(this.lbLaboratory);
            this.Controls.Add(this.LaboratoryUD);
            this.Controls.Add(this.FacultiesUD);
            this.Controls.Add(this.AuditoryUD);
            this.Controls.Add(this.lbAuditory);
            this.Controls.Add(this.StuffUD);
            this.Controls.Add(this.lbStuff);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.lbTeachers);
            this.Controls.Add(this.StudentsUD);
            this.Controls.Add(this.TeachersUD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUniversity";
            this.Text = "AddUniversity";
            ((System.ComponentModel.ISupportInitialize)(this.TeachersUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuffUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoryUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultiesUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TeachersUD;
        private System.Windows.Forms.NumericUpDown StudentsUD;
        private System.Windows.Forms.Label lbTeachers;
        private System.Windows.Forms.Label lbStudents;
        private System.Windows.Forms.Label lbStuff;
        private System.Windows.Forms.NumericUpDown StuffUD;
        private System.Windows.Forms.Label lbAuditory;
        private System.Windows.Forms.NumericUpDown AuditoryUD;
        private System.Windows.Forms.NumericUpDown FacultiesUD;
        private System.Windows.Forms.NumericUpDown LaboratoryUD;
        private System.Windows.Forms.Label lbLaboratory;
        private System.Windows.Forms.Label lbFaculties;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btAdd;
    }
}