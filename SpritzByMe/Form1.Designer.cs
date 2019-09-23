namespace SpritzByMe
{
    partial class Spritz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spritz));
            this.Spri = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.labelWpm = new System.Windows.Forms.Label();
            this.leftB = new System.Windows.Forms.Button();
            this.rightB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeReadingL = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.Pause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WordsReadL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WordsLeftL = new System.Windows.Forms.Label();
            this.WPML = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.FontUp = new System.Windows.Forms.Button();
            this.FontDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spri
            // 
            this.Spri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Spri.Cursor = System.Windows.Forms.Cursors.No;
            this.Spri.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spri.HideSelection = false;
            this.Spri.Location = new System.Drawing.Point(175, 30);
            this.Spri.Name = "Spri";
            this.Spri.ReadOnly = true;
            this.Spri.Size = new System.Drawing.Size(550, 76);
            this.Spri.TabIndex = 0;
            this.Spri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserText
            // 
            this.UserText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserText.Location = new System.Drawing.Point(50, 260);
            this.UserText.Multiline = true;
            this.UserText.Name = "UserText";
            this.UserText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserText.Size = new System.Drawing.Size(800, 260);
            this.UserText.TabIndex = 1;
            this.UserText.Text = resources.GetString("UserText.Text");
            this.UserText.TextChanged += new System.EventHandler(this.UserText_TextChanged);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(375, 112);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(160, 80);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // labelWpm
            // 
            this.labelWpm.AutoSize = true;
            this.labelWpm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWpm.Location = new System.Drawing.Point(407, 10);
            this.labelWpm.Name = "labelWpm";
            this.labelWpm.Size = new System.Drawing.Size(64, 19);
            this.labelWpm.TabIndex = 3;
            this.labelWpm.Text = "WPM  -";
            // 
            // leftB
            // 
            this.leftB.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.leftB.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftB.Location = new System.Drawing.Point(200, 112);
            this.leftB.Name = "leftB";
            this.leftB.Size = new System.Drawing.Size(75, 81);
            this.leftB.TabIndex = 4;
            this.leftB.Text = "<<";
            this.leftB.UseVisualStyleBackColor = true;
            this.leftB.Click += new System.EventHandler(this.LeftB_Click);
            // 
            // rightB
            // 
            this.rightB.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.rightB.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightB.Location = new System.Drawing.Point(625, 112);
            this.rightB.Name = "rightB";
            this.rightB.Size = new System.Drawing.Size(75, 81);
            this.rightB.TabIndex = 5;
            this.rightB.Text = ">>";
            this.rightB.UseVisualStyleBackColor = true;
            this.rightB.Click += new System.EventHandler(this.RightB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время чтения:";
            // 
            // TimeReadingL
            // 
            this.TimeReadingL.AutoSize = true;
            this.TimeReadingL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeReadingL.Location = new System.Drawing.Point(206, 203);
            this.TimeReadingL.Name = "TimeReadingL";
            this.TimeReadingL.Size = new System.Drawing.Size(56, 22);
            this.TimeReadingL.TabIndex = 7;
            this.TimeReadingL.Text = "00:00";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Snow;
            this.progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progress.Location = new System.Drawing.Point(50, 231);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(800, 23);
            this.progress.TabIndex = 10;
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause.Location = new System.Drawing.Point(375, 113);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(160, 80);
            this.Pause.TabIndex = 11;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Visible = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(371, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Слов прочитанно:";
            // 
            // WordsReadL
            // 
            this.WordsReadL.AutoSize = true;
            this.WordsReadL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsReadL.Location = new System.Drawing.Point(553, 203);
            this.WordsReadL.Name = "WordsReadL";
            this.WordsReadL.Size = new System.Drawing.Size(0, 22);
            this.WordsReadL.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(621, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Слов всего:";
            // 
            // WordsLeftL
            // 
            this.WordsLeftL.AutoSize = true;
            this.WordsLeftL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsLeftL.Location = new System.Drawing.Point(749, 203);
            this.WordsLeftL.Name = "WordsLeftL";
            this.WordsLeftL.Size = new System.Drawing.Size(0, 22);
            this.WordsLeftL.TabIndex = 15;
            // 
            // WPML
            // 
            this.WPML.AutoSize = true;
            this.WPML.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WPML.Location = new System.Drawing.Point(464, 10);
            this.WPML.Name = "WPML";
            this.WPML.Size = new System.Drawing.Size(36, 19);
            this.WPML.TabIndex = 16;
            this.WPML.Text = "100";
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.Location = new System.Drawing.Point(375, 113);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(160, 38);
            this.Continue.TabIndex = 17;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(375, 151);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(160, 41);
            this.Stop.TabIndex = 18;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Visible = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // FontUp
            // 
            this.FontUp.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontUp.Location = new System.Drawing.Point(6, 260);
            this.FontUp.Name = "FontUp";
            this.FontUp.Size = new System.Drawing.Size(38, 31);
            this.FontUp.TabIndex = 19;
            this.FontUp.Text = "+";
            this.FontUp.UseVisualStyleBackColor = true;
            this.FontUp.Click += new System.EventHandler(this.FontUp_Click);
            // 
            // FontDown
            // 
            this.FontDown.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontDown.Location = new System.Drawing.Point(6, 297);
            this.FontDown.Name = "FontDown";
            this.FontDown.Size = new System.Drawing.Size(38, 31);
            this.FontDown.TabIndex = 20;
            this.FontDown.Text = "-";
            this.FontDown.UseVisualStyleBackColor = true;
            this.FontDown.Click += new System.EventHandler(this.FontDown_Click);
            // 
            // Spritz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(892, 568);
            this.Controls.Add(this.FontDown);
            this.Controls.Add(this.FontUp);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.WPML);
            this.Controls.Add(this.WordsLeftL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WordsReadL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.TimeReadingL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightB);
            this.Controls.Add(this.leftB);
            this.Controls.Add(this.labelWpm);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.Spri);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Spritz";
            this.Text = "Sort Of Spritz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Spri;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label labelWpm;
        private System.Windows.Forms.Button leftB;
        private System.Windows.Forms.Button rightB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeReadingL;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WordsReadL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WordsLeftL;
        public System.Windows.Forms.Label WPML;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Stop;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button FontUp;
        private System.Windows.Forms.Button FontDown;
    }
}

