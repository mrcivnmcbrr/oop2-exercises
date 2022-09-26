namespace LabDemo
{
    partial class frmHome
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
            this.lstsource = new System.Windows.Forms.ListBox();
            this.btntaft = new System.Windows.Forms.Button();
            this.btnAyala = new System.Windows.Forms.Button();
            this.btnnorth = new System.Windows.Forms.Button();
            this.btnGMA = new System.Windows.Forms.Button();
            this.btncubao = new System.Windows.Forms.Button();
            this.btnOrtigas = new System.Windows.Forms.Button();
            this.btnsantolan = new System.Windows.Forms.Button();
            this.btnBuendia = new System.Windows.Forms.Button();
            this.btnmagal = new System.Windows.Forms.Button();
            this.btnGuada = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PAYMENT = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.PAYMENT.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOURCE";
            // 
            // lstsource
            // 
            this.lstsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsource.FormattingEnabled = true;
            this.lstsource.ItemHeight = 20;
            this.lstsource.Items.AddRange(new object[] {
            "Taft",
            "Magallanes",
            "Ayala",
            "Buendia",
            "Guadalupe",
            "Boni",
            "Shaw",
            "Ortigas",
            "Santolan",
            "Cubao",
            "GMA",
            "Quezon Ave",
            "North Ave"});
            this.lstsource.Location = new System.Drawing.Point(12, 37);
            this.lstsource.Name = "lstsource";
            this.lstsource.Size = new System.Drawing.Size(126, 284);
            this.lstsource.TabIndex = 1;
            this.lstsource.SelectedIndexChanged += new System.EventHandler(this.lstsource_SelectedIndexChanged);
            // 
            // btntaft
            // 
            this.btntaft.Enabled = false;
            this.btntaft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaft.Location = new System.Drawing.Point(16, 19);
            this.btntaft.Name = "btntaft";
            this.btntaft.Size = new System.Drawing.Size(125, 39);
            this.btntaft.TabIndex = 3;
            this.btntaft.Text = "TAFT";
            this.btntaft.UseVisualStyleBackColor = true;
            // 
            // btnAyala
            // 
            this.btnAyala.Enabled = false;
            this.btnAyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyala.Location = new System.Drawing.Point(16, 64);
            this.btnAyala.Name = "btnAyala";
            this.btnAyala.Size = new System.Drawing.Size(125, 39);
            this.btnAyala.TabIndex = 4;
            this.btnAyala.Text = "AYALA";
            this.btnAyala.UseVisualStyleBackColor = true;
            this.btnAyala.Click += new System.EventHandler(this.btnAyala_Click);
            // 
            // btnnorth
            // 
            this.btnnorth.Enabled = false;
            this.btnnorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnorth.Location = new System.Drawing.Point(182, 199);
            this.btnnorth.Name = "btnnorth";
            this.btnnorth.Size = new System.Drawing.Size(132, 50);
            this.btnnorth.TabIndex = 7;
            this.btnnorth.Text = "NORTH AVE";
            this.btnnorth.UseVisualStyleBackColor = true;
            // 
            // btnGMA
            // 
            this.btnGMA.Enabled = false;
            this.btnGMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMA.Location = new System.Drawing.Point(16, 199);
            this.btnGMA.Name = "btnGMA";
            this.btnGMA.Size = new System.Drawing.Size(125, 39);
            this.btnGMA.TabIndex = 8;
            this.btnGMA.Text = "GMA";
            this.btnGMA.UseVisualStyleBackColor = true;
            // 
            // btncubao
            // 
            this.btncubao.Enabled = false;
            this.btncubao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncubao.Location = new System.Drawing.Point(180, 154);
            this.btncubao.Name = "btncubao";
            this.btncubao.Size = new System.Drawing.Size(134, 39);
            this.btncubao.TabIndex = 9;
            this.btncubao.Text = "CUBAO";
            this.btncubao.UseVisualStyleBackColor = true;
            // 
            // btnOrtigas
            // 
            this.btnOrtigas.Enabled = false;
            this.btnOrtigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrtigas.Location = new System.Drawing.Point(16, 154);
            this.btnOrtigas.Name = "btnOrtigas";
            this.btnOrtigas.Size = new System.Drawing.Size(125, 39);
            this.btnOrtigas.TabIndex = 10;
            this.btnOrtigas.Text = "ORTIGAS";
            this.btnOrtigas.UseVisualStyleBackColor = true;
            // 
            // btnsantolan
            // 
            this.btnsantolan.Enabled = false;
            this.btnsantolan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsantolan.Location = new System.Drawing.Point(180, 109);
            this.btnsantolan.Name = "btnsantolan";
            this.btnsantolan.Size = new System.Drawing.Size(134, 39);
            this.btnsantolan.TabIndex = 11;
            this.btnsantolan.Text = "SANTOLAN";
            this.btnsantolan.UseVisualStyleBackColor = true;
            // 
            // btnBuendia
            // 
            this.btnBuendia.Enabled = false;
            this.btnBuendia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuendia.Location = new System.Drawing.Point(180, 64);
            this.btnBuendia.Name = "btnBuendia";
            this.btnBuendia.Size = new System.Drawing.Size(134, 39);
            this.btnBuendia.TabIndex = 13;
            this.btnBuendia.Text = "BUENDIA";
            this.btnBuendia.UseVisualStyleBackColor = true;
            this.btnBuendia.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnmagal
            // 
            this.btnmagal.Enabled = false;
            this.btnmagal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmagal.Location = new System.Drawing.Point(180, 19);
            this.btnmagal.Name = "btnmagal";
            this.btnmagal.Size = new System.Drawing.Size(134, 39);
            this.btnmagal.TabIndex = 14;
            this.btnmagal.Text = "MAGALLANES";
            this.btnmagal.UseVisualStyleBackColor = true;
            // 
            // btnGuada
            // 
            this.btnGuada.Enabled = false;
            this.btnGuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuada.Location = new System.Drawing.Point(16, 109);
            this.btnGuada.Name = "btnGuada";
            this.btnGuada.Size = new System.Drawing.Size(129, 39);
            this.btnGuada.TabIndex = 15;
            this.btnGuada.Text = "GUADALUPE";
            this.btnGuada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnorth);
            this.groupBox1.Controls.Add(this.btnGMA);
            this.groupBox1.Controls.Add(this.btncubao);
            this.groupBox1.Controls.Add(this.btnOrtigas);
            this.groupBox1.Controls.Add(this.btnsantolan);
            this.groupBox1.Controls.Add(this.btnGuada);
            this.groupBox1.Controls.Add(this.btntaft);
            this.groupBox1.Controls.Add(this.btnBuendia);
            this.groupBox1.Controls.Add(this.btnmagal);
            this.groupBox1.Controls.Add(this.btnAyala);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(144, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 274);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT DESTINATION";
            // 
            // PAYMENT
            // 
            this.PAYMENT.Controls.Add(this.lblPrice);
            this.PAYMENT.Controls.Add(this.lbltotal);
            this.PAYMENT.Controls.Add(this.label5);
            this.PAYMENT.Controls.Add(this.txtchange);
            this.PAYMENT.Controls.Add(this.label4);
            this.PAYMENT.Controls.Add(this.txtcash);
            this.PAYMENT.Controls.Add(this.label3);
            this.PAYMENT.Controls.Add(this.label2);
            this.PAYMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAYMENT.Location = new System.Drawing.Point(481, 46);
            this.PAYMENT.Name = "PAYMENT";
            this.PAYMENT.Size = new System.Drawing.Size(284, 240);
            this.PAYMENT.TabIndex = 17;
            this.PAYMENT.TabStop = false;
            this.PAYMENT.Text = "PAYMENT";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(123, 29);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 20);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "<<price here>>";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(123, 190);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(112, 20);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "<<total here>>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL:";
            // 
            // txtchange
            // 
            this.txtchange.Enabled = false;
            this.txtchange.Location = new System.Drawing.Point(127, 113);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(104, 26);
            this.txtchange.TabIndex = 5;
            this.txtchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change:";
            // 
            // txtcash
            // 
            this.txtcash.Location = new System.Drawing.Point(127, 68);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(104, 26);
            this.txtcash.TabIndex = 3;
            this.txtcash.TextChanged += new System.EventHandler(this.txtcash_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cash on Hand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(491, 307);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(274, 29);
            this.btnPayment.TabIndex = 18;
            this.btnPayment.Text = "PAY";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkRouteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkRouteToolStripMenuItem
            // 
            this.checkRouteToolStripMenuItem.Name = "checkRouteToolStripMenuItem";
            this.checkRouteToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.checkRouteToolStripMenuItem.Text = "Check Route";
            this.checkRouteToolStripMenuItem.Click += new System.EventHandler(this.checkRouteToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 348);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lstsource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PAYMENT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.PAYMENT.ResumeLayout(false);
            this.PAYMENT.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstsource;
        private System.Windows.Forms.Button btntaft;
        private System.Windows.Forms.Button btnAyala;
        private System.Windows.Forms.Button btnnorth;
        private System.Windows.Forms.Button btnGMA;
        private System.Windows.Forms.Button btncubao;
        private System.Windows.Forms.Button btnOrtigas;
        private System.Windows.Forms.Button btnsantolan;
        private System.Windows.Forms.Button btnBuendia;
        private System.Windows.Forms.Button btnmagal;
        private System.Windows.Forms.Button btnGuada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox PAYMENT;
        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkRouteToolStripMenuItem;
    }
}