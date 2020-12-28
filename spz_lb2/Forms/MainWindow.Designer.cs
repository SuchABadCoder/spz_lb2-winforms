namespace spz_lb2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Constructor = new System.Windows.Forms.Button();
            this.cbxUniversities = new System.Windows.Forms.ComboBox();
            this.lbChoise = new System.Windows.Forms.Label();
            this.btKickStudent = new System.Windows.Forms.Button();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btAddAuditory = new System.Windows.Forms.Button();
            this.btAddLaboratory = new System.Windows.Forms.Button();
            this.btHireTeacher = new System.Windows.Forms.Button();
            this.btKickTeacher = new System.Windows.Forms.Button();
            this.btHireStuff = new System.Windows.Forms.Button();
            this.btKickStuff = new System.Windows.Forms.Button();
            this.btCombine = new System.Windows.Forms.Button();
            this.btClone = new System.Windows.Forms.Button();
            this.lbStudentAmount = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.NumberUD = new System.Windows.Forms.NumericUpDown();
            this.btAddStudentSubmit = new System.Windows.Forms.Button();
            this.btKickStudentSubmit = new System.Windows.Forms.Button();
            this.btAddAuditorySubmit = new System.Windows.Forms.Button();
            this.lbAuditoryAmount = new System.Windows.Forms.Label();
            this.btAddLaboratorySubmit = new System.Windows.Forms.Button();
            this.lbLaboratoryAmount = new System.Windows.Forms.Label();
            this.lbTeachersAmount = new System.Windows.Forms.Label();
            this.lbStuffAmount = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.lbFacultyAmount = new System.Windows.Forms.Label();
            this.btHireTeacherSubmit = new System.Windows.Forms.Button();
            this.btKickTeacherSubmit = new System.Windows.Forms.Button();
            this.btHireStuffSubmit = new System.Windows.Forms.Button();
            this.btKickStuffSubmit = new System.Windows.Forms.Button();
            this.cbxU1 = new System.Windows.Forms.ComboBox();
            this.cbxU2 = new System.Windows.Forms.ComboBox();
            this.lbPlus = new System.Windows.Forms.Label();
            this.btCombineSubmit = new System.Windows.Forms.Button();
            this.universitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxClone = new System.Windows.Forms.ComboBox();
            this.btCloneSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Constructor
            // 
            this.Constructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Constructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Constructor.Location = new System.Drawing.Point(132, 33);
            this.Constructor.Name = "Constructor";
            this.Constructor.Size = new System.Drawing.Size(215, 30);
            this.Constructor.TabIndex = 0;
            this.Constructor.Text = "Добавить университет";
            this.Constructor.UseVisualStyleBackColor = true;
            // 
            // cbxUniversities
            // 
            this.cbxUniversities.FormattingEnabled = true;
            this.cbxUniversities.Location = new System.Drawing.Point(229, 230);
            this.cbxUniversities.Name = "cbxUniversities";
            this.cbxUniversities.Size = new System.Drawing.Size(152, 21);
            this.cbxUniversities.TabIndex = 1;
            // 
            // lbChoise
            // 
            this.lbChoise.AutoSize = true;
            this.lbChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChoise.Location = new System.Drawing.Point(84, 231);
            this.lbChoise.Name = "lbChoise";
            this.lbChoise.Size = new System.Drawing.Size(112, 20);
            this.lbChoise.TabIndex = 2;
            this.lbChoise.Text = "Выбрать ВУЗ";
            this.lbChoise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btKickStudent
            // 
            this.btKickStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btKickStudent.Location = new System.Drawing.Point(260, 12);
            this.btKickStudent.Name = "btKickStudent";
            this.btKickStudent.Size = new System.Drawing.Size(192, 28);
            this.btKickStudent.TabIndex = 3;
            this.btKickStudent.Text = "Отчисление";
            this.btKickStudent.UseVisualStyleBackColor = true;
            this.btKickStudent.Visible = false;
            // 
            // btAddStudent
            // 
            this.btAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddStudent.Location = new System.Drawing.Point(260, 48);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(192, 28);
            this.btAddStudent.TabIndex = 4;
            this.btAddStudent.Text = "Зачисление";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Visible = false;
            // 
            // btAddAuditory
            // 
            this.btAddAuditory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddAuditory.Location = new System.Drawing.Point(260, 82);
            this.btAddAuditory.Name = "btAddAuditory";
            this.btAddAuditory.Size = new System.Drawing.Size(192, 28);
            this.btAddAuditory.TabIndex = 5;
            this.btAddAuditory.Text = "Добавить аудиторию";
            this.btAddAuditory.UseVisualStyleBackColor = true;
            this.btAddAuditory.Visible = false;
            // 
            // btAddLaboratory
            // 
            this.btAddLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddLaboratory.Location = new System.Drawing.Point(260, 116);
            this.btAddLaboratory.Name = "btAddLaboratory";
            this.btAddLaboratory.Size = new System.Drawing.Size(192, 27);
            this.btAddLaboratory.TabIndex = 6;
            this.btAddLaboratory.Text = "Добавить лабораторию";
            this.btAddLaboratory.UseVisualStyleBackColor = true;
            this.btAddLaboratory.Visible = false;
            // 
            // btHireTeacher
            // 
            this.btHireTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btHireTeacher.Location = new System.Drawing.Point(260, 149);
            this.btHireTeacher.Name = "btHireTeacher";
            this.btHireTeacher.Size = new System.Drawing.Size(192, 27);
            this.btHireTeacher.TabIndex = 7;
            this.btHireTeacher.Text = "Нанять преподавателя";
            this.btHireTeacher.UseVisualStyleBackColor = true;
            this.btHireTeacher.Visible = false;
            // 
            // btKickTeacher
            // 
            this.btKickTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btKickTeacher.Location = new System.Drawing.Point(260, 182);
            this.btKickTeacher.Name = "btKickTeacher";
            this.btKickTeacher.Size = new System.Drawing.Size(192, 27);
            this.btKickTeacher.TabIndex = 8;
            this.btKickTeacher.Text = "Уволить преподавателя";
            this.btKickTeacher.UseVisualStyleBackColor = true;
            this.btKickTeacher.Visible = false;
            // 
            // btHireStuff
            // 
            this.btHireStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btHireStuff.Location = new System.Drawing.Point(260, 215);
            this.btHireStuff.Name = "btHireStuff";
            this.btHireStuff.Size = new System.Drawing.Size(192, 27);
            this.btHireStuff.TabIndex = 9;
            this.btHireStuff.Text = "Нанять сотрудника";
            this.btHireStuff.UseVisualStyleBackColor = true;
            this.btHireStuff.Visible = false;
            // 
            // btKickStuff
            // 
            this.btKickStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btKickStuff.Location = new System.Drawing.Point(260, 248);
            this.btKickStuff.Name = "btKickStuff";
            this.btKickStuff.Size = new System.Drawing.Size(192, 27);
            this.btKickStuff.TabIndex = 10;
            this.btKickStuff.Text = "Уволить сотрудника";
            this.btKickStuff.UseVisualStyleBackColor = true;
            this.btKickStuff.Visible = false;
            // 
            // btCombine
            // 
            this.btCombine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCombine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCombine.Location = new System.Drawing.Point(132, 92);
            this.btCombine.Name = "btCombine";
            this.btCombine.Size = new System.Drawing.Size(215, 30);
            this.btCombine.TabIndex = 11;
            this.btCombine.Text = "Объеденить";
            this.btCombine.UseVisualStyleBackColor = true;
            // 
            // btClone
            // 
            this.btClone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClone.Location = new System.Drawing.Point(132, 158);
            this.btClone.Name = "btClone";
            this.btClone.Size = new System.Drawing.Size(215, 30);
            this.btClone.TabIndex = 12;
            this.btClone.Text = "Создать копию";
            this.btClone.UseVisualStyleBackColor = true;
            // 
            // lbStudentAmount
            // 
            this.lbStudentAmount.AutoSize = true;
            this.lbStudentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudentAmount.Location = new System.Drawing.Point(62, 53);
            this.lbStudentAmount.Name = "lbStudentAmount";
            this.lbStudentAmount.Size = new System.Drawing.Size(134, 20);
            this.lbStudentAmount.TabIndex = 13;
            this.lbStudentAmount.Text = "lbStudentAmount";
            this.lbStudentAmount.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(101, 22);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "lbName";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Visible = false;
            // 
            // NumberUD
            // 
            this.NumberUD.Location = new System.Drawing.Point(260, 82);
            this.NumberUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberUD.Name = "NumberUD";
            this.NumberUD.Size = new System.Drawing.Size(98, 20);
            this.NumberUD.TabIndex = 15;
            this.NumberUD.Visible = false;
            // 
            // btAddStudentSubmit
            // 
            this.btAddStudentSubmit.Location = new System.Drawing.Point(377, 82);
            this.btAddStudentSubmit.Name = "btAddStudentSubmit";
            this.btAddStudentSubmit.Size = new System.Drawing.Size(75, 20);
            this.btAddStudentSubmit.TabIndex = 16;
            this.btAddStudentSubmit.Text = "OK";
            this.btAddStudentSubmit.UseVisualStyleBackColor = true;
            this.btAddStudentSubmit.Visible = false;
            // 
            // btKickStudentSubmit
            // 
            this.btKickStudentSubmit.Location = new System.Drawing.Point(377, 46);
            this.btKickStudentSubmit.Name = "btKickStudentSubmit";
            this.btKickStudentSubmit.Size = new System.Drawing.Size(75, 20);
            this.btKickStudentSubmit.TabIndex = 17;
            this.btKickStudentSubmit.Text = "OK";
            this.btKickStudentSubmit.UseVisualStyleBackColor = true;
            this.btKickStudentSubmit.Visible = false;
            // 
            // btAddAuditorySubmit
            // 
            this.btAddAuditorySubmit.Location = new System.Drawing.Point(377, 116);
            this.btAddAuditorySubmit.Name = "btAddAuditorySubmit";
            this.btAddAuditorySubmit.Size = new System.Drawing.Size(75, 20);
            this.btAddAuditorySubmit.TabIndex = 18;
            this.btAddAuditorySubmit.Text = "OK";
            this.btAddAuditorySubmit.UseVisualStyleBackColor = true;
            this.btAddAuditorySubmit.Visible = false;
            // 
            // lbAuditoryAmount
            // 
            this.lbAuditoryAmount.AutoSize = true;
            this.lbAuditoryAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuditoryAmount.Location = new System.Drawing.Point(62, 90);
            this.lbAuditoryAmount.Name = "lbAuditoryAmount";
            this.lbAuditoryAmount.Size = new System.Drawing.Size(135, 20);
            this.lbAuditoryAmount.TabIndex = 19;
            this.lbAuditoryAmount.Text = "lbAuditoryAmount";
            this.lbAuditoryAmount.Visible = false;
            // 
            // btAddLaboratorySubmit
            // 
            this.btAddLaboratorySubmit.Location = new System.Drawing.Point(377, 149);
            this.btAddLaboratorySubmit.Name = "btAddLaboratorySubmit";
            this.btAddLaboratorySubmit.Size = new System.Drawing.Size(75, 20);
            this.btAddLaboratorySubmit.TabIndex = 20;
            this.btAddLaboratorySubmit.Text = "OK";
            this.btAddLaboratorySubmit.UseVisualStyleBackColor = true;
            this.btAddLaboratorySubmit.Visible = false;
            // 
            // lbLaboratoryAmount
            // 
            this.lbLaboratoryAmount.AutoSize = true;
            this.lbLaboratoryAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLaboratoryAmount.Location = new System.Drawing.Point(62, 125);
            this.lbLaboratoryAmount.Name = "lbLaboratoryAmount";
            this.lbLaboratoryAmount.Size = new System.Drawing.Size(153, 20);
            this.lbLaboratoryAmount.TabIndex = 21;
            this.lbLaboratoryAmount.Text = "lbLaboratoryAmount";
            this.lbLaboratoryAmount.Visible = false;
            // 
            // lbTeachersAmount
            // 
            this.lbTeachersAmount.AutoSize = true;
            this.lbTeachersAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTeachersAmount.Location = new System.Drawing.Point(62, 163);
            this.lbTeachersAmount.Name = "lbTeachersAmount";
            this.lbTeachersAmount.Size = new System.Drawing.Size(143, 20);
            this.lbTeachersAmount.TabIndex = 22;
            this.lbTeachersAmount.Text = "lbTeachersAmount";
            this.lbTeachersAmount.Visible = false;
            // 
            // lbStuffAmount
            // 
            this.lbStuffAmount.AutoSize = true;
            this.lbStuffAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStuffAmount.Location = new System.Drawing.Point(62, 200);
            this.lbStuffAmount.Name = "lbStuffAmount";
            this.lbStuffAmount.Size = new System.Drawing.Size(112, 20);
            this.lbStuffAmount.TabIndex = 23;
            this.lbStuffAmount.Text = "lbStuffAmount";
            this.lbStuffAmount.Visible = false;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(26, 266);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(106, 27);
            this.btBack.TabIndex = 24;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Visible = false;
            // 
            // lbFacultyAmount
            // 
            this.lbFacultyAmount.AutoSize = true;
            this.lbFacultyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFacultyAmount.Location = new System.Drawing.Point(62, 237);
            this.lbFacultyAmount.Name = "lbFacultyAmount";
            this.lbFacultyAmount.Size = new System.Drawing.Size(128, 20);
            this.lbFacultyAmount.TabIndex = 25;
            this.lbFacultyAmount.Text = "lbFacultyAmount";
            this.lbFacultyAmount.Visible = false;
            // 
            // btHireTeacherSubmit
            // 
            this.btHireTeacherSubmit.Location = new System.Drawing.Point(377, 182);
            this.btHireTeacherSubmit.Name = "btHireTeacherSubmit";
            this.btHireTeacherSubmit.Size = new System.Drawing.Size(75, 20);
            this.btHireTeacherSubmit.TabIndex = 26;
            this.btHireTeacherSubmit.Text = "OK";
            this.btHireTeacherSubmit.UseVisualStyleBackColor = true;
            this.btHireTeacherSubmit.Visible = false;
            // 
            // btKickTeacherSubmit
            // 
            this.btKickTeacherSubmit.Location = new System.Drawing.Point(377, 215);
            this.btKickTeacherSubmit.Name = "btKickTeacherSubmit";
            this.btKickTeacherSubmit.Size = new System.Drawing.Size(75, 20);
            this.btKickTeacherSubmit.TabIndex = 27;
            this.btKickTeacherSubmit.Text = "OK";
            this.btKickTeacherSubmit.UseVisualStyleBackColor = true;
            this.btKickTeacherSubmit.Visible = false;
            // 
            // btHireStuffSubmit
            // 
            this.btHireStuffSubmit.Location = new System.Drawing.Point(377, 248);
            this.btHireStuffSubmit.Name = "btHireStuffSubmit";
            this.btHireStuffSubmit.Size = new System.Drawing.Size(75, 20);
            this.btHireStuffSubmit.TabIndex = 28;
            this.btHireStuffSubmit.Text = "OK";
            this.btHireStuffSubmit.UseVisualStyleBackColor = true;
            this.btHireStuffSubmit.Visible = false;
            // 
            // btKickStuffSubmit
            // 
            this.btKickStuffSubmit.Location = new System.Drawing.Point(377, 281);
            this.btKickStuffSubmit.Name = "btKickStuffSubmit";
            this.btKickStuffSubmit.Size = new System.Drawing.Size(75, 20);
            this.btKickStuffSubmit.TabIndex = 29;
            this.btKickStuffSubmit.Text = "OK";
            this.btKickStuffSubmit.UseVisualStyleBackColor = true;
            this.btKickStuffSubmit.Visible = false;
            // 
            // cbxU1
            // 
            this.cbxU1.FormattingEnabled = true;
            this.cbxU1.Location = new System.Drawing.Point(66, 128);
            this.cbxU1.Name = "cbxU1";
            this.cbxU1.Size = new System.Drawing.Size(152, 21);
            this.cbxU1.TabIndex = 30;
            this.cbxU1.Visible = false;
            // 
            // cbxU2
            // 
            this.cbxU2.FormattingEnabled = true;
            this.cbxU2.Location = new System.Drawing.Point(249, 127);
            this.cbxU2.Name = "cbxU2";
            this.cbxU2.Size = new System.Drawing.Size(152, 21);
            this.cbxU2.TabIndex = 31;
            this.cbxU2.Visible = false;
            // 
            // lbPlus
            // 
            this.lbPlus.AutoSize = true;
            this.lbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlus.Location = new System.Drawing.Point(226, 130);
            this.lbPlus.Name = "lbPlus";
            this.lbPlus.Size = new System.Drawing.Size(17, 18);
            this.lbPlus.TabIndex = 32;
            this.lbPlus.Text = "+";
            this.lbPlus.Visible = false;
            // 
            // btCombineSubmit
            // 
            this.btCombineSubmit.Location = new System.Drawing.Point(12, 128);
            this.btCombineSubmit.Name = "btCombineSubmit";
            this.btCombineSubmit.Size = new System.Drawing.Size(43, 20);
            this.btCombineSubmit.TabIndex = 33;
            this.btCombineSubmit.Text = "OK";
            this.btCombineSubmit.UseVisualStyleBackColor = true;
            this.btCombineSubmit.Visible = false;
            // 
            // universitiesBindingSource
            // 
            this.universitiesBindingSource.DataSource = typeof(spz_lb2.Universities);
            // 
            // cbxClone
            // 
            this.cbxClone.FormattingEnabled = true;
            this.cbxClone.Location = new System.Drawing.Point(195, 194);
            this.cbxClone.Name = "cbxClone";
            this.cbxClone.Size = new System.Drawing.Size(152, 21);
            this.cbxClone.TabIndex = 34;
            this.cbxClone.Visible = false;
            // 
            // btCloneSubmit
            // 
            this.btCloneSubmit.Location = new System.Drawing.Point(132, 195);
            this.btCloneSubmit.Name = "btCloneSubmit";
            this.btCloneSubmit.Size = new System.Drawing.Size(43, 20);
            this.btCloneSubmit.TabIndex = 35;
            this.btCloneSubmit.Text = "OK";
            this.btCloneSubmit.UseVisualStyleBackColor = true;
            this.btCloneSubmit.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 305);
            this.Controls.Add(this.btCloneSubmit);
            this.Controls.Add(this.cbxClone);
            this.Controls.Add(this.btCombineSubmit);
            this.Controls.Add(this.lbPlus);
            this.Controls.Add(this.cbxU2);
            this.Controls.Add(this.cbxU1);
            this.Controls.Add(this.btKickStuffSubmit);
            this.Controls.Add(this.btHireStuffSubmit);
            this.Controls.Add(this.btKickTeacherSubmit);
            this.Controls.Add(this.btHireTeacherSubmit);
            this.Controls.Add(this.lbFacultyAmount);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbStuffAmount);
            this.Controls.Add(this.lbTeachersAmount);
            this.Controls.Add(this.lbLaboratoryAmount);
            this.Controls.Add(this.btAddLaboratorySubmit);
            this.Controls.Add(this.lbAuditoryAmount);
            this.Controls.Add(this.btAddAuditorySubmit);
            this.Controls.Add(this.btKickStudentSubmit);
            this.Controls.Add(this.btAddStudentSubmit);
            this.Controls.Add(this.NumberUD);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbStudentAmount);
            this.Controls.Add(this.btAddLaboratory);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.btKickStudent);
            this.Controls.Add(this.Constructor);
            this.Controls.Add(this.btAddAuditory);
            this.Controls.Add(this.btHireTeacher);
            this.Controls.Add(this.btKickTeacher);
            this.Controls.Add(this.btHireStuff);
            this.Controls.Add(this.btKickStuff);
            this.Controls.Add(this.btCombine);
            this.Controls.Add(this.cbxUniversities);
            this.Controls.Add(this.btClone);
            this.Controls.Add(this.lbChoise);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "spz_lb2";
            ((System.ComponentModel.ISupportInitialize)(this.NumberUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Constructor;
        private System.Windows.Forms.ComboBox cbxUniversities;
        private System.Windows.Forms.BindingSource universitiesBindingSource;
        private System.Windows.Forms.Label lbChoise;
        private System.Windows.Forms.Button btKickStudent;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btAddAuditory;
        private System.Windows.Forms.Button btAddLaboratory;
        private System.Windows.Forms.Button btHireTeacher;
        private System.Windows.Forms.Button btKickTeacher;
        private System.Windows.Forms.Button btHireStuff;
        private System.Windows.Forms.Button btKickStuff;
        private System.Windows.Forms.Button btCombine;
        private System.Windows.Forms.Button btClone;
        private System.Windows.Forms.Label lbStudentAmount;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.NumericUpDown NumberUD;
        private System.Windows.Forms.Button btAddStudentSubmit;
        private System.Windows.Forms.Button btKickStudentSubmit;
        private System.Windows.Forms.Button btAddAuditorySubmit;
        private System.Windows.Forms.Label lbAuditoryAmount;
        private System.Windows.Forms.Button btAddLaboratorySubmit;
        private System.Windows.Forms.Label lbLaboratoryAmount;
        private System.Windows.Forms.Label lbTeachersAmount;
        private System.Windows.Forms.Label lbStuffAmount;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbFacultyAmount;
        private System.Windows.Forms.Button btHireTeacherSubmit;
        private System.Windows.Forms.Button btKickTeacherSubmit;
        private System.Windows.Forms.Button btHireStuffSubmit;
        private System.Windows.Forms.Button btKickStuffSubmit;
        private System.Windows.Forms.ComboBox cbxU1;
        private System.Windows.Forms.ComboBox cbxU2;
        private System.Windows.Forms.Label lbPlus;
        private System.Windows.Forms.Button btCombineSubmit;
        private System.Windows.Forms.ComboBox cbxClone;
        private System.Windows.Forms.Button btCloneSubmit;
    }
}

