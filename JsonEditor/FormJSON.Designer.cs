namespace JsonEditor
{
    partial class FormJSON
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
            this.dgCameras = new System.Windows.Forms.DataGridView();
            this.btnmo = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.dgReader = new System.Windows.Forms.DataGridView();
            this.lbCamera = new System.Windows.Forms.Label();
            this.lbReader = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbip = new System.Windows.Forms.Label();
            this.lbport = new System.Windows.Forms.Label();
            this.checkEntrance = new System.Windows.Forms.CheckBox();
            this.checkORC = new System.Windows.Forms.CheckBox();
            this.checkSubStream = new System.Windows.Forms.CheckBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbChannelNo = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCameras
            // 
            this.dgCameras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCameras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCameras.Location = new System.Drawing.Point(16, 334);
            this.dgCameras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgCameras.Name = "dgCameras";
            this.dgCameras.RowHeadersWidth = 51;
            this.dgCameras.Size = new System.Drawing.Size(1116, 417);
            this.dgCameras.TabIndex = 0;
            // 
            // btnmo
            // 
            this.btnmo.Location = new System.Drawing.Point(891, 44);
            this.btnmo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(100, 28);
            this.btnmo.TabIndex = 1;
            this.btnmo.Text = "Mở";
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(999, 44);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // dgReader
            // 
            this.dgReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReader.Location = new System.Drawing.Point(16, 44);
            this.dgReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgReader.Name = "dgReader";
            this.dgReader.RowHeadersWidth = 51;
            this.dgReader.Size = new System.Drawing.Size(443, 267);
            this.dgReader.TabIndex = 3;
            // 
            // lbCamera
            // 
            this.lbCamera.AutoSize = true;
            this.lbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamera.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbCamera.Location = new System.Drawing.Point(1019, 300);
            this.lbCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(110, 29);
            this.lbCamera.TabIndex = 4;
            this.lbCamera.Text = "Cameras";
            this.lbCamera.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbReader
            // 
            this.lbReader.AutoSize = true;
            this.lbReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbReader.Location = new System.Drawing.Point(363, 11);
            this.lbReader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReader.Name = "lbReader";
            this.lbReader.Size = new System.Drawing.Size(93, 29);
            this.lbReader.TabIndex = 5;
            this.lbReader.Text = "Reader";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(783, 44);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 106);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(495, 164);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(495, 228);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(495, 287);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(800, 106);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(800, 164);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(265, 22);
            this.textBox7.TabIndex = 13;
            // 
            // lbip
            // 
            this.lbip.AutoSize = true;
            this.lbip.Location = new System.Drawing.Point(495, 23);
            this.lbip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbip.Name = "lbip";
            this.lbip.Size = new System.Drawing.Size(24, 17);
            this.lbip.TabIndex = 17;
            this.lbip.Text = "IP:";
            // 
            // lbport
            // 
            this.lbport.AutoSize = true;
            this.lbport.Location = new System.Drawing.Point(495, 86);
            this.lbport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbport.Name = "lbport";
            this.lbport.Size = new System.Drawing.Size(38, 17);
            this.lbport.TabIndex = 18;
            this.lbport.Text = "Port:";
            // 
            // checkEntrance
            // 
            this.checkEntrance.AutoSize = true;
            this.checkEntrance.Location = new System.Drawing.Point(800, 210);
            this.checkEntrance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEntrance.Name = "checkEntrance";
            this.checkEntrance.Size = new System.Drawing.Size(87, 21);
            this.checkEntrance.TabIndex = 19;
            this.checkEntrance.Text = "Entrance";
            this.checkEntrance.UseVisualStyleBackColor = true;
            // 
            // checkORC
            // 
            this.checkORC.AutoSize = true;
            this.checkORC.Location = new System.Drawing.Point(1012, 210);
            this.checkORC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkORC.Name = "checkORC";
            this.checkORC.Size = new System.Drawing.Size(60, 21);
            this.checkORC.TabIndex = 20;
            this.checkORC.Text = "ORC";
            this.checkORC.UseVisualStyleBackColor = true;
            // 
            // checkSubStream
            // 
            this.checkSubStream.AutoSize = true;
            this.checkSubStream.Location = new System.Drawing.Point(900, 210);
            this.checkSubStream.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSubStream.Name = "checkSubStream";
            this.checkSubStream.Size = new System.Drawing.Size(100, 21);
            this.checkSubStream.TabIndex = 21;
            this.checkSubStream.Text = "SubStream";
            this.checkSubStream.UseVisualStyleBackColor = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(495, 144);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(42, 17);
            this.lbUser.TabIndex = 22;
            this.lbUser.Text = "User:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(495, 208);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Name:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(495, 267);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 17);
            this.lbPassword.TabIndex = 24;
            this.lbPassword.Text = "Password:";
            // 
            // lbChannelNo
            // 
            this.lbChannelNo.AutoSize = true;
            this.lbChannelNo.Location = new System.Drawing.Point(796, 144);
            this.lbChannelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChannelNo.Name = "lbChannelNo";
            this.lbChannelNo.Size = new System.Drawing.Size(82, 17);
            this.lbChannelNo.TabIndex = 25;
            this.lbChannelNo.Text = "ChannelNo:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(796, 86);
            this.lbCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(71, 17);
            this.lbCompany.TabIndex = 26;
            this.lbCompany.Text = "Company:";
            // 
            // btnchange
            // 
            this.btnchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnchange.Location = new System.Drawing.Point(16, 758);
            this.btnchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(132, 28);
            this.btnchange.TabIndex = 27;
            this.btnchange.Text = "TXT files reader";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthoat.Location = new System.Drawing.Point(1032, 758);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 28;
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
            this.label1.Location = new System.Drawing.Point(796, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 29;
            // 
            // FormJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 796);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbChannelNo);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.checkSubStream);
            this.Controls.Add(this.checkORC);
            this.Controls.Add(this.checkEntrance);
            this.Controls.Add(this.lbport);
            this.Controls.Add(this.lbip);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lbReader);
            this.Controls.Add(this.lbCamera);
            this.Controls.Add(this.dgReader);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnmo);
            this.Controls.Add(this.dgCameras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormJSON";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON READER";
            ((System.ComponentModel.ISupportInitialize)(this.dgCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCameras;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridView dgReader;
        private System.Windows.Forms.Label lbCamera;
        private System.Windows.Forms.Label lbReader;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbip;
        private System.Windows.Forms.Label lbport;
        private System.Windows.Forms.CheckBox checkEntrance;
        private System.Windows.Forms.CheckBox checkORC;
        private System.Windows.Forms.CheckBox checkSubStream;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbChannelNo;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

