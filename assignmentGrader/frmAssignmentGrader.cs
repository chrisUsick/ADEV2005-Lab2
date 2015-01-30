using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADEV2005Lab2;

namespace assignmentGrader
{
    public partial class frmAssignmentGrader : Form
    {
        public frmAssignmentGrader()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //Score score = new Score();
                Score.ItemScore comments = getItemScore(grpComments),
                                naming   = getItemScore(grpNamingConvention),
                                testing  = getItemScore(grpTesting);
                Score score = new Score(comments,
                                        naming,
                                        testing,
                                        chkCrashed.Checked,
                                        int.Parse(txtFunctionalErrors.Text),
                                        int.Parse(txtInterfaceErrors.Text));

                lblScore.Text = ((int)score.CalculateScore()).ToString();
            }
        }

        private Score.ItemScore getItemScore(GroupBox grpBox)
        {
            Score.ItemScore score = new Score.ItemScore();

            foreach (Control control in grpBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        switch (radio.Text)
                        {
                            case "Meets Standard":
                                score = Score.ItemScore.MeetsStandard;
                                break;
                            case "Meets minimum standard":
                                score = Score.ItemScore.MeetsMinimumStandard;
                                break;
                            case "Below standard":
                                score = Score.ItemScore.BelowStandard;
                                break;
                        }
                    }
                }
            }

            return score;
        }

        private void validating_numericInput(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;

            int maybeNumber;
            if (!int.TryParse(input.Text, out maybeNumber))
            {
                errorProvider.SetError(input, "Value must be Numeric");
                e.Cancel = true;
            }
            else if (maybeNumber < 0)
            {
                errorProvider.SetError(input, "Value must be greater than or equal to zero");
                e.Cancel = true;
            }
        }

        private void validated_numericInput(object sender, EventArgs e)
        {
            errorProvider.SetError((TextBox)sender, "");
        }

        private void inputChanged(object sender, EventArgs e)
        {
            lblScore.Text = "";
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult clear = MessageBox.Show("Reset Form?", 
                                                "",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.None,
                                                MessageBoxDefaultButton.Button2);
            if (clear == DialogResult.OK)
            {
                radCommentsMeetsStandards.Checked = true;
                radNamingMeetsStandard.Checked = true;
                radTestingMeetsStandard.Checked = true;
                txtFunctionalErrors.Clear();
                txtInterfaceErrors.Clear();
                chkCrashed.Checked = false;
            }
        }

    }
}
