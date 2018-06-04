namespace PoekmonV1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtPokes1 = new System.Windows.Forms.TextBox();
            this.txtPoke2 = new System.Windows.Forms.TextBox();
            this.pctPokePick1 = new System.Windows.Forms.PictureBox();
            this.pctPokePick2 = new System.Windows.Forms.PictureBox();
            this.txtPrepare1 = new System.Windows.Forms.TextBox();
            this.btnBattle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPokePick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPokePick2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Poke1",
            "Poke2",
            "Poke3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Poke1",
            "Poke2",
            "Poke3"});
            this.comboBox2.Location = new System.Drawing.Point(352, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtPokes1
            // 
            this.txtPokes1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPokes1.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPokes1.Location = new System.Drawing.Point(23, 44);
            this.txtPokes1.Name = "txtPokes1";
            this.txtPokes1.ReadOnly = true;
            this.txtPokes1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPokes1.Size = new System.Drawing.Size(100, 18);
            this.txtPokes1.TabIndex = 4;
            this.txtPokes1.Text = "Your Poke";
            this.txtPokes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPoke2
            // 
            this.txtPoke2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoke2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoke2.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoke2.Location = new System.Drawing.Point(362, 41);
            this.txtPoke2.Name = "txtPoke2";
            this.txtPoke2.ReadOnly = true;
            this.txtPoke2.Size = new System.Drawing.Size(100, 18);
            this.txtPoke2.TabIndex = 4;
            this.txtPoke2.Text = "Foes Poke";
            this.txtPoke2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pctPokePick1
            // 
            this.pctPokePick1.Image = ((System.Drawing.Image)(resources.GetObject("pctPokePick1.Image")));
            this.pctPokePick1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctPokePick1.InitialImage")));
            this.pctPokePick1.Location = new System.Drawing.Point(12, 129);
            this.pctPokePick1.Name = "pctPokePick1";
            this.pctPokePick1.Size = new System.Drawing.Size(120, 120);
            this.pctPokePick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPokePick1.TabIndex = 4;
            this.pctPokePick1.TabStop = false;
            this.pctPokePick1.WaitOnLoad = true;
            // 
            // pctPokePick2
            // 
            this.pctPokePick2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctPokePick2.Image = ((System.Drawing.Image)(resources.GetObject("pctPokePick2.Image")));
            this.pctPokePick2.Location = new System.Drawing.Point(352, 129);
            this.pctPokePick2.Name = "pctPokePick2";
            this.pctPokePick2.Size = new System.Drawing.Size(120, 120);
            this.pctPokePick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPokePick2.TabIndex = 5;
            this.pctPokePick2.TabStop = false;
            // 
            // txtPrepare1
            // 
            this.txtPrepare1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrepare1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrepare1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrepare1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrepare1.ForeColor = System.Drawing.Color.Black;
            this.txtPrepare1.Location = new System.Drawing.Point(167, 12);
            this.txtPrepare1.Name = "txtPrepare1";
            this.txtPrepare1.ReadOnly = true;
            this.txtPrepare1.Size = new System.Drawing.Size(212, 23);
            this.txtPrepare1.TabIndex = 4;
            this.txtPrepare1.Text = "Prepare for Battle";
            this.txtPrepare1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBattle
            // 
            this.btnBattle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBattle.Location = new System.Drawing.Point(182, 306);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(133, 31);
            this.btnBattle.TabIndex = 3;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.txtPrepare1);
            this.Controls.Add(this.pctPokePick2);
            this.Controls.Add(this.pctPokePick1);
            this.Controls.Add(this.txtPoke2);
            this.Controls.Add(this.txtPokes1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pctPokePick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPokePick2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtPokes1;
        private System.Windows.Forms.TextBox txtPoke2;
        private System.Windows.Forms.PictureBox pctPokePick1;
        private System.Windows.Forms.PictureBox pctPokePick2;
        private System.Windows.Forms.TextBox txtPrepare1;
        private System.Windows.Forms.Button btnBattle;
    }
}

