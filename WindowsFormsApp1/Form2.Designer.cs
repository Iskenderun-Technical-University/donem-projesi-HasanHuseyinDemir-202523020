namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtsatiş = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.txtaliş = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsatiş
            // 
            this.txtsatiş.Location = new System.Drawing.Point(211, 144);
            this.txtsatiş.Name = "txtsatiş";
            this.txtsatiş.Size = new System.Drawing.Size(100, 20);
            this.txtsatiş.TabIndex = 0;
            this.txtsatiş.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(211, 62);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 0;
            this.txtad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Kodu";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(211, 92);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(100, 20);
            this.txtkod.TabIndex = 0;
            this.txtkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtaliş
            // 
            this.txtaliş.Location = new System.Drawing.Point(211, 118);
            this.txtaliş.Name = "txtaliş";
            this.txtaliş.Size = new System.Drawing.Size(100, 20);
            this.txtaliş.TabIndex = 0;
            this.txtaliş.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Alış Fiyatı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(336, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ana Sayfa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(160, 182);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(261, 182);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 309);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtkod);
            this.Controls.Add(this.txtaliş);
            this.Controls.Add(this.txtsatiş);
            this.Name = "Form2";
            this.Text = "ÜrünEkle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsatiş;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.TextBox txtaliş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btniptal;
    }
}