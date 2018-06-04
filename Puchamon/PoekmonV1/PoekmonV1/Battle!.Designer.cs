namespace PoekmonV1
{
    partial class Battle_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle_));
            this.pctPokeFight1 = new System.Windows.Forms.PictureBox();
            this.pctFoePokeF = new System.Windows.Forms.PictureBox();
            this.lblNameu = new System.Windows.Forms.Label();
            this.pbrFoesLife = new System.Windows.Forms.ProgressBar();
            this.pbrYourLife = new System.Windows.Forms.ProgressBar();
            this.txtActions = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pctTextFrame = new System.Windows.Forms.PictureBox();
            this.txtFoesActions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.txtHp1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pctObjs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPokeFight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoePokeF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTextFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObjs)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPokeFight1
            // 
            this.pctPokeFight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctPokeFight1.BackColor = System.Drawing.Color.Transparent;
            this.pctPokeFight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctPokeFight1.Image = ((System.Drawing.Image)(resources.GetObject("pctPokeFight1.Image")));
            this.pctPokeFight1.ImageLocation = "";
            this.pctPokeFight1.Location = new System.Drawing.Point(50, 245);
            this.pctPokeFight1.Name = "pctPokeFight1";
            this.pctPokeFight1.Size = new System.Drawing.Size(120, 115);
            this.pctPokeFight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPokeFight1.TabIndex = 0;
            this.pctPokeFight1.TabStop = false;
            // 
            // pctFoePokeF
            // 
            this.pctFoePokeF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctFoePokeF.BackColor = System.Drawing.Color.Transparent;
            this.pctFoePokeF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctFoePokeF.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctFoePokeF.ErrorImage")));
            this.pctFoePokeF.Image = ((System.Drawing.Image)(resources.GetObject("pctFoePokeF.Image")));
            this.pctFoePokeF.Location = new System.Drawing.Point(317, 245);
            this.pctFoePokeF.Name = "pctFoePokeF";
            this.pctFoePokeF.Size = new System.Drawing.Size(120, 115);
            this.pctFoePokeF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoePokeF.TabIndex = 1;
            this.pctFoePokeF.TabStop = false;
            // 
            // lblNameu
            // 
            this.lblNameu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameu.AutoSize = true;
            this.lblNameu.BackColor = System.Drawing.Color.Transparent;
            this.lblNameu.Location = new System.Drawing.Point(84, 225);
            this.lblNameu.Name = "lblNameu";
            this.lblNameu.Size = new System.Drawing.Size(52, 17);
            this.lblNameu.TabIndex = 2;
            this.lblNameu.Text = "Pony 1";
            // 
            // pbrFoesLife
            // 
            this.pbrFoesLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrFoesLife.Location = new System.Drawing.Point(330, 366);
            this.pbrFoesLife.Maximum = 30;
            this.pbrFoesLife.Name = "pbrFoesLife";
            this.pbrFoesLife.Size = new System.Drawing.Size(100, 23);
            this.pbrFoesLife.Step = 7;
            this.pbrFoesLife.TabIndex = 3;
            this.pbrFoesLife.Value = 30;
            // 
            // pbrYourLife
            // 
            this.pbrYourLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrYourLife.Location = new System.Drawing.Point(61, 366);
            this.pbrYourLife.Maximum = 30;
            this.pbrYourLife.Name = "pbrYourLife";
            this.pbrYourLife.Size = new System.Drawing.Size(100, 23);
            this.pbrYourLife.TabIndex = 4;
            this.pbrYourLife.Value = 30;
            // 
            // txtActions
            // 
            this.txtActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActions.Location = new System.Drawing.Point(12, 14);
            this.txtActions.Name = "txtActions";
            this.txtActions.ReadOnly = true;
            this.txtActions.Size = new System.Drawing.Size(228, 15);
            this.txtActions.TabIndex = 5;
            // 
            // btnAttack
            // 
            this.btnAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttack.Location = new System.Drawing.Point(274, 12);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnDefend
            // 
            this.btnDefend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefend.Location = new System.Drawing.Point(274, 41);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(75, 23);
            this.btnDefend.TabIndex = 1;
            this.btnDefend.Text = "Defense";
            this.btnDefend.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(380, 14);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run like a pussy";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // pctTextFrame
            // 
            this.pctTextFrame.BackColor = System.Drawing.SystemColors.Control;
            this.pctTextFrame.Image = ((System.Drawing.Image)(resources.GetObject("pctTextFrame.Image")));
            this.pctTextFrame.Location = new System.Drawing.Point(0, 0);
            this.pctTextFrame.Name = "pctTextFrame";
            this.pctTextFrame.Size = new System.Drawing.Size(256, 90);
            this.pctTextFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTextFrame.TabIndex = 11;
            this.pctTextFrame.TabStop = false;
            // 
            // txtFoesActions
            // 
            this.txtFoesActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoesActions.Location = new System.Drawing.Point(13, 51);
            this.txtFoesActions.Name = "txtFoesActions";
            this.txtFoesActions.ReadOnly = true;
            this.txtFoesActions.Size = new System.Drawing.Size(227, 15);
            this.txtFoesActions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(352, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pony 2";
            // 
            // btnHeal
            // 
            this.btnHeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeal.Location = new System.Drawing.Point(380, 43);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(75, 23);
            this.btnHeal.TabIndex = 1;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            // 
            // txtHp1
            // 
            this.txtHp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHp1.BackColor = System.Drawing.Color.Wheat;
            this.txtHp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHp1.Location = new System.Drawing.Point(50, 366);
            this.txtHp1.Name = "txtHp1";
            this.txtHp1.ReadOnly = true;
            this.txtHp1.Size = new System.Drawing.Size(30, 15);
            this.txtHp1.TabIndex = 14;
            this.txtHp1.Text = "HP";
            this.txtHp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(319, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(30, 15);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "HP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pctObjs
            // 
            this.pctObjs.BackColor = System.Drawing.Color.Transparent;
            this.pctObjs.Location = new System.Drawing.Point(13, 14);
            this.pctObjs.Name = "pctObjs";
            this.pctObjs.Size = new System.Drawing.Size(227, 65);
            this.pctObjs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctObjs.TabIndex = 16;
            this.pctObjs.TabStop = false;
            // 
            // Battle_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHp1);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoesActions);
            this.Controls.Add(this.pctFoePokeF);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtActions);
            this.Controls.Add(this.pbrYourLife);
            this.Controls.Add(this.pbrFoesLife);
            this.Controls.Add(this.lblNameu);
            this.Controls.Add(this.pctPokeFight1);
            this.Controls.Add(this.pctObjs);
            this.Controls.Add(this.pctTextFrame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Battle_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle!";
            ((System.ComponentModel.ISupportInitialize)(this.pctPokeFight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoePokeF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTextFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctObjs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPokeFight1;
        private System.Windows.Forms.PictureBox pctFoePokeF;
        private System.Windows.Forms.Label lblNameu;
        private System.Windows.Forms.ProgressBar pbrFoesLife;
        private System.Windows.Forms.ProgressBar pbrYourLife;
        private System.Windows.Forms.TextBox txtActions;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox pctTextFrame;
        private System.Windows.Forms.TextBox txtFoesActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.TextBox txtHp1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pctObjs;
    }
}