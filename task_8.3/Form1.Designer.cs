
namespace task_8._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.dgvTelebeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelebeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(55, 41);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 9;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(55, 91);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 16);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(55, 146);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(34, 16);
            this.lblYas.TabIndex = 7;
            this.lblYas.Text = "Yas:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-poct:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(163, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(140, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(163, 143);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(140, 22);
            this.txtYas.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(163, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(140, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.Location = new System.Drawing.Point(87, 229);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(100, 30);
            this.btnElaveEt.TabIndex = 1;
            this.btnElaveEt.Text = "Elave et";
            this.btnElaveEt.UseVisualStyleBackColor = true;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // dgvTelebeler
            // 
            this.dgvTelebeler.AllowUserToAddRows = false;
            this.dgvTelebeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelebeler.Location = new System.Drawing.Point(373, 38);
            this.dgvTelebeler.MultiSelect = false;
            this.dgvTelebeler.Name = "dgvTelebeler";
            this.dgvTelebeler.ReadOnly = true;
            this.dgvTelebeler.RowHeadersWidth = 51;
            this.dgvTelebeler.RowTemplate.Height = 24;
            this.dgvTelebeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelebeler.Size = new System.Drawing.Size(684, 234);
            this.dgvTelebeler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 310);
            this.Controls.Add(this.dgvTelebeler);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Telebe elave et";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelebeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.DataGridView dgvTelebeler;
    }
}
