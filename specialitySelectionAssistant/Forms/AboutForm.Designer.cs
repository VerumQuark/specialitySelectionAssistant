
namespace specialitySelectionAssistant
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.backMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // AboutMaterialLabel
            // 
            this.AboutMaterialLabel.BackColor = System.Drawing.Color.White;
            this.AboutMaterialLabel.Depth = 0;
            this.AboutMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AboutMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutMaterialLabel.Location = new System.Drawing.Point(25, 92);
            this.AboutMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutMaterialLabel.Name = "AboutMaterialLabel";
            this.AboutMaterialLabel.Size = new System.Drawing.Size(725, 317);
            this.AboutMaterialLabel.TabIndex = 0;
            this.AboutMaterialLabel.Text = resources.GetString("AboutMaterialLabel.Text");
            // 
            // backMaterialFlatButton
            // 
            this.backMaterialFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backMaterialFlatButton.AutoSize = true;
            this.backMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backMaterialFlatButton.BackColor = System.Drawing.SystemColors.Window;
            this.backMaterialFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backMaterialFlatButton.Depth = 0;
            this.backMaterialFlatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backMaterialFlatButton.Location = new System.Drawing.Point(29, 507);
            this.backMaterialFlatButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.backMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backMaterialFlatButton.Name = "backMaterialFlatButton";
            this.backMaterialFlatButton.Primary = false;
            this.backMaterialFlatButton.Size = new System.Drawing.Size(59, 36);
            this.backMaterialFlatButton.TabIndex = 72;
            this.backMaterialFlatButton.Text = "Назад";
            this.backMaterialFlatButton.UseVisualStyleBackColor = false;
            this.backMaterialFlatButton.Click += new System.EventHandler(this.backMaterialFlatButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.backMaterialFlatButton);
            this.Controls.Add(this.AboutMaterialLabel);
            this.MaximumSize = new System.Drawing.Size(1000, 562);
            this.MinimumSize = new System.Drawing.Size(1000, 562);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Про програму ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel AboutMaterialLabel;
        private MaterialSkin.Controls.MaterialFlatButton backMaterialFlatButton;
    }
}