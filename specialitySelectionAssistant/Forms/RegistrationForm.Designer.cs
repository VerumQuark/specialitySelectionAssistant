
namespace specialitySelectionAssistant
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZnoMaterialCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.BudgetMaterialCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ContractMaterialCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.NameMaterialSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.helpMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.nameEnterErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZnoMaterialCheckBox
            // 
            this.ZnoMaterialCheckBox.AutoSize = true;
            this.ZnoMaterialCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.ZnoMaterialCheckBox.Depth = 0;
            this.ZnoMaterialCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ZnoMaterialCheckBox.Location = new System.Drawing.Point(691, 173);
            this.ZnoMaterialCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ZnoMaterialCheckBox.MinimumSize = new System.Drawing.Size(208, 30);
            this.ZnoMaterialCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ZnoMaterialCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZnoMaterialCheckBox.Name = "ZnoMaterialCheckBox";
            this.ZnoMaterialCheckBox.Ripple = true;
            this.ZnoMaterialCheckBox.Size = new System.Drawing.Size(208, 30);
            this.ZnoMaterialCheckBox.TabIndex = 1;
            this.ZnoMaterialCheckBox.Text = "Маю результати ЗНО";
            this.ZnoMaterialCheckBox.UseVisualStyleBackColor = false;
            // 
            // BudgetMaterialCheckBox
            // 
            this.BudgetMaterialCheckBox.AutoSize = true;
            this.BudgetMaterialCheckBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BudgetMaterialCheckBox.Depth = 0;
            this.BudgetMaterialCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.BudgetMaterialCheckBox.Location = new System.Drawing.Point(52, 271);
            this.BudgetMaterialCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.BudgetMaterialCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BudgetMaterialCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BudgetMaterialCheckBox.Name = "BudgetMaterialCheckBox";
            this.BudgetMaterialCheckBox.Ripple = true;
            this.BudgetMaterialCheckBox.Size = new System.Drawing.Size(99, 30);
            this.BudgetMaterialCheckBox.TabIndex = 2;
            this.BudgetMaterialCheckBox.Text = "Бюджетна";
            this.BudgetMaterialCheckBox.UseVisualStyleBackColor = false;
            // 
            // ContractMaterialCheckBox
            // 
            this.ContractMaterialCheckBox.AutoSize = true;
            this.ContractMaterialCheckBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ContractMaterialCheckBox.Depth = 0;
            this.ContractMaterialCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ContractMaterialCheckBox.Location = new System.Drawing.Point(226, 271);
            this.ContractMaterialCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ContractMaterialCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ContractMaterialCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContractMaterialCheckBox.Name = "ContractMaterialCheckBox";
            this.ContractMaterialCheckBox.Ripple = true;
            this.ContractMaterialCheckBox.Size = new System.Drawing.Size(106, 30);
            this.ContractMaterialCheckBox.TabIndex = 3;
            this.ContractMaterialCheckBox.Text = "Контрактна";
            this.ContractMaterialCheckBox.UseVisualStyleBackColor = false;
            // 
            // NameMaterialSingleLineTextField
            // 
            this.NameMaterialSingleLineTextField.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NameMaterialSingleLineTextField.Depth = 0;
            this.NameMaterialSingleLineTextField.Hint = "";
            this.NameMaterialSingleLineTextField.Location = new System.Drawing.Point(52, 175);
            this.NameMaterialSingleLineTextField.Margin = new System.Windows.Forms.Padding(4);
            this.NameMaterialSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameMaterialSingleLineTextField.Name = "NameMaterialSingleLineTextField";
            this.NameMaterialSingleLineTextField.PasswordChar = '\0';
            this.NameMaterialSingleLineTextField.SelectedText = "";
            this.NameMaterialSingleLineTextField.SelectionLength = 0;
            this.NameMaterialSingleLineTextField.SelectionStart = 0;
            this.NameMaterialSingleLineTextField.Size = new System.Drawing.Size(495, 23);
            this.NameMaterialSingleLineTextField.TabIndex = 4;
            this.NameMaterialSingleLineTextField.UseSystemPasswordChar = false;
            this.NameMaterialSingleLineTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameMaterialSingleLineTextField_KeyPress);
            // 
            // NameMaterialLabel
            // 
            this.NameMaterialLabel.AutoSize = true;
            this.NameMaterialLabel.Depth = 0;
            this.NameMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NameMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameMaterialLabel.Location = new System.Drawing.Point(47, 146);
            this.NameMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameMaterialLabel.Name = "NameMaterialLabel";
            this.NameMaterialLabel.Size = new System.Drawing.Size(92, 19);
            this.NameMaterialLabel.TabIndex = 5;
            this.NameMaterialLabel.Text = "Вкажіть ПІБ";
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
            this.nextMaterialFlatButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.nextMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextMaterialFlatButton.Name = "nextMaterialFlatButton";
            this.nextMaterialFlatButton.Primary = false;
            this.nextMaterialFlatButton.Size = new System.Drawing.Size(45, 36);
            this.nextMaterialFlatButton.TabIndex = 6;
            this.nextMaterialFlatButton.Text = "Далі";
            this.nextMaterialFlatButton.UseVisualStyleBackColor = false;
            this.nextMaterialFlatButton.Click += new System.EventHandler(this.NextMaterialFlatButton_Click);
            // 
            // helpMaterialFlatButton
            // 
            this.helpMaterialFlatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpMaterialFlatButton.AutoSize = true;
            this.helpMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpMaterialFlatButton.Depth = 0;
            this.helpMaterialFlatButton.Location = new System.Drawing.Point(479, 509);
            this.helpMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpMaterialFlatButton.Name = "helpMaterialFlatButton";
            this.helpMaterialFlatButton.Primary = false;
            this.helpMaterialFlatButton.Size = new System.Drawing.Size(19, 36);
            this.helpMaterialFlatButton.TabIndex = 7;
            this.helpMaterialFlatButton.Text = "?";
            this.helpMaterialFlatButton.UseVisualStyleBackColor = true;
            this.helpMaterialFlatButton.Click += new System.EventHandler(this.HelpMaterialFlatButton_Click);
            // 
            // nameEnterErrorLabel
            // 
            this.nameEnterErrorLabel.AutoSize = true;
            this.nameEnterErrorLabel.Location = new System.Drawing.Point(51, 218);
            this.nameEnterErrorLabel.Name = "nameEnterErrorLabel";
            this.nameEnterErrorLabel.Size = new System.Drawing.Size(381, 17);
            this.nameEnterErrorLabel.TabIndex = 8;
            this.nameEnterErrorLabel.Text = "Можуть бути використані українські символи, \" - \" та \" \' \".";
            this.nameEnterErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.nameEnterErrorLabel);
            this.Controls.Add(this.helpMaterialFlatButton);
            this.Controls.Add(this.nextMaterialFlatButton);
            this.Controls.Add(this.NameMaterialLabel);
            this.Controls.Add(this.NameMaterialSingleLineTextField);
            this.Controls.Add(this.ContractMaterialCheckBox);
            this.Controls.Add(this.BudgetMaterialCheckBox);
            this.Controls.Add(this.ZnoMaterialCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 562);
            this.MinimumSize = new System.Drawing.Size(1000, 562);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вкажіть свої особисті данні";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox ZnoMaterialCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox BudgetMaterialCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox ContractMaterialCheckBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameMaterialSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel NameMaterialLabel;
        private MaterialSkin.Controls.MaterialFlatButton nextMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton helpMaterialFlatButton;
        private System.Windows.Forms.Label nameEnterErrorLabel;
    }
}

