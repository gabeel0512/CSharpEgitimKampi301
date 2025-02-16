namespace CSharpEgitimKampi301.EfProject
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
            this.components = new System.ComponentModel.Container();
            this.RehberId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.guideTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egitimKampiEfTravelDbDataSet = new CSharpEgitimKampi301.EfProject.EgitimKampiEfTravelDbDataSet();
            this.guideTblTableAdapter = new CSharpEgitimKampi301.EfProject.EgitimKampiEfTravelDbDataSetTableAdapters.GuideTblTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.RehberName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.RehberSurname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guideTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimKampiEfTravelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RehberId
            // 
            this.RehberId.AutoSize = true;
            this.RehberId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RehberId.Location = new System.Drawing.Point(35, 45);
            this.RehberId.Name = "RehberId";
            this.RehberId.Size = new System.Drawing.Size(60, 13);
            this.RehberId.TabIndex = 0;
            this.RehberId.Text = "Rehber Id :";
            this.RehberId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(194, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.Info;
            this.btnList.Location = new System.Drawing.Point(125, 185);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(180, 36);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // guideTblBindingSource
            // 
            this.guideTblBindingSource.DataMember = "GuideTbl";
            this.guideTblBindingSource.DataSource = this.egitimKampiEfTravelDbDataSet;
            // 
            // egitimKampiEfTravelDbDataSet
            // 
            this.egitimKampiEfTravelDbDataSet.DataSetName = "EgitimKampiEfTravelDbDataSet";
            this.egitimKampiEfTravelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guideTblTableAdapter
            // 
            this.guideTblTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 5;
            // 
            // RehberName
            // 
            this.RehberName.AutoSize = true;
            this.RehberName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RehberName.Location = new System.Drawing.Point(29, 88);
            this.RehberName.Name = "RehberName";
            this.RehberName.Size = new System.Drawing.Size(66, 13);
            this.RehberName.TabIndex = 4;
            this.RehberName.Text = "Rehber Adý :";
            this.RehberName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(111, 130);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(194, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // RehberSurname
            // 
            this.RehberSurname.AutoSize = true;
            this.RehberSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RehberSurname.Location = new System.Drawing.Point(12, 134);
            this.RehberSurname.Name = "RehberSurname";
            this.RehberSurname.Size = new System.Drawing.Size(83, 13);
            this.RehberSurname.TabIndex = 6;
            this.RehberSurname.Text = "Rehber Soyadý :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(125, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(125, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.SystemColors.Info;
            this.btnGetById.Location = new System.Drawing.Point(125, 353);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(180, 36);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "Id\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(125, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 348);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.RehberSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.RehberName);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.RehberId);
            this.Name = "Form1";
            this.Text = "Rehber Ýþlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guideTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimKampiEfTravelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RehberId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnList;
        private EgitimKampiEfTravelDbDataSet egitimKampiEfTravelDbDataSet;
        private System.Windows.Forms.BindingSource guideTblBindingSource;
        private EgitimKampiEfTravelDbDataSetTableAdapters.GuideTblTableAdapter guideTblTableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label RehberName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label RehberSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

