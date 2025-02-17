namespace CSharpEgitimKampi301.EfProject
{
    partial class FrmLocation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLocationCountry = new System.Windows.Forms.TextBox();
            this.RehberSurname = new System.Windows.Forms.Label();
            this.txtLocationCity = new System.Windows.Forms.TextBox();
            this.RehberName = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.LokasyonId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationDayNight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLocationCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocationCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1091, 527);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(127, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 36);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(127, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 36);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(127, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLocationCountry
            // 
            this.txtLocationCountry.Location = new System.Drawing.Point(127, 64);
            this.txtLocationCountry.Name = "txtLocationCountry";
            this.txtLocationCountry.Size = new System.Drawing.Size(194, 20);
            this.txtLocationCountry.TabIndex = 20;
            // 
            // RehberSurname
            // 
            this.RehberSurname.AutoSize = true;
            this.RehberSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RehberSurname.Location = new System.Drawing.Point(86, 68);
            this.RehberSurname.Name = "RehberSurname";
            this.RehberSurname.Size = new System.Drawing.Size(35, 13);
            this.RehberSurname.TabIndex = 19;
            this.RehberSurname.Text = "Ülke :";
            // 
            // txtLocationCity
            // 
            this.txtLocationCity.Location = new System.Drawing.Point(127, 38);
            this.txtLocationCity.Name = "txtLocationCity";
            this.txtLocationCity.Size = new System.Drawing.Size(194, 20);
            this.txtLocationCity.TabIndex = 18;
            // 
            // RehberName
            // 
            this.RehberName.AutoSize = true;
            this.RehberName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RehberName.Location = new System.Drawing.Point(84, 42);
            this.RehberName.Name = "RehberName";
            this.RehberName.Size = new System.Drawing.Size(37, 13);
            this.RehberName.TabIndex = 17;
            this.RehberName.Text = "Þehir :";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.Info;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(127, 241);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(180, 36);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtLocationId
            // 
            this.txtLocationId.Location = new System.Drawing.Point(127, 12);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.Size = new System.Drawing.Size(194, 20);
            this.txtLocationId.TabIndex = 15;
            // 
            // LokasyonId
            // 
            this.LokasyonId.AutoSize = true;
            this.LokasyonId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LokasyonId.Location = new System.Drawing.Point(50, 16);
            this.LokasyonId.Name = "LokasyonId";
            this.LokasyonId.Size = new System.Drawing.Size(71, 13);
            this.LokasyonId.TabIndex = 14;
            this.LokasyonId.Text = "Lokasyon Id :";
            this.LokasyonId.Click += new System.EventHandler(this.RehberId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kapasite :";
            // 
            // txtLocationPrice
            // 
            this.txtLocationPrice.Location = new System.Drawing.Point(127, 116);
            this.txtLocationPrice.Name = "txtLocationPrice";
            this.txtLocationPrice.Size = new System.Drawing.Size(194, 20);
            this.txtLocationPrice.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fiyat :";
            // 
            // txtLocationDayNight
            // 
            this.txtLocationDayNight.Location = new System.Drawing.Point(127, 142);
            this.txtLocationDayNight.Name = "txtLocationDayNight";
            this.txtLocationDayNight.Size = new System.Drawing.Size(194, 20);
            this.txtLocationDayNight.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(51, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gün / Gece :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(62, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rehber id :";
            // 
            // nudLocationCapacity
            // 
            this.nudLocationCapacity.Location = new System.Drawing.Point(127, 90);
            this.nudLocationCapacity.Name = "nudLocationCapacity";
            this.nudLocationCapacity.Size = new System.Drawing.Size(194, 20);
            this.nudLocationCapacity.TabIndex = 34;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(127, 169);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(194, 21);
            this.cmbGuide.TabIndex = 35;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1437, 551);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nudLocationCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocationDayNight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLocationCountry);
            this.Controls.Add(this.RehberSurname);
            this.Controls.Add(this.txtLocationCity);
            this.Controls.Add(this.RehberName);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtLocationId);
            this.Controls.Add(this.LokasyonId);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocationCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLocationCountry;
        private System.Windows.Forms.Label RehberSurname;
        private System.Windows.Forms.TextBox txtLocationCity;
        private System.Windows.Forms.Label RehberName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label LokasyonId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocationDayNight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLocationCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}