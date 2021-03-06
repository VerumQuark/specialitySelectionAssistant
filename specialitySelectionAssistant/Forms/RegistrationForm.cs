﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Text.RegularExpressions;
using specialitySelectionAssistant.Exceptions;
using specialitySelectionAssistant.Utility;
using specialitySelectionAssistant.Forms.Controls;

namespace specialitySelectionAssistant
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);

            Controls.Add(CustomControlsStorage.GetCustomMenuStrip());
        }

        private void NextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckNameField();

                string name = NameMaterialSingleLineTextField.Text;
                bool budget = BudgetMaterialCheckBox.Checked;
                bool contract = ContractMaterialCheckBox.Checked;
                bool haveZno = ZnoMaterialCheckBox.Checked;

                User.SetName(name);
                User.SetEducationForm(budget, contract, haveZno);

                Navigation.StartTest(haveZno, this);
            }
            catch(Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void NameMaterialSingleLineTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nextMaterialFlatButton.PerformClick();
                return;
            }


            string pattern = "[А-ЩЬЮЯҐЄІЇа-щьюяґєії\\b'`’ʼ -]";
            string inputValue = e.KeyChar.ToString();

            if (Regex.IsMatch(inputValue, pattern, RegexOptions.IgnoreCase) == false)
            {
                AddNameBorder(Pens.Red);
                nameEnterErrorLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                AddNameBorder(Pens.White);
                nameEnterErrorLabel.Visible = false;
            }
        }

        private void AddNameBorder(Pen pen)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.DrawRectangle(
            pen,
            NameMaterialSingleLineTextField.Left - 1,
            NameMaterialSingleLineTextField.Top - 1,
            NameMaterialSingleLineTextField.Width + 1,
            NameMaterialSingleLineTextField.Height + 1); ;
        }

        private void CheckNameField()
        {
            string pattern = "^\\s*$";
            string inputValue = NameMaterialSingleLineTextField.Text;

            if (Regex.IsMatch(inputValue, pattern, RegexOptions.IgnoreCase))
            {
                AddNameBorder(Pens.Red);
                throw new Exception("Введіть ПІБ");
            }
        }
    }
}
