namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.market_otomasyonDataSet = new WindowsFormsApp1.market_otomasyonDataSet();
            this.urunekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunekleTableAdapter = new WindowsFormsApp1.market_otomasyonDataSetTableAdapters.urunekleTableAdapter();
            this.market_otomasyonDataSet3 = new WindowsFormsApp1.market_otomasyonDataSet3();
            this.urunekleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunekleTableAdapter1 = new WindowsFormsApp1.market_otomasyonDataSet3TableAdapters.urunekleTableAdapter();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunsatişDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunadiDataGridViewTextBoxColumn,
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunsatişDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunekleBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(222, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // market_otomasyonDataSet
            // 
            this.market_otomasyonDataSet.DataSetName = "market_otomasyonDataSet";
            this.market_otomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunekleBindingSource
            // 
            this.urunekleBindingSource.DataMember = "urunekle";
            this.urunekleBindingSource.DataSource = this.market_otomasyonDataSet;
            // 
            // urunekleTableAdapter
            // 
            this.urunekleTableAdapter.ClearBeforeFill = true;
            // 
            // market_otomasyonDataSet3
            // 
            this.market_otomasyonDataSet3.DataSetName = "market_otomasyonDataSet3";
            this.market_otomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunekleBindingSource1
            // 
            this.urunekleBindingSource1.DataMember = "urunekle";
            this.urunekleBindingSource1.DataSource = this.market_otomasyonDataSet3;
            // 
            // urunekleTableAdapter1
            // 
            this.urunekleTableAdapter1.ClearBeforeFill = true;
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
            // urunsatişDataGridViewTextBoxColumn
            // 
            this.urunsatişDataGridViewTextBoxColumn.DataPropertyName = "urunsatiş";
            this.urunsatişDataGridViewTextBoxColumn.HeaderText = "urunsatiş";
            this.urunsatişDataGridViewTextBoxColumn.Name = "urunsatişDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.market_otomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunekleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private market_otomasyonDataSet market_otomasyonDataSet;
        private System.Windows.Forms.BindingSource urunekleBindingSource;
        private market_otomasyonDataSetTableAdapters.urunekleTableAdapter urunekleTableAdapter;
        private market_otomasyonDataSet3 market_otomasyonDataSet3;
        private System.Windows.Forms.BindingSource urunekleBindingSource1;
        private market_otomasyonDataSet3TableAdapters.urunekleTableAdapter urunekleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunsatişDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}