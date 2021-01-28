using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

using MaterialSkin;
using specialitySelectionAssistant.Forms.Controls;
using specialitySelectionAssistant.Utility;

namespace specialitySelectionAssistant
{
    public partial class AboutForm : MaterialForm
    {
        public AboutForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);

            this.Controls.Add(CustomControlsStorage.GetCustomMenuStrip());
        }

        private void backMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToPrevForm(this);
        }
    }
}
