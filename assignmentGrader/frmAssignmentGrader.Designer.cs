namespace assignmentGrader
{
    partial class frmAssignmentGrader
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
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.radCommentsBelowStandard = new System.Windows.Forms.RadioButton();
            this.radCommentsMeetsMinimum = new System.Windows.Forms.RadioButton();
            this.radCommentsMeetsStandards = new System.Windows.Forms.RadioButton();
            this.grpNamingConvention = new System.Windows.Forms.GroupBox();
            this.radNamingBelowStandard = new System.Windows.Forms.RadioButton();
            this.radNamingMeetsMinimumStandard = new System.Windows.Forms.RadioButton();
            this.radNamingMeetsStandard = new System.Windows.Forms.RadioButton();
            this.radTestingBelowStandard = new System.Windows.Forms.RadioButton();
            this.grpTesting = new System.Windows.Forms.GroupBox();
            this.radTestingMeetsMinimumStandard = new System.Windows.Forms.RadioButton();
            this.radTestingMeetsStandard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunctionalErrors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterfaceErrors = new System.Windows.Forms.TextBox();
            this.chkCrashed = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            this.btnGrade = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpComments.SuspendLayout();
            this.grpNamingConvention.SuspendLayout();
            this.grpTesting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.radCommentsBelowStandard);
            this.grpComments.Controls.Add(this.radCommentsMeetsMinimum);
            this.grpComments.Controls.Add(this.radCommentsMeetsStandards);
            this.grpComments.Location = new System.Drawing.Point(13, 13);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(492, 80);
            this.grpComments.TabIndex = 0;
            this.grpComments.TabStop = false;
            this.grpComments.Text = "Comments/Documentation";
            // 
            // radCommentsBelowStandard
            // 
            this.radCommentsBelowStandard.AutoSize = true;
            this.radCommentsBelowStandard.Location = new System.Drawing.Point(365, 34);
            this.radCommentsBelowStandard.Name = "radCommentsBelowStandard";
            this.radCommentsBelowStandard.Size = new System.Drawing.Size(98, 17);
            this.radCommentsBelowStandard.TabIndex = 2;
            this.radCommentsBelowStandard.TabStop = true;
            this.radCommentsBelowStandard.Text = "Below standard";
            this.radCommentsBelowStandard.UseVisualStyleBackColor = true;
            // 
            // radCommentsMeetsMinimum
            // 
            this.radCommentsMeetsMinimum.AutoSize = true;
            this.radCommentsMeetsMinimum.Location = new System.Drawing.Point(170, 34);
            this.radCommentsMeetsMinimum.Name = "radCommentsMeetsMinimum";
            this.radCommentsMeetsMinimum.Size = new System.Drawing.Size(141, 17);
            this.radCommentsMeetsMinimum.TabIndex = 1;
            this.radCommentsMeetsMinimum.TabStop = true;
            this.radCommentsMeetsMinimum.Text = "Meets minimum standard";
            this.radCommentsMeetsMinimum.UseVisualStyleBackColor = true;
            // 
            // radCommentsMeetsStandards
            // 
            this.radCommentsMeetsStandards.AutoSize = true;
            this.radCommentsMeetsStandards.Checked = true;
            this.radCommentsMeetsStandards.Location = new System.Drawing.Point(18, 34);
            this.radCommentsMeetsStandards.Name = "radCommentsMeetsStandards";
            this.radCommentsMeetsStandards.Size = new System.Drawing.Size(100, 17);
            this.radCommentsMeetsStandards.TabIndex = 0;
            this.radCommentsMeetsStandards.TabStop = true;
            this.radCommentsMeetsStandards.Text = "Meets Standard";
            this.radCommentsMeetsStandards.UseVisualStyleBackColor = true;
            // 
            // grpNamingConvention
            // 
            this.grpNamingConvention.Controls.Add(this.radNamingBelowStandard);
            this.grpNamingConvention.Controls.Add(this.radNamingMeetsMinimumStandard);
            this.grpNamingConvention.Controls.Add(this.radNamingMeetsStandard);
            this.grpNamingConvention.Location = new System.Drawing.Point(13, 110);
            this.grpNamingConvention.Name = "grpNamingConvention";
            this.grpNamingConvention.Size = new System.Drawing.Size(492, 80);
            this.grpNamingConvention.TabIndex = 1;
            this.grpNamingConvention.TabStop = false;
            this.grpNamingConvention.Text = "Naming Conventions";
            // 
            // radNamingBelowStandard
            // 
            this.radNamingBelowStandard.AutoSize = true;
            this.radNamingBelowStandard.Location = new System.Drawing.Point(365, 34);
            this.radNamingBelowStandard.Name = "radNamingBelowStandard";
            this.radNamingBelowStandard.Size = new System.Drawing.Size(98, 17);
            this.radNamingBelowStandard.TabIndex = 2;
            this.radNamingBelowStandard.Text = "Below standard";
            this.radNamingBelowStandard.UseVisualStyleBackColor = true;
            // 
            // radNamingMeetsMinimumStandard
            // 
            this.radNamingMeetsMinimumStandard.AutoSize = true;
            this.radNamingMeetsMinimumStandard.Location = new System.Drawing.Point(170, 34);
            this.radNamingMeetsMinimumStandard.Name = "radNamingMeetsMinimumStandard";
            this.radNamingMeetsMinimumStandard.Size = new System.Drawing.Size(141, 17);
            this.radNamingMeetsMinimumStandard.TabIndex = 1;
            this.radNamingMeetsMinimumStandard.Text = "Meets minimum standard";
            this.radNamingMeetsMinimumStandard.UseVisualStyleBackColor = true;
            // 
            // radNamingMeetsStandard
            // 
            this.radNamingMeetsStandard.AutoSize = true;
            this.radNamingMeetsStandard.Checked = true;
            this.radNamingMeetsStandard.Location = new System.Drawing.Point(18, 34);
            this.radNamingMeetsStandard.Name = "radNamingMeetsStandard";
            this.radNamingMeetsStandard.Size = new System.Drawing.Size(100, 17);
            this.radNamingMeetsStandard.TabIndex = 0;
            this.radNamingMeetsStandard.TabStop = true;
            this.radNamingMeetsStandard.Text = "Meets Standard";
            this.radNamingMeetsStandard.UseVisualStyleBackColor = true;
            // 
            // radTestingBelowStandard
            // 
            this.radTestingBelowStandard.AutoSize = true;
            this.radTestingBelowStandard.Location = new System.Drawing.Point(365, 36);
            this.radTestingBelowStandard.Name = "radTestingBelowStandard";
            this.radTestingBelowStandard.Size = new System.Drawing.Size(98, 17);
            this.radTestingBelowStandard.TabIndex = 2;
            this.radTestingBelowStandard.Text = "Below standard";
            this.radTestingBelowStandard.UseVisualStyleBackColor = true;
            // 
            // grpTesting
            // 
            this.grpTesting.Controls.Add(this.radTestingBelowStandard);
            this.grpTesting.Controls.Add(this.radTestingMeetsMinimumStandard);
            this.grpTesting.Controls.Add(this.radTestingMeetsStandard);
            this.grpTesting.Location = new System.Drawing.Point(13, 206);
            this.grpTesting.Name = "grpTesting";
            this.grpTesting.Size = new System.Drawing.Size(492, 80);
            this.grpTesting.TabIndex = 2;
            this.grpTesting.TabStop = false;
            this.grpTesting.Text = "Unit Testing";
            // 
            // radTestingMeetsMinimumStandard
            // 
            this.radTestingMeetsMinimumStandard.AutoSize = true;
            this.radTestingMeetsMinimumStandard.Location = new System.Drawing.Point(170, 36);
            this.radTestingMeetsMinimumStandard.Name = "radTestingMeetsMinimumStandard";
            this.radTestingMeetsMinimumStandard.Size = new System.Drawing.Size(141, 17);
            this.radTestingMeetsMinimumStandard.TabIndex = 1;
            this.radTestingMeetsMinimumStandard.Text = "Meets minimum standard";
            this.radTestingMeetsMinimumStandard.UseVisualStyleBackColor = true;
            // 
            // radTestingMeetsStandard
            // 
            this.radTestingMeetsStandard.AutoSize = true;
            this.radTestingMeetsStandard.Checked = true;
            this.radTestingMeetsStandard.Location = new System.Drawing.Point(18, 36);
            this.radTestingMeetsStandard.Name = "radTestingMeetsStandard";
            this.radTestingMeetsStandard.Size = new System.Drawing.Size(100, 17);
            this.radTestingMeetsStandard.TabIndex = 0;
            this.radTestingMeetsStandard.TabStop = true;
            this.radTestingMeetsStandard.Text = "Meets Standard";
            this.radTestingMeetsStandard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of functional errors:";
            // 
            // txtFunctionalErrors
            // 
            this.txtFunctionalErrors.Location = new System.Drawing.Point(155, 300);
            this.txtFunctionalErrors.Name = "txtFunctionalErrors";
            this.txtFunctionalErrors.Size = new System.Drawing.Size(39, 20);
            this.txtFunctionalErrors.TabIndex = 4;
            this.txtFunctionalErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFunctionalErrors.TextChanged += new System.EventHandler(this.inputChanged);
            this.txtFunctionalErrors.Validating += new System.ComponentModel.CancelEventHandler(this.validating_numericInput);
            this.txtFunctionalErrors.Validated += new System.EventHandler(this.validated_numericInput);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of interface errors:";
            // 
            // txtInterfaceErrors
            // 
            this.txtInterfaceErrors.Location = new System.Drawing.Point(155, 336);
            this.txtInterfaceErrors.Name = "txtInterfaceErrors";
            this.txtInterfaceErrors.Size = new System.Drawing.Size(39, 20);
            this.txtInterfaceErrors.TabIndex = 6;
            this.txtInterfaceErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterfaceErrors.TextChanged += new System.EventHandler(this.inputChanged);
            this.txtInterfaceErrors.Validating += new System.ComponentModel.CancelEventHandler(this.validating_numericInput);
            this.txtInterfaceErrors.Validated += new System.EventHandler(this.validated_numericInput);
            // 
            // chkCrashed
            // 
            this.chkCrashed.AutoSize = true;
            this.chkCrashed.Location = new System.Drawing.Point(13, 380);
            this.chkCrashed.Name = "chkCrashed";
            this.chkCrashed.Size = new System.Drawing.Size(187, 17);
            this.chkCrashed.TabIndex = 7;
            this.chkCrashed.Text = "Program crashed during execution";
            this.chkCrashed.UseVisualStyleBackColor = true;
            this.chkCrashed.CheckedChanged += new System.EventHandler(this.inputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(421, 350);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 37);
            this.lblScore.TabIndex = 9;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkReset
            // 
            this.lnkReset.AutoSize = true;
            this.lnkReset.Location = new System.Drawing.Point(13, 430);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(35, 13);
            this.lnkReset.TabIndex = 10;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset";
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(430, 420);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 11;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmAssignmentGrader
            // 
            this.AcceptButton = this.btnGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(517, 455);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.lnkReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCrashed);
            this.Controls.Add(this.txtInterfaceErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFunctionalErrors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTesting);
            this.Controls.Add(this.grpNamingConvention);
            this.Controls.Add(this.grpComments);
            this.MaximizeBox = false;
            this.Name = "frmAssignmentGrader";
            this.ShowIcon = false;
            this.Text = "AssignmentGrader";
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grpNamingConvention.ResumeLayout(false);
            this.grpNamingConvention.PerformLayout();
            this.grpTesting.ResumeLayout(false);
            this.grpTesting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.RadioButton radCommentsBelowStandard;
        private System.Windows.Forms.RadioButton radCommentsMeetsMinimum;
        private System.Windows.Forms.RadioButton radCommentsMeetsStandards;
        private System.Windows.Forms.GroupBox grpNamingConvention;
        private System.Windows.Forms.RadioButton radNamingMeetsStandard;
        private System.Windows.Forms.RadioButton radNamingBelowStandard;
        private System.Windows.Forms.RadioButton radNamingMeetsMinimumStandard;
        private System.Windows.Forms.RadioButton radTestingBelowStandard;
        private System.Windows.Forms.GroupBox grpTesting;
        private System.Windows.Forms.RadioButton radTestingMeetsMinimumStandard;
        private System.Windows.Forms.RadioButton radTestingMeetsStandard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunctionalErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterfaceErrors;
        private System.Windows.Forms.CheckBox chkCrashed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.LinkLabel lnkReset;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

