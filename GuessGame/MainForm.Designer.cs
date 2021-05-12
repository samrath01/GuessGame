
namespace GuessGame
{
    partial class MainForm
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
            this.pictureStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressChance = new System.Windows.Forms.ProgressBar();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPress = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureStatus
            // 
            this.pictureStatus.Image = global::GuessGame.Properties.Resources.head_gun;
            this.pictureStatus.Location = new System.Drawing.Point(326, 97);
            this.pictureStatus.Name = "pictureStatus";
            this.pictureStatus.Size = new System.Drawing.Size(423, 231);
            this.pictureStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStatus.TabIndex = 0;
            this.pictureStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Russian Roulette Game";
            // 
            // progressChance
            // 
            this.progressChance.Location = new System.Drawing.Point(457, 358);
            this.progressChance.Maximum = 3;
            this.progressChance.Name = "progressChance";
            this.progressChance.Size = new System.Drawing.Size(676, 52);
            this.progressChance.Step = 1;
            this.progressChance.TabIndex = 2;
            this.progressChance.Value = 3;
            // 
            // labelChance
            // 
            this.labelChance.AutoSize = true;
            this.labelChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChance.Location = new System.Drawing.Point(12, 364);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(376, 39);
            this.labelChance.TabIndex = 3;
            this.labelChance.Text = "Number of Chances: 3";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(12, 446);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(233, 46);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Start Game";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(59, 532);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(274, 92);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(368, 532);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(351, 92);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(759, 532);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(351, 92);
            this.btnSpin.TabIndex = 7;
            this.btnSpin.Text = "Spin Bullet";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnPress
            // 
            this.btnPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPress.Location = new System.Drawing.Point(59, 648);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(660, 92);
            this.btnPress.TabIndex = 8;
            this.btnPress.Text = "Press The Trigger";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(759, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(351, 92);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 752);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelChance);
            this.Controls.Add(this.progressChance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressChance;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnExit;
    }
}