namespace SynergyCalculation
{
    partial class frmSynergyCalculation
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLvlMax = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btnNormal6 = new System.Windows.Forms.RadioButton();
            this.btnLendaria = new System.Windows.Forms.RadioButton();
            this.numStatMin = new System.Windows.Forms.NumericUpDown();
            this.numStatMax = new System.Windows.Forms.NumericUpDown();
            this.numLvlAtual = new System.Windows.Forms.NumericUpDown();
            this.txtReliquia = new System.Windows.Forms.TextBox();
            this.lblReliquia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNormal5 = new System.Windows.Forms.RadioButton();
            this.btnNormal7 = new System.Windows.Forms.RadioButton();
            this.btn40 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvlAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(63, 251);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(377, 71);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLvlMax
            // 
            this.txtLvlMax.Location = new System.Drawing.Point(460, 345);
            this.txtLvlMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLvlMax.Name = "txtLvlMax";
            this.txtLvlMax.Size = new System.Drawing.Size(32, 22);
            this.txtLvlMax.TabIndex = 0;
            this.txtLvlMax.TabStop = false;
            this.txtLvlMax.Text = "30";
            this.txtLvlMax.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(360, 75);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(79, 51);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status Lvl 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status Lvl Máx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level Atual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Resultado";
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(195, 162);
            this.btn20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(36, 25);
            this.btn20.TabIndex = 5;
            this.btn20.TabStop = false;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(239, 162);
            this.btn25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(36, 25);
            this.btn25.TabIndex = 6;
            this.btn25.TabStop = false;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(283, 162);
            this.btn30.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(36, 25);
            this.btn30.TabIndex = 7;
            this.btn30.TabStop = false;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // btn35
            // 
            this.btn35.Location = new System.Drawing.Point(327, 162);
            this.btn35.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(36, 25);
            this.btn35.TabIndex = 8;
            this.btn35.TabStop = false;
            this.btn35.Text = "35";
            this.btn35.UseVisualStyleBackColor = true;
            this.btn35.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(415, 162);
            this.btn50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(36, 25);
            this.btn50.TabIndex = 10;
            this.btn50.TabStop = false;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // btnNormal6
            // 
            this.btnNormal6.AutoSize = true;
            this.btnNormal6.Location = new System.Drawing.Point(148, 209);
            this.btnNormal6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNormal6.Name = "btnNormal6";
            this.btnNormal6.Size = new System.Drawing.Size(78, 21);
            this.btnNormal6.TabIndex = 12;
            this.btnNormal6.Text = "Base 6*";
            this.btnNormal6.UseVisualStyleBackColor = true;
            this.btnNormal6.CheckedChanged += new System.EventHandler(this.BtnNormal6_CheckedChanged);
            // 
            // btnLendaria
            // 
            this.btnLendaria.AutoSize = true;
            this.btnLendaria.Location = new System.Drawing.Point(329, 209);
            this.btnLendaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLendaria.Name = "btnLendaria";
            this.btnLendaria.Size = new System.Drawing.Size(120, 21);
            this.btnLendaria.TabIndex = 14;
            this.btnLendaria.Text = "Relic Lendária";
            this.btnLendaria.UseVisualStyleBackColor = true;
            this.btnLendaria.CheckedChanged += new System.EventHandler(this.BtnLendaria_CheckedChanged);
            // 
            // numStatMin
            // 
            this.numStatMin.AutoSize = true;
            this.numStatMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numStatMin.Location = new System.Drawing.Point(128, 66);
            this.numStatMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numStatMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatMin.Name = "numStatMin";
            this.numStatMin.Size = new System.Drawing.Size(59, 22);
            this.numStatMin.TabIndex = 2;
            this.numStatMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStatMin.ValueChanged += new System.EventHandler(this.NumStatMin_ValueChanged);
            this.numStatMin.Validated += new System.EventHandler(this.NumStatMin_ValueChanged);
            // 
            // numStatMax
            // 
            this.numStatMax.AutoSize = true;
            this.numStatMax.Location = new System.Drawing.Point(128, 114);
            this.numStatMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numStatMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatMax.Name = "numStatMax";
            this.numStatMax.Size = new System.Drawing.Size(59, 22);
            this.numStatMax.TabIndex = 3;
            this.numStatMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStatMax.ValueChanged += new System.EventHandler(this.NumStatMax_ValueChanged);
            this.numStatMax.Validated += new System.EventHandler(this.NumStatMax_ValueChanged);
            // 
            // numLvlAtual
            // 
            this.numLvlAtual.AutoSize = true;
            this.numLvlAtual.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLvlAtual.Location = new System.Drawing.Point(128, 162);
            this.numLvlAtual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numLvlAtual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLvlAtual.Name = "numLvlAtual";
            this.numLvlAtual.Size = new System.Drawing.Size(59, 22);
            this.numLvlAtual.TabIndex = 4;
            this.numLvlAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLvlAtual.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numLvlAtual.ValueChanged += new System.EventHandler(this.NumLvlAtual_ValueChanged);
            this.numLvlAtual.Validated += new System.EventHandler(this.NumLvlAtual_ValueChanged);
            // 
            // txtReliquia
            // 
            this.txtReliquia.Location = new System.Drawing.Point(127, 18);
            this.txtReliquia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReliquia.Name = "txtReliquia";
            this.txtReliquia.Size = new System.Drawing.Size(341, 22);
            this.txtReliquia.TabIndex = 1;
            this.txtReliquia.TextChanged += new System.EventHandler(this.TxtReliquia_TextChanged);
            this.txtReliquia.Validated += new System.EventHandler(this.TxtReliquia_TextChanged);
            // 
            // lblReliquia
            // 
            this.lblReliquia.AutoSize = true;
            this.lblReliquia.Location = new System.Drawing.Point(59, 22);
            this.lblReliquia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReliquia.Name = "lblReliquia";
            this.lblReliquia.Size = new System.Drawing.Size(59, 17);
            this.lblReliquia.TabIndex = 0;
            this.lblReliquia.Text = "Reliquia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(40, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "OBS: Veja o Max(Combined) no site oficial para o\nStatus Lvl Máx";
            // 
            // btnNormal5
            // 
            this.btnNormal5.AutoSize = true;
            this.btnNormal5.Checked = true;
            this.btnNormal5.Location = new System.Drawing.Point(57, 209);
            this.btnNormal5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNormal5.Name = "btnNormal5";
            this.btnNormal5.Size = new System.Drawing.Size(78, 21);
            this.btnNormal5.TabIndex = 11;
            this.btnNormal5.TabStop = true;
            this.btnNormal5.Text = "Base 5*";
            this.btnNormal5.UseVisualStyleBackColor = true;
            this.btnNormal5.CheckedChanged += new System.EventHandler(this.BtnNormal5_CheckedChanged);
            // 
            // btnNormal7
            // 
            this.btnNormal7.AutoSize = true;
            this.btnNormal7.Location = new System.Drawing.Point(239, 209);
            this.btnNormal7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNormal7.Name = "btnNormal7";
            this.btnNormal7.Size = new System.Drawing.Size(78, 21);
            this.btnNormal7.TabIndex = 13;
            this.btnNormal7.Text = "Base 7*";
            this.btnNormal7.UseVisualStyleBackColor = true;
            this.btnNormal7.CheckedChanged += new System.EventHandler(this.BtnNormal7_CheckedChanged);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(371, 162);
            this.btn40.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(36, 25);
            this.btn40.TabIndex = 9;
            this.btn40.TabStop = false;
            this.btn40.Text = "40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.BtnLvlAtual_Click);
            // 
            // frmSynergyCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(499, 380);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btnNormal7);
            this.Controls.Add(this.btnNormal5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReliquia);
            this.Controls.Add(this.txtReliquia);
            this.Controls.Add(this.numLvlAtual);
            this.Controls.Add(this.numStatMax);
            this.Controls.Add(this.numStatMin);
            this.Controls.Add(this.btnLendaria);
            this.Controls.Add(this.btnNormal6);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn35);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtLvlMax);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSynergyCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synergy Calculator";
            this.Load += new System.EventHandler(this.FrmSynergyCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvlAtual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtLvlMax;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.RadioButton btnNormal5;
        private System.Windows.Forms.RadioButton btnNormal6;
        private System.Windows.Forms.RadioButton btnNormal7;
        private System.Windows.Forms.RadioButton btnLendaria;
        private System.Windows.Forms.NumericUpDown numStatMin;
        private System.Windows.Forms.NumericUpDown numStatMax;
        private System.Windows.Forms.NumericUpDown numLvlAtual;
        private System.Windows.Forms.TextBox txtReliquia;
        private System.Windows.Forms.Label lblReliquia;
        private System.Windows.Forms.Label label4;
        
        
    }
}

