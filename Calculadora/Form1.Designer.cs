namespace Calculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbloper = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2:";
            // 
            // lbloper
            // 
            this.lbloper.AutoSize = true;
            this.lbloper.Location = new System.Drawing.Point(303, 136);
            this.lbloper.Name = "lbloper";
            this.lbloper.Size = new System.Drawing.Size(16, 13);
            this.lbloper.TabIndex = 2;
            this.lbloper.Text = "...";
            this.lbloper.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(60, 271);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(347, 23);
            this.lblresult.TabIndex = 3;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOper1
            // 
            this.numOper1.Location = new System.Drawing.Point(186, 71);
            this.numOper1.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(55, 20);
            this.numOper1.TabIndex = 5;
            // 
            // numOper2
            // 
            this.numOper2.Location = new System.Drawing.Point(186, 169);
            this.numOper2.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(55, 20);
            this.numOper2.TabIndex = 6;
            this.numOper2.ValueChanged += new System.EventHandler(this.numOper2_ValueChanged);
            // 
            // btsoma
            // 
            this.btsoma.Location = new System.Drawing.Point(117, 106);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(40, 43);
            this.btsoma.TabIndex = 7;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.btsoma_Click);
            // 
            // btsub
            // 
            this.btsub.Location = new System.Drawing.Point(163, 106);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(43, 43);
            this.btsub.TabIndex = 8;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.btsub_Click);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(212, 106);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(38, 43);
            this.btmult.TabIndex = 9;
            this.btmult.Text = "X";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.btmult_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(256, 106);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(41, 43);
            this.btdiv.TabIndex = 10;
            this.btdiv.Text = "÷";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // btigual
            // 
            this.btigual.Enabled = false;
            this.btigual.Location = new System.Drawing.Point(186, 210);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(106, 33);
            this.btigual.TabIndex = 11;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbloper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbloper;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btigual;
    }
}

