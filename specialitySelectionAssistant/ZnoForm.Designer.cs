
namespace specialitySelectionAssistant
{
    partial class ZnoForm
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
            this.helpMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.firstSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.secondSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.thirdSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.fourthSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.fifthSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.backMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.nextMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.firstSubjectPotintsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondSubjectPotintsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.thirdSubjectPotintsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fourthSubjectPotintsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fifthSubjectPotintsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.firstSubjectPotintsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSubjectPotintsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdSubjectPotintsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthSubjectPotintsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthSubjectPotintsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // helpMaterialFlatButton
            // 
            this.helpMaterialFlatButton.AutoSize = true;
            this.helpMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpMaterialFlatButton.Depth = 0;
            this.helpMaterialFlatButton.Location = new System.Drawing.Point(479, 508);
            this.helpMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpMaterialFlatButton.Name = "helpMaterialFlatButton";
            this.helpMaterialFlatButton.Primary = false;
            this.helpMaterialFlatButton.Size = new System.Drawing.Size(19, 36);
            this.helpMaterialFlatButton.TabIndex = 17;
            this.helpMaterialFlatButton.Text = "?";
            this.helpMaterialFlatButton.UseVisualStyleBackColor = true;
            this.helpMaterialFlatButton.Click += new System.EventHandler(this.helpMaterialFlatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введіть результати ЗНО";
            // 
            // firstSubjectComboBox
            // 
            this.firstSubjectComboBox.FormattingEnabled = true;
            this.firstSubjectComboBox.Location = new System.Drawing.Point(54, 189);
            this.firstSubjectComboBox.Name = "firstSubjectComboBox";
            this.firstSubjectComboBox.Size = new System.Drawing.Size(263, 21);
            this.firstSubjectComboBox.TabIndex = 28;
            this.firstSubjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            this.firstSubjectComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectComboBox_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(54, 155);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Перший предмет";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(54, 231);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Другий предмет";
            // 
            // secondSubjectComboBox
            // 
            this.secondSubjectComboBox.FormattingEnabled = true;
            this.secondSubjectComboBox.Location = new System.Drawing.Point(54, 265);
            this.secondSubjectComboBox.Name = "secondSubjectComboBox";
            this.secondSubjectComboBox.Size = new System.Drawing.Size(263, 21);
            this.secondSubjectComboBox.TabIndex = 31;
            this.secondSubjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            this.secondSubjectComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectComboBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(54, 314);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "Третій предмет";
            // 
            // thirdSubjectComboBox
            // 
            this.thirdSubjectComboBox.FormattingEnabled = true;
            this.thirdSubjectComboBox.Location = new System.Drawing.Point(54, 348);
            this.thirdSubjectComboBox.Name = "thirdSubjectComboBox";
            this.thirdSubjectComboBox.Size = new System.Drawing.Size(263, 21);
            this.thirdSubjectComboBox.TabIndex = 34;
            this.thirdSubjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            this.thirdSubjectComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectComboBox_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(50, 399);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(148, 19);
            this.materialLabel4.TabIndex = 39;
            this.materialLabel4.Text = "Четвертий предмет";
            // 
            // fourthSubjectComboBox
            // 
            this.fourthSubjectComboBox.FormattingEnabled = true;
            this.fourthSubjectComboBox.Location = new System.Drawing.Point(50, 433);
            this.fourthSubjectComboBox.Name = "fourthSubjectComboBox";
            this.fourthSubjectComboBox.Size = new System.Drawing.Size(267, 21);
            this.fourthSubjectComboBox.TabIndex = 37;
            this.fourthSubjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            this.fourthSubjectComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectComboBox_KeyPress);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(404, 185);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(48, 19);
            this.materialLabel9.TabIndex = 52;
            this.materialLabel9.Text = "Балів";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(404, 261);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(48, 19);
            this.materialLabel10.TabIndex = 53;
            this.materialLabel10.Text = "Балів";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(404, 344);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(48, 19);
            this.materialLabel11.TabIndex = 54;
            this.materialLabel11.Text = "Балів";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(404, 429);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(48, 19);
            this.materialLabel12.TabIndex = 55;
            this.materialLabel12.Text = "Балів";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(878, 185);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(48, 19);
            this.materialLabel8.TabIndex = 68;
            this.materialLabel8.Text = "Балів";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(528, 155);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(120, 19);
            this.materialLabel16.TabIndex = 58;
            this.materialLabel16.Text = "П\'ятий предмет";
            // 
            // fifthSubjectComboBox
            // 
            this.fifthSubjectComboBox.FormattingEnabled = true;
            this.fifthSubjectComboBox.Location = new System.Drawing.Point(528, 189);
            this.fifthSubjectComboBox.Name = "fifthSubjectComboBox";
            this.fifthSubjectComboBox.Size = new System.Drawing.Size(263, 21);
            this.fifthSubjectComboBox.TabIndex = 56;
            this.fifthSubjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            this.fifthSubjectComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subjectComboBox_KeyPress);
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
            this.backMaterialFlatButton.Location = new System.Drawing.Point(15, 509);
            this.backMaterialFlatButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.backMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backMaterialFlatButton.Name = "backMaterialFlatButton";
            this.backMaterialFlatButton.Primary = false;
            this.backMaterialFlatButton.Size = new System.Drawing.Size(59, 36);
            this.backMaterialFlatButton.TabIndex = 70;
            this.backMaterialFlatButton.Text = "Назад";
            this.backMaterialFlatButton.UseVisualStyleBackColor = false;
            this.backMaterialFlatButton.Click += new System.EventHandler(this.backMaterialFlatButton_Click);
            // 
            // nextMaterialFlatButton
            // 
            this.nextMaterialFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextMaterialFlatButton.AutoSize = true;
            this.nextMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextMaterialFlatButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextMaterialFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextMaterialFlatButton.Depth = 0;
            this.nextMaterialFlatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nextMaterialFlatButton.Location = new System.Drawing.Point(912, 509);
            this.nextMaterialFlatButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.nextMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextMaterialFlatButton.Name = "nextMaterialFlatButton";
            this.nextMaterialFlatButton.Primary = false;
            this.nextMaterialFlatButton.Size = new System.Drawing.Size(45, 36);
            this.nextMaterialFlatButton.TabIndex = 69;
            this.nextMaterialFlatButton.Text = "Далі";
            this.nextMaterialFlatButton.UseVisualStyleBackColor = false;
            this.nextMaterialFlatButton.Click += new System.EventHandler(this.nextMaterialFlatButton_Click);
            // 
            // firstSubjectPotintsNumericUpDown
            // 
            this.firstSubjectPotintsNumericUpDown.Location = new System.Drawing.Point(336, 189);
            this.firstSubjectPotintsNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.firstSubjectPotintsNumericUpDown.Name = "firstSubjectPotintsNumericUpDown";
            this.firstSubjectPotintsNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.firstSubjectPotintsNumericUpDown.TabIndex = 82;
            this.firstSubjectPotintsNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subjectPotintsNumericUpDown_KeyUp);
            this.firstSubjectPotintsNumericUpDown.Leave += new System.EventHandler(this.subjectPotintsNumericUpDown_Leave);
            // 
            // secondSubjectPotintsNumericUpDown
            // 
            this.secondSubjectPotintsNumericUpDown.Location = new System.Drawing.Point(336, 265);
            this.secondSubjectPotintsNumericUpDown.Name = "secondSubjectPotintsNumericUpDown";
            this.secondSubjectPotintsNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.secondSubjectPotintsNumericUpDown.TabIndex = 83;
            this.secondSubjectPotintsNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subjectPotintsNumericUpDown_KeyUp);
            this.secondSubjectPotintsNumericUpDown.Leave += new System.EventHandler(this.subjectPotintsNumericUpDown_Leave);
            // 
            // thirdSubjectPotintsNumericUpDown
            // 
            this.thirdSubjectPotintsNumericUpDown.Location = new System.Drawing.Point(336, 348);
            this.thirdSubjectPotintsNumericUpDown.Name = "thirdSubjectPotintsNumericUpDown";
            this.thirdSubjectPotintsNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.thirdSubjectPotintsNumericUpDown.TabIndex = 84;
            this.thirdSubjectPotintsNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subjectPotintsNumericUpDown_KeyUp);
            this.thirdSubjectPotintsNumericUpDown.Leave += new System.EventHandler(this.subjectPotintsNumericUpDown_Leave);
            // 
            // fourthSubjectPotintsNumericUpDown
            // 
            this.fourthSubjectPotintsNumericUpDown.Location = new System.Drawing.Point(336, 433);
            this.fourthSubjectPotintsNumericUpDown.Name = "fourthSubjectPotintsNumericUpDown";
            this.fourthSubjectPotintsNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.fourthSubjectPotintsNumericUpDown.TabIndex = 85;
            this.fourthSubjectPotintsNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subjectPotintsNumericUpDown_KeyUp);
            this.fourthSubjectPotintsNumericUpDown.Leave += new System.EventHandler(this.subjectPotintsNumericUpDown_Leave);
            // 
            // fifthSubjectPotintsNumericUpDown
            // 
            this.fifthSubjectPotintsNumericUpDown.Location = new System.Drawing.Point(810, 189);
            this.fifthSubjectPotintsNumericUpDown.Name = "fifthSubjectPotintsNumericUpDown";
            this.fifthSubjectPotintsNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.fifthSubjectPotintsNumericUpDown.TabIndex = 86;
            this.fifthSubjectPotintsNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subjectPotintsNumericUpDown_KeyUp);
            this.fifthSubjectPotintsNumericUpDown.Leave += new System.EventHandler(this.subjectPotintsNumericUpDown_Leave);
            // 
            // ZnoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.fifthSubjectPotintsNumericUpDown);
            this.Controls.Add(this.fourthSubjectPotintsNumericUpDown);
            this.Controls.Add(this.thirdSubjectPotintsNumericUpDown);
            this.Controls.Add(this.secondSubjectPotintsNumericUpDown);
            this.Controls.Add(this.firstSubjectPotintsNumericUpDown);
            this.Controls.Add(this.backMaterialFlatButton);
            this.Controls.Add(this.nextMaterialFlatButton);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.fifthSubjectComboBox);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.fourthSubjectComboBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.thirdSubjectComboBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.secondSubjectComboBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.firstSubjectComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpMaterialFlatButton);
            this.MinimumSize = new System.Drawing.Size(1000, 562);
            this.Name = "ZnoForm";
            this.Text = "ЗНО";
            this.Load += new System.EventHandler(this.ZnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstSubjectPotintsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondSubjectPotintsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdSubjectPotintsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthSubjectPotintsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthSubjectPotintsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton helpMaterialFlatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox firstSubjectComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox secondSubjectComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox thirdSubjectComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox fourthSubjectComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox fifthSubjectComboBox;
        private MaterialSkin.Controls.MaterialFlatButton backMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton nextMaterialFlatButton;
        private System.Windows.Forms.NumericUpDown firstSubjectPotintsNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondSubjectPotintsNumericUpDown;
        private System.Windows.Forms.NumericUpDown thirdSubjectPotintsNumericUpDown;
        private System.Windows.Forms.NumericUpDown fourthSubjectPotintsNumericUpDown;
        private System.Windows.Forms.NumericUpDown fifthSubjectPotintsNumericUpDown;
    }
}