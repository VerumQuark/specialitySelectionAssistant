
namespace specialitySelectionAssistant
{
    partial class UserPreferencesForm
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
            this.veryLikeMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ratherSoMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ratherNotMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.cantAnswerMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.veryDislikeMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.backMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.nextMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.helpMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.listQuestionQuestionLabel = new System.Windows.Forms.Label();
            this.QuestionNumberMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timer1000 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // veryLikeMaterialRadioButton
            // 
            this.veryLikeMaterialRadioButton.AutoSize = true;
            this.veryLikeMaterialRadioButton.BackColor = System.Drawing.SystemColors.Window;
            this.veryLikeMaterialRadioButton.Checked = true;
            this.veryLikeMaterialRadioButton.Depth = 0;
            this.veryLikeMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.veryLikeMaterialRadioButton.Location = new System.Drawing.Point(54, 195);
            this.veryLikeMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.veryLikeMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.veryLikeMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.veryLikeMaterialRadioButton.Name = "veryLikeMaterialRadioButton";
            this.veryLikeMaterialRadioButton.Ripple = true;
            this.veryLikeMaterialRadioButton.Size = new System.Drawing.Size(151, 30);
            this.veryLikeMaterialRadioButton.TabIndex = 0;
            this.veryLikeMaterialRadioButton.TabStop = true;
            this.veryLikeMaterialRadioButton.Text = "Дуже подобається";
            this.veryLikeMaterialRadioButton.UseVisualStyleBackColor = false;
            this.veryLikeMaterialRadioButton.CheckedChanged += new System.EventHandler(this.VeryLikeMaterialRadioButton_CheckedChanged);
            this.veryLikeMaterialRadioButton.Click += new System.EventHandler(this.VeryLikeMaterialRadioButton_CheckedChanged);
            this.veryLikeMaterialRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialRadioButton_KeyUp);
            this.veryLikeMaterialRadioButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.veryLikeMaterialRadioButton_PreviewKeyDown);
            // 
            // ratherSoMaterialRadioButton
            // 
            this.ratherSoMaterialRadioButton.AutoSize = true;
            this.ratherSoMaterialRadioButton.BackColor = System.Drawing.SystemColors.Window;
            this.ratherSoMaterialRadioButton.Depth = 0;
            this.ratherSoMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.ratherSoMaterialRadioButton.Location = new System.Drawing.Point(54, 245);
            this.ratherSoMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.ratherSoMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ratherSoMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratherSoMaterialRadioButton.Name = "ratherSoMaterialRadioButton";
            this.ratherSoMaterialRadioButton.Ripple = true;
            this.ratherSoMaterialRadioButton.Size = new System.Drawing.Size(101, 30);
            this.ratherSoMaterialRadioButton.TabIndex = 1;
            this.ratherSoMaterialRadioButton.Text = "Скоріш так";
            this.ratherSoMaterialRadioButton.UseVisualStyleBackColor = false;
            this.ratherSoMaterialRadioButton.CheckedChanged += new System.EventHandler(this.RatherSoMaterialRadioButton_CheckedChanged);
            this.ratherSoMaterialRadioButton.Click += new System.EventHandler(this.RatherSoMaterialRadioButton_CheckedChanged);
            this.ratherSoMaterialRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialRadioButton_KeyUp);
            // 
            // ratherNotMaterialRadioButton
            // 
            this.ratherNotMaterialRadioButton.AutoSize = true;
            this.ratherNotMaterialRadioButton.BackColor = System.Drawing.SystemColors.Window;
            this.ratherNotMaterialRadioButton.Depth = 0;
            this.ratherNotMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.ratherNotMaterialRadioButton.Location = new System.Drawing.Point(54, 345);
            this.ratherNotMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.ratherNotMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ratherNotMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratherNotMaterialRadioButton.Name = "ratherNotMaterialRadioButton";
            this.ratherNotMaterialRadioButton.Ripple = true;
            this.ratherNotMaterialRadioButton.Size = new System.Drawing.Size(91, 30);
            this.ratherNotMaterialRadioButton.TabIndex = 3;
            this.ratherNotMaterialRadioButton.Text = "Скоріш ні";
            this.ratherNotMaterialRadioButton.UseVisualStyleBackColor = false;
            this.ratherNotMaterialRadioButton.CheckedChanged += new System.EventHandler(this.RatherNotMaterialRadioButton_CheckedChanged);
            this.ratherNotMaterialRadioButton.Click += new System.EventHandler(this.RatherNotMaterialRadioButton_CheckedChanged);
            this.ratherNotMaterialRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialRadioButton_KeyUp);
            // 
            // cantAnswerMaterialRadioButton
            // 
            this.cantAnswerMaterialRadioButton.AutoSize = true;
            this.cantAnswerMaterialRadioButton.BackColor = System.Drawing.SystemColors.Window;
            this.cantAnswerMaterialRadioButton.Depth = 0;
            this.cantAnswerMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.cantAnswerMaterialRadioButton.Location = new System.Drawing.Point(54, 295);
            this.cantAnswerMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.cantAnswerMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cantAnswerMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cantAnswerMaterialRadioButton.Name = "cantAnswerMaterialRadioButton";
            this.cantAnswerMaterialRadioButton.Ripple = true;
            this.cantAnswerMaterialRadioButton.Size = new System.Drawing.Size(158, 30);
            this.cantAnswerMaterialRadioButton.TabIndex = 2;
            this.cantAnswerMaterialRadioButton.Text = "Не можу відповісти";
            this.cantAnswerMaterialRadioButton.UseVisualStyleBackColor = false;
            this.cantAnswerMaterialRadioButton.CheckedChanged += new System.EventHandler(this.CantAnswerMaterialRadioButton_CheckedChanged);
            this.cantAnswerMaterialRadioButton.Click += new System.EventHandler(this.CantAnswerMaterialRadioButton_CheckedChanged);
            this.cantAnswerMaterialRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialRadioButton_KeyUp);
            // 
            // veryDislikeMaterialRadioButton
            // 
            this.veryDislikeMaterialRadioButton.AutoSize = true;
            this.veryDislikeMaterialRadioButton.BackColor = System.Drawing.SystemColors.Window;
            this.veryDislikeMaterialRadioButton.Depth = 0;
            this.veryDislikeMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.veryDislikeMaterialRadioButton.Location = new System.Drawing.Point(54, 395);
            this.veryDislikeMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.veryDislikeMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.veryDislikeMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.veryDislikeMaterialRadioButton.Name = "veryDislikeMaterialRadioButton";
            this.veryDislikeMaterialRadioButton.Ripple = true;
            this.veryDislikeMaterialRadioButton.Size = new System.Drawing.Size(170, 30);
            this.veryDislikeMaterialRadioButton.TabIndex = 4;
            this.veryDislikeMaterialRadioButton.Text = "Дуже не подобається";
            this.veryDislikeMaterialRadioButton.UseVisualStyleBackColor = false;
            this.veryDislikeMaterialRadioButton.CheckedChanged += new System.EventHandler(this.VeryDislikeMaterialRadioButton_CheckedChanged);
            this.veryDislikeMaterialRadioButton.Click += new System.EventHandler(this.VeryDislikeMaterialRadioButton_CheckedChanged);
            this.veryDislikeMaterialRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaterialRadioButton_KeyUp);
            this.veryDislikeMaterialRadioButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.veryDislikeMaterialRadioButton_PreviewKeyDown);
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
            this.backMaterialFlatButton.TabIndex = 12;
            this.backMaterialFlatButton.TabStop = false;
            this.backMaterialFlatButton.Text = "Назад";
            this.backMaterialFlatButton.UseVisualStyleBackColor = false;
            this.backMaterialFlatButton.Click += new System.EventHandler(this.BackMaterialFlatButton_Click);
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
            this.nextMaterialFlatButton.TabIndex = 11;
            this.nextMaterialFlatButton.TabStop = false;
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
            this.helpMaterialFlatButton.Location = new System.Drawing.Point(479, 508);
            this.helpMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpMaterialFlatButton.Name = "helpMaterialFlatButton";
            this.helpMaterialFlatButton.Primary = false;
            this.helpMaterialFlatButton.Size = new System.Drawing.Size(19, 36);
            this.helpMaterialFlatButton.TabIndex = 17;
            this.helpMaterialFlatButton.TabStop = false;
            this.helpMaterialFlatButton.Text = "?";
            this.helpMaterialFlatButton.UseVisualStyleBackColor = true;
            this.helpMaterialFlatButton.Click += new System.EventHandler(this.HelpMaterialFlatButton_Click);
            // 
            // listQuestionQuestionLabel
            // 
            this.listQuestionQuestionLabel.CausesValidation = false;
            this.listQuestionQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listQuestionQuestionLabel.Location = new System.Drawing.Point(49, 102);
            this.listQuestionQuestionLabel.Name = "listQuestionQuestionLabel";
            this.listQuestionQuestionLabel.Size = new System.Drawing.Size(908, 70);
            this.listQuestionQuestionLabel.TabIndex = 22;
            this.listQuestionQuestionLabel.Text = "Питання";
            // 
            // QuestionNumberMaterialLabel
            // 
            this.QuestionNumberMaterialLabel.AutoSize = true;
            this.QuestionNumberMaterialLabel.Depth = 0;
            this.QuestionNumberMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuestionNumberMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuestionNumberMaterialLabel.Location = new System.Drawing.Point(50, 72);
            this.QuestionNumberMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuestionNumberMaterialLabel.Name = "QuestionNumberMaterialLabel";
            this.QuestionNumberMaterialLabel.Size = new System.Drawing.Size(100, 19);
            this.QuestionNumberMaterialLabel.TabIndex = 24;
            this.QuestionNumberMaterialLabel.Text = "Питання {}/{}";
            // 
            // timer1000
            // 
            this.timer1000.Enabled = true;
            this.timer1000.Tick += new System.EventHandler(this.timer1000_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(436, 458);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(44, 17);
            this.TimerLabel.TabIndex = 25;
            this.TimerLabel.Text = "00:00";
            // 
            // UserPreferencesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.QuestionNumberMaterialLabel);
            this.Controls.Add(this.listQuestionQuestionLabel);
            this.Controls.Add(this.helpMaterialFlatButton);
            this.Controls.Add(this.backMaterialFlatButton);
            this.Controls.Add(this.nextMaterialFlatButton);
            this.Controls.Add(this.veryDislikeMaterialRadioButton);
            this.Controls.Add(this.ratherNotMaterialRadioButton);
            this.Controls.Add(this.cantAnswerMaterialRadioButton);
            this.Controls.Add(this.ratherSoMaterialRadioButton);
            this.Controls.Add(this.veryLikeMaterialRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 562);
            this.MinimumSize = new System.Drawing.Size(1000, 562);
            this.Name = "UserPreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оберіть один з варіантів!";
            this.Load += new System.EventHandler(this.UserPreferencesForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserPreferencesForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton veryLikeMaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton ratherSoMaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton ratherNotMaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton cantAnswerMaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton veryDislikeMaterialRadioButton;
        private MaterialSkin.Controls.MaterialFlatButton backMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton nextMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton helpMaterialFlatButton;
        private System.Windows.Forms.Label listQuestionQuestionLabel;
        private MaterialSkin.Controls.MaterialLabel QuestionNumberMaterialLabel;
        private System.Windows.Forms.Timer timer1000;
        private System.Windows.Forms.Label TimerLabel;
    }
}