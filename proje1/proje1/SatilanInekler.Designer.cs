
namespace proje1
{
    partial class SatilanInekler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnVerileriG = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.dtpHamileDYili = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 281);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 172);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "inekId";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "inek Cinsiyeti";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "inek Cinsi";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dogum Yili";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kilosu";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Alis Fiyati";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Alis Tarihi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Satis Fiyati";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Satis Tarihi";
            // 
            // btnVerileriG
            // 
            this.btnVerileriG.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVerileriG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerileriG.Location = new System.Drawing.Point(667, 81);
            this.btnVerileriG.Name = "btnVerileriG";
            this.btnVerileriG.Size = new System.Drawing.Size(121, 44);
            this.btnVerileriG.TabIndex = 1;
            this.btnVerileriG.Text = "Verileri Goster";
            this.btnVerileriG.UseVisualStyleBackColor = false;
            this.btnVerileriG.Click += new System.EventHandler(this.btnVerileriG_Click);
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArama.Location = new System.Drawing.Point(667, 131);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(121, 44);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = false;
            // 
            // dtpHamileDYili
            // 
            this.dtpHamileDYili.Location = new System.Drawing.Point(594, 197);
            this.dtpHamileDYili.Name = "dtpHamileDYili";
            this.dtpHamileDYili.Size = new System.Drawing.Size(205, 27);
            this.dtpHamileDYili.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(477, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doğum Yılı:";
            // 
            // SatilanInekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.innek;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpHamileDYili);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnVerileriG);
            this.Controls.Add(this.listView1);
            this.Name = "SatilanInekler";
            this.Text = "SatilanInekler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVerileriG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.DateTimePicker dtpHamileDYili;
        private System.Windows.Forms.Label label3;
    }
}