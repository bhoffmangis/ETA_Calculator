// Version 5 adds Tool Tips
// Version 6 adds Menu bar (Help > About)
// Version 7 need to add input validation for
//           invalid entry as well as non-entry
// Version 8 adds input validation
//           modifys menu bar item ("Help" changed to "About")

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETA_Calculator
{
    public partial class ETA_Calculator : Form
    {
        public ETA_Calculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startHour, startMin, endHour, endMin, etaHour, etaMin;
            float etaDecimal;
            int totalStartMin, totalEndMin, differenceMin;
            bool areValidInputs;

            areValidInputs = SetInputs(out startHour, out startMin, out endHour, out endMin);

            if (areValidInputs == true)
            {
                if (rdoStartAM.Checked)
                {
                    if (startHour == 12)
                        startHour = 0;
                }

                else // (rdoStartPM.Checked)
                {
                    if (startHour == 12)
                        startHour = 12;
                    else
                        startHour += 12;
                }

                if (rdoEndAM.Checked)
                {
                    if (endHour == 12)
                        endHour = 0;
                }

                else // (rdoEndPM.Checked)
                {
                    if (endHour == 12)
                        endHour = 12;
                    else
                        endHour += 12;
                }

                /////////////////////////////////////////////////////////////////////////

                totalStartMin = (startHour * 60) + startMin;
                totalEndMin = (endHour * 60) + endMin;

                if (rdoStartPM.Checked && rdoEndAM.Checked)
                {
                    differenceMin = totalEndMin - totalStartMin;
                    etaHour = differenceMin / 60;
                    etaHour += 24;
                    etaMin = differenceMin % 60;
                    etaDecimal = ((float)differenceMin / 60) + 24;
                }

                else if ((rdoStartAM.Checked && rdoEndAM.Checked && endHour < startHour) ||
                        (rdoStartPM.Checked && rdoEndPM.Checked && endHour < startHour))
                {
                    differenceMin = totalEndMin - totalStartMin;
                    etaHour = differenceMin / 60;
                    etaHour += 24;
                    etaMin = differenceMin % 60;
                    etaDecimal = ((float)differenceMin / 60) + 24;

                    if (endMin > startMin || endMin < startMin)
                    {
                        etaMin += 60;
                        etaHour -= 1;
                    }
                }

                else if ((rdoStartAM.Checked && rdoEndAM.Checked && endHour == startHour &&
                          startMin > endMin) ||
                         (rdoStartPM.Checked && rdoEndPM.Checked && endHour == startHour &&
                          startMin > endMin))
                {
                    differenceMin = totalEndMin - totalStartMin;
                    etaHour = differenceMin / 60;
                    etaHour += 24;
                    etaMin = differenceMin % 60;
                    etaDecimal = ((float)differenceMin / 60) + 24;

                    if (endMin > startMin || endMin < startMin)
                    {
                        etaMin += 60;
                        etaHour -= 1;
                    }
                }

                else
                {
                    differenceMin = totalEndMin - totalStartMin;
                    etaHour = differenceMin / 60;
                    etaMin = differenceMin % 60;
                    etaDecimal = (float)differenceMin / 60;
                }

                /////////////////////////////////////////////////////////////////////////

                lblETAHour.Text = etaHour.ToString("d2");
                lblETAMin.Text = etaMin.ToString("d2");
                lblDecimal.Text = etaDecimal.ToString("f2") + " hours";
            }
        }

        //--------------------------------------------------------------

        private bool SetInputs(out int sH, out int sM, out int eH, out int eM)
        {
            bool allValid = true;
            bool sHValid;
            bool sMValid;
            bool eHValid;
            bool eMValid;

            sHValid = int.TryParse(txtStartHour.Text, out sH) && (sH > 0) && (sH <= 12);
            sMValid = int.TryParse(txtStartMin.Text, out sM) && (sM >= 0) && (sM <= 59);
            eHValid = int.TryParse(txtEndHour.Text, out eH) && (eH > 0) && (eH <= 12);
            eMValid = int.TryParse(txtEndMin.Text, out eM) && (eM >= 0) && (eM <= 59);

            if (sHValid == false)
            {
                allValid = false;
                MessageBox.Show("Start Hour must be a non-negative number\n" +
                    "between 1 and 12 (inclusive)!",
                    "Invalid Start Hour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartHour.Focus();
                txtStartHour.SelectAll();
            }

            else if (sMValid == false)
            {
                allValid = false;
                MessageBox.Show("Start Minute must be a non-negative number\n" +
                    "between 00 and 59 (inclusive)!",
                    "Invalid Start Minute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartMin.Focus();
                txtStartMin.SelectAll();
            }

            else if (eHValid == false)
            {
                allValid = false;
                MessageBox.Show("End Hour be a non-negative number\n" +
                    "between 1 and 12 (inclusive)!",
                    "Invalid End Hour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndHour.Focus();
                txtEndHour.SelectAll();
            }

            else if (eMValid == false)
            {
                allValid = false;
                MessageBox.Show("End Minute be a non-negative number\n" +
                    "between 00 and 59 (inclusive)!",
                    "Invalid End Minute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndMin.Focus();
                txtEndMin.SelectAll();
            }
            return allValid;
        }

        private void ETA_Calculator_Load(object sender, EventArgs e)
        {
            txtStartHour.Focus();
            rdoStartAM.Checked = true;
            rdoEndAM.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartHour.Text = String.Empty;
            txtStartHour.Focus();
            txtStartMin.Text = String.Empty;
            txtEndHour.Text = String.Empty;
            txtEndMin.Text = String.Empty;
            lblETAHour.Text = String.Empty;
            lblETAMin.Text = String.Empty;
            lblDecimal.Text = String.Empty;
            rdoStartAM.Checked = true;
            rdoEndAM.Checked = true;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elapsed Time Calculator\n by Brandon Hoffman\n Copyright 2011",
                "Elapsed Time Calculator", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
