namespace NormasLTI
{

    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTitle = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.Normas = new System.Windows.Forms.RichTextBox();
            this.ConfirmCheck = new System.Windows.Forms.CheckBox();
            this.AcceptRules = new System.Windows.Forms.Button();
            this.SubjectSection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lTISignsDataSet = new NormasLTI.LTISignsDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new NormasLTI.LTISignsDataSetTableAdapters.TeachersTableAdapter();
            this.DisplaySubjects = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lTISignsDataSet1 = new NormasLTI.LTISignsDataSet1();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new NormasLTI.LTISignsDataSet1TableAdapters.SubjectsTableAdapter();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.parameterIsRegistered = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTISignsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTISignsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(265, 35);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(519, 27);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "LABORATORIO DE TECNOLOGIA DE LA INFORMACION";
            this.MainTitle.Click += new System.EventHandler(this.MainTitle_Click);
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(30, 135);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(132, 22);
            this.Subtitle.TabIndex = 1;
            this.Subtitle.Text = "NORMAS DE USO";
            // 
            // Normas
            // 
            this.Normas.BackColor = System.Drawing.Color.White;
            this.Normas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Normas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Normas.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Normas.Location = new System.Drawing.Point(34, 165);
            this.Normas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Normas.Name = "Normas";
            this.Normas.ReadOnly = true;
            this.Normas.ShortcutsEnabled = false;
            this.Normas.Size = new System.Drawing.Size(947, 443);
            this.Normas.TabIndex = 2;
            this.Normas.Text = "";
            this.Normas.WordWrap = false;
            // 
            // ConfirmCheck
            // 
            this.ConfirmCheck.AutoSize = true;
            this.ConfirmCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmCheck.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCheck.Location = new System.Drawing.Point(34, 641);
            this.ConfirmCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmCheck.Name = "ConfirmCheck";
            this.ConfirmCheck.Size = new System.Drawing.Size(711, 22);
            this.ConfirmCheck.TabIndex = 3;
            this.ConfirmCheck.Text = "Estoy de acuerdo con cada una de las Normas de uso del Laboratorio de Tecnología " +
    "de la Información aquí presentes.";
            this.ConfirmCheck.UseVisualStyleBackColor = true;
            // 
            // AcceptRules
            // 
            this.AcceptRules.BackColor = System.Drawing.Color.DarkRed;
            this.AcceptRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptRules.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptRules.ForeColor = System.Drawing.Color.White;
            this.AcceptRules.Location = new System.Drawing.Point(34, 671);
            this.AcceptRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptRules.Name = "AcceptRules";
            this.AcceptRules.Size = new System.Drawing.Size(947, 55);
            this.AcceptRules.TabIndex = 4;
            this.AcceptRules.Text = "ME COMPROMETO";
            this.AcceptRules.UseVisualStyleBackColor = false;
            this.AcceptRules.Click += new System.EventHandler(this.AcceptRules_Click);
            // 
            // SubjectSection
            // 
            this.SubjectSection.BackColor = System.Drawing.Color.Maroon;
            this.SubjectSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectSection.Enabled = false;
            this.SubjectSection.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectSection.ForeColor = System.Drawing.SystemColors.Window;
            this.SubjectSection.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.SubjectSection.Location = new System.Drawing.Point(485, 89);
            this.SubjectSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubjectSection.MaxLength = 2;
            this.SubjectSection.Multiline = true;
            this.SubjectSection.Name = "SubjectSection";
            this.SubjectSection.Size = new System.Drawing.Size(55, 24);
            this.SubjectSection.TabIndex = 6;
            this.SubjectSection.Text = "0";
            this.SubjectSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(879, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Maroon;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teachersBindingSource1, "TeacherID", true));
            this.comboBox1.DataSource = this.teachersBindingSource1;
            this.comboBox1.DisplayMember = "DisplayName";
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(579, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "TeacherID";
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "Teachers";
            this.teachersBindingSource1.DataSource = this.lTISignsDataSet;
            // 
            // lTISignsDataSet
            // 
            this.lTISignsDataSet.DataSetName = "LTISignsDataSet";
            this.lTISignsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.lTISignsDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // DisplaySubjects
            // 
            this.DisplaySubjects.BackColor = System.Drawing.Color.Maroon;
            this.DisplaySubjects.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectsBindingSource1, "SubjectID", true));
            this.DisplaySubjects.DataSource = this.subjectsBindingSource1;
            this.DisplaySubjects.DisplayMember = "SubjectName";
            this.DisplaySubjects.Enabled = false;
            this.DisplaySubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplaySubjects.ForeColor = System.Drawing.SystemColors.Window;
            this.DisplaySubjects.FormattingEnabled = true;
            this.DisplaySubjects.Location = new System.Drawing.Point(144, 89);
            this.DisplaySubjects.Name = "DisplaySubjects";
            this.DisplaySubjects.Size = new System.Drawing.Size(304, 24);
            this.DisplaySubjects.TabIndex = 15;
            this.DisplaySubjects.ValueMember = "SubjectID";
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "Subjects";
            this.subjectsBindingSource1.DataSource = this.lTISignsDataSet1;
            // 
            // lTISignsDataSet1
            // 
            this.lTISignsDataSet1.DataSetName = "LTISignsDataSet1";
            this.lTISignsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.lTISignsDataSet1;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // picLoad
            // 
            this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
            this.picLoad.Location = new System.Drawing.Point(16, 12);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(100, 75);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoad.TabIndex = 16;
            this.picLoad.TabStop = false;
            // 
            // parameterIsRegistered
            // 
            this.parameterIsRegistered.AutoSize = true;
            this.parameterIsRegistered.Location = new System.Drawing.Point(860, 9);
            this.parameterIsRegistered.Name = "parameterIsRegistered";
            this.parameterIsRegistered.Size = new System.Drawing.Size(0, 16);
            this.parameterIsRegistered.TabIndex = 17;
            this.parameterIsRegistered.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Las violaciones a cualquiera de estas normas pueden acarrear sansiones académicas" +
    ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 730);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parameterIsRegistered);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.DisplaySubjects);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubjectSection);
            this.Controls.Add(this.AcceptRules);
            this.Controls.Add(this.ConfirmCheck);
            this.Controls.Add(this.Normas);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.MainTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normas LTI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTISignsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTISignsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.RichTextBox Normas;
        private System.Windows.Forms.CheckBox ConfirmCheck;
        private System.Windows.Forms.Button AcceptRules;
        private System.Windows.Forms.TextBox SubjectSection;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private LTISignsDataSet lTISignsDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private LTISignsDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.ComboBox DisplaySubjects;
        private System.Windows.Forms.BindingSource teachersBindingSource1;
        private LTISignsDataSet1 lTISignsDataSet1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private LTISignsDataSet1TableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Label parameterIsRegistered;
        private System.Windows.Forms.Label label5;
    }
}

