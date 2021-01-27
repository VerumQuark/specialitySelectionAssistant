using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using specialitySelectionAssistant.Exceptions;
using specialitySelectionAssistant.Tests;
using specialitySelectionAssistant.Utility;
using System.IO;

namespace specialitySelectionAssistant
{
    public partial class TestResultForm : MaterialForm
    {
        private string resultText = "";
        public TestResultForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void TestResultForm_Load(object sender, EventArgs e)
        {
            TestTimer.StopTimer();

            TimerResultLabel.Text = $"Тест пройдено за: {TestTimer.time.ToString("mm:ss")}";

            List<Specialty> specialties = PreferredSpecialtiesDeterminant.GetDetermineSpecialties();

            titleLabel.Text = $"{User.name}, за результатами тесту вам більш підходять такі спеціальності як:";

            try
            {
                firstSpecialtyNameMaterialLabel.Text = specialties[0].name;
                firstSpecialtyDescriptionLabel.Text = specialties[0].description;
                firstSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[0].professions);

                secondSpecialtyNameMaterialLabel.Text = specialties[1].name;
                secondSpecialtyDescriptionLabel.Text = specialties[1].description;
                secondSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[1].professions);

                thirdSpecialtyNameMaterialLabel.Text = specialties[2].name;
                thirdSpecialtyDescriptionLabel.Text = specialties[2].description;
                thirdSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[2].professions);
            }
            catch(Exception ex)
            {
                string message = "Неможливо отримати дані. Перевірте цілісність файлів.";
                ExceptionHandler.HandleException(ex, message);
            }

        }

        private string GetProfessionsStr(string[] professions)
        {

            string specialtyProffesions = "Професії: ";
            int professionLenght = professions.Length - 1;

            for (int i = 0; i < professionLenght; i++)
            {
                specialtyProffesions += professions[i] + ", ";
            }

            specialtyProffesions += professions.Last() + ".";

            return specialtyProffesions;
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void CloseMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveResultMaterialFlatButton_Click(object sender, EventArgs e)
        {
            string fileName = "ResultText.txt";

            resultText = "";
            resultText += $"{titleLabel.Text} \n\n";

            resultText += $"{firstSpecialtyNameMaterialLabel.Text} \n";
            resultText += $"\t{firstSpecialtyDescriptionLabel.Text} \n";
            resultText += $"\t{firstSpecialtyProfessionsLabel.Text} \n\n";

            resultText += $"{secondSpecialtyNameMaterialLabel.Text} \n";
            resultText += $"\t{secondSpecialtyDescriptionLabel.Text} \n";
            resultText += $"\t{secondSpecialtyProfessionsLabel.Text} \n\n";

            resultText += $"{thirdSpecialtyNameMaterialLabel.Text} \n";
            resultText += $"\t{thirdSpecialtyDescriptionLabel.Text} \n";
            resultText += $"\t{thirdSpecialtyProfessionsLabel.Text} \n\n";

            resultText += $"{TimerResultLabel.Text}";

            try
            {
                File.WriteAllText(fileName, resultText);
            }
            catch(Exception ex)
            {
                string message = "Неможливо створити файл.";
                ExceptionHandler.HandleException(ex, message);
            }

            MessageBox.Show($"Результат збережений у файлі з ім'ям \"{fileName}\"");
        }
    }
}
