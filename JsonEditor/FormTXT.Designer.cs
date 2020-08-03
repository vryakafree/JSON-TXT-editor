namespace JsonEditor
{
    partial class FormTXT
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
            this.btnchange = new System.Windows.Forms.Button();
            this.dgvtxt = new System.Windows.Forms.DataGridView();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsav = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtxt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(16, 511);
            this.btnchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(133, 28);
            this.btnchange.TabIndex = 28;
            this.btnchange.Text = "JSON files reader";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // dgvtxt
            // 
            this.dgvtxt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtxt.Location = new System.Drawing.Point(16, 50);
            this.dgvtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvtxt.Name = "dgvtxt";
            this.dgvtxt.RowHeadersWidth = 51;
            this.dgvtxt.Size = new System.Drawing.Size(837, 453);
            this.dgvtxt.TabIndex = 29;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(414, 15);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(41, 28);
            this.btnopen.TabIndex = 30;
            this.btnopen.Text = "...";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsav
            // 
            this.btnsav.Location = new System.Drawing.Point(463, 15);
            this.btnsav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsav.Name = "btnsav";
            this.btnsav.Size = new System.Drawing.Size(100, 28);
            this.btnsav.TabIndex = 31;
            this.btnsav.Text = "Lưu";
            this.btnsav.UseVisualStyleBackColor = true;
            this.btnsav.Click += new System.EventHandler(this.btnsav_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(571, 14);
            this.btnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(100, 28);
            this.btnload.TabIndex = 32;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(16, 17);
            this.txtfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(390, 22);
            this.txtfile.TabIndex = 33;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(753, 511);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 34;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 35;
            // 
            // FormTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 545);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnsav);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dgvtxt);
            this.Controls.Add(this.btnchange);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTXT";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTXT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.DataGridView dgvtxt;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnsav;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}