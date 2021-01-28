
namespace specialitySelectionAssistant
{
    partial class HollandTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HollandTestForm));
            this.nextFormMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.leftProffesionMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BackMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.rightProffesionMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.leftProffesionButton = new System.Windows.Forms.Button();
            this.rightProfessionButton = new System.Windows.Forms.Button();
            this.HelpMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.questionNumLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Timer1000 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nextFormMaterialFlatButton
            // 
            this.nextFormMaterialFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextFormMaterialFlatButton.AutoSize = true;
            this.nextFormMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextFormMaterialFlatButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextFormMaterialFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextFormMaterialFlatButton.Depth = 0;
            this.nextFormMaterialFlatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nextFormMaterialFlatButton.Location = new System.Drawing.Point(912, 509);
            this.nextFormMaterialFlatButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.nextFormMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextFormMaterialFlatButton.Name = "nextFormMaterialFlatButton";
            this.nextFormMaterialFlatButton.Primary = false;
            this.nextFormMaterialFlatButton.Size = new System.Drawing.Size(45, 36);
            this.nextFormMaterialFlatButton.TabIndex = 2;
            this.nextFormMaterialFlatButton.TabStop = false;
            this.nextFormMaterialFlatButton.Text = "Далі";
            this.nextFormMaterialFlatButton.UseVisualStyleBackColor = false;
            this.nextFormMaterialFlatButton.Click += new System.EventHandler(this.NextFormMaterialFlatButton_Click);
            // 
            // leftProffesionMaterialLabel
            // 
            this.leftProffesionMaterialLabel.AutoSize = true;
            this.leftProffesionMaterialLabel.Depth = 0;
            this.leftProffesionMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.leftProffesionMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.leftProffesionMaterialLabel.Location = new System.Drawing.Point(115, 155);
            this.leftProffesionMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftProffesionMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.leftProffesionMaterialLabel.Name = "leftProffesionMaterialLabel";
            this.leftProffesionMaterialLabel.Size = new System.Drawing.Size(116, 19);
            this.leftProffesionMaterialLabel.TabIndex = 9;
            this.leftProffesionMaterialLabel.Text = "ліва профессія";
            this.leftProffesionMaterialLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.leftProffesionMaterialLabel_PreviewKeyDown);
            // 
            // BackMaterialFlatButton
            // 
            this.BackMaterialFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackMaterialFlatButton.AutoSize = true;
            this.BackMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackMaterialFlatButton.BackColor = System.Drawing.SystemColors.Window;
            this.BackMaterialFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackMaterialFlatButton.Depth = 0;
            this.BackMaterialFlatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackMaterialFlatButton.Location = new System.Drawing.Point(15, 509);
            this.BackMaterialFlatButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.BackMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackMaterialFlatButton.Name = "BackMaterialFlatButton";
            this.BackMaterialFlatButton.Primary = false;
            this.BackMaterialFlatButton.Size = new System.Drawing.Size(59, 36);
            this.BackMaterialFlatButton.TabIndex = 10;
            this.BackMaterialFlatButton.TabStop = false;
            this.BackMaterialFlatButton.Text = "Назад";
            this.BackMaterialFlatButton.UseVisualStyleBackColor = false;
            this.BackMaterialFlatButton.Click += new System.EventHandler(this.BackMaterialFlatButton_Click);
            // 
            // rightProffesionMaterialLabel
            // 
            this.rightProffesionMaterialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightProffesionMaterialLabel.AutoSize = true;
            this.rightProffesionMaterialLabel.Depth = 0;
            this.rightProffesionMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.rightProffesionMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightProffesionMaterialLabel.Location = new System.Drawing.Point(614, 155);
            this.rightProffesionMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightProffesionMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightProffesionMaterialLabel.Name = "rightProffesionMaterialLabel";
            this.rightProffesionMaterialLabel.Size = new System.Drawing.Size(128, 19);
            this.rightProffesionMaterialLabel.TabIndex = 13;
            this.rightProffesionMaterialLabel.Text = "права профессія";
            // 
            // leftProffesionButton
            // 
            this.leftProffesionButton.BackColor = System.Drawing.Color.White;
            this.leftProffesionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftProffesionButton.BackgroundImage")));
            this.leftProffesionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftProffesionButton.Location = new System.Drawing.Point(119, 195);
            this.leftProffesionButton.Name = "leftProffesionButton";
            this.leftProffesionButton.Size = new System.Drawing.Size(250, 250);
            this.leftProffesionButton.TabIndex = 0;
            this.leftProffesionButton.UseVisualStyleBackColor = false;
            this.leftProffesionButton.Click += new System.EventHandler(this.LeftProfessionButton_Click);
            this.leftProffesionButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Button_PreviewKeyDown);
            // 
            // rightProfessionButton
            // 
            this.rightProfessionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightProfessionButton.BackColor = System.Drawing.Color.White;
            this.rightProfessionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightProfessionButton.BackgroundImage")));
            this.rightProfessionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightProfessionButton.Location = new System.Drawing.Point(618, 195);
            this.rightProfessionButton.MaximumSize = new System.Drawing.Size(250, 250);
            this.rightProfessionButton.MinimumSize = new System.Drawing.Size(250, 250);
            this.rightProfessionButton.Name = "rightProfessionButton";
            this.rightProfessionButton.Size = new System.Drawing.Size(250, 250);
            this.rightProfessionButton.TabIndex = 1;
            this.rightProfessionButton.UseVisualStyleBackColor = false;
            this.rightProfessionButton.Click += new System.EventHandler(this.RightProfessionButton_Click);
            this.rightProfessionButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Button_PreviewKeyDown);
            // 
            // HelpMaterialFlatButton
            // 
            this.HelpMaterialFlatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HelpMaterialFlatButton.AutoSize = true;
            this.HelpMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpMaterialFlatButton.Depth = 0;
            this.HelpMaterialFlatButton.Location = new System.Drawing.Point(479, 509);
            this.HelpMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HelpMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.HelpMaterialFlatButton.Name = "HelpMaterialFlatButton";
            this.HelpMaterialFlatButton.Primary = false;
            this.HelpMaterialFlatButton.Size = new System.Drawing.Size(19, 36);
            this.HelpMaterialFlatButton.TabIndex = 16;
            this.HelpMaterialFlatButton.TabStop = false;
            this.HelpMaterialFlatButton.Text = "?";
            this.HelpMaterialFlatButton.UseVisualStyleBackColor = true;
            this.HelpMaterialFlatButton.Click += new System.EventHandler(this.HelpMaterialFlatButton_Click);
            // 
            // questionNumLabel
            // 
            this.questionNumLabel.AutoSize = true;
            this.questionNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumLabel.Location = new System.Drawing.Point(38, 92);
            this.questionNumLabel.Name = "questionNumLabel";
            this.questionNumLabel.Size = new System.Drawing.Size(144, 25);
            this.questionNumLabel.TabIndex = 24;
            this.questionNumLabel.Text = "Питання {}/{}";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(921, 31);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(67, 25);
            this.TimerLabel.TabIndex = 25;
            this.TimerLabel.Text = "00:00";
            // 
            // Timer1000
            // 
            this.Timer1000.Enabled = true;
            this.Timer1000.Interval = 1000;
            this.Timer1000.Tick += new System.EventHandler(this.Timer1000_Tick);
            // 
            // HollandTestForm
            // 
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.questionNumLabel);
            this.Controls.Add(this.HelpMaterialFlatButton);
            this.Controls.Add(this.rightProfessionButton);
            this.Controls.Add(this.leftProffesionButton);
            this.Controls.Add(this.rightProffesionMaterialLabel);
            this.Controls.Add(this.BackMaterialFlatButton);
            this.Controls.Add(this.leftProffesionMaterialLabel);
            this.Controls.Add(this.nextFormMaterialFlatButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 562);
            this.MinimumSize = new System.Drawing.Size(1000, 562);
            this.Name = "HollandTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оберіть найбільш задовільну професію!";
            this.Load += new System.EventHandler(this.HollandTestFormForm_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HollandTestForm_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton nextFormMaterialFlatButton;
        private MaterialSkin.Controls.MaterialLabel leftProffesionMaterialLabel;
        private MaterialSkin.Controls.MaterialFlatButton BackMaterialFlatButton;
        private MaterialSkin.Controls.MaterialLabel rightProffesionMaterialLabel;
        private System.Windows.Forms.Button leftProffesionButton;
        private System.Windows.Forms.Button rightProfessionButton;
        private MaterialSkin.Controls.MaterialFlatButton HelpMaterialFlatButton;
        private System.Windows.Forms.Label questionNumLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer Timer1000;
    }
}