namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.market_otomasyonDataSet7 = new WindowsFormsApp1.market_otomasyonDataSet7();
            this.urunekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunekleTableAdapter = new WindowsFormsApp1.market_otomasyonDataSet7TableAdapters.urunekleTableAdapter();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(36, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunadiDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunmiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunekleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(191, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // market_otomasyonDataSet7
            // 
            this.market_otomasyonDataSet7.DataSetName = "market_otomasyonDataSet7";
            this.market_otomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunekleBindingSource
            // 
            this.urunekleBindingSource.DataMember = "urunekle";
            this.urunekleBindingSource.DataSource = this.market_otomasyonDataSet7;
            // 
            // urunekleTableAdapter
            // 
            this.urunekleTableAdapter.ClearBeforeFill = true;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // urunmiktarDataGridViewTextBoxColumn
            // 
            this.urunmiktarDataGridViewTextBoxColumn.DataPropertyName = "urunmiktar";
            this.urunmiktarDataGridViewTextBoxColumn.HeaderText = "urunmiktar";
            this.urunmiktarDataGridViewTextBoxColumn.Name = "urunmiktarDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private market_otomasyonDataSet7 market_otomasyonDataSet7;
        private System.Windows.Forms.BindingSource urunekleBindingSource;
        private market_otomasyonDataSet7TableAdapters.urunekleTableAdapter urunekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmiktarDataGridViewTextBoxColumn;
    }
}