using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace JsonEditor
{
    public partial class FormJSON : Form
    {
        

        public FormJSON()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            FormTXT doiform = new FormTXT();
            doiform.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Mở File JSON";
            theDialog.Filter = "JSON files|*.json";
            theDialog.InitialDirectory = @"C:pathtofile";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (theDialog.FileName.Trim() != string.Empty)
                    {
                        using (StreamReader r = new StreamReader(theDialog.FileName))
                        {
                            string json = r.ReadToEnd();
                            Root items = JsonConvert.DeserializeObject<Root>(json);
                            dgCameras.DataSource = items.Cameras;
                            dgReader.DataSource = items.Reader;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không đọc được file. " + ex.Message);
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName.Trim() != string.Empty)
            {
                for (int i = 0; i < dgCameras.Rows.Count - 1; i++)
                {
                    string str = @"INSERT INTO CAMERASDB (IP, Port, [User], Name, Password, Company, ChannelNo, Entrance, ORC, SubStream) VALUES ('" + dgCameras.Rows[i].Cells["IP"].Value + ", " + dgCameras.Rows[i].Cells["Port"].Value + "," + dgCameras.Rows[i].Cells["User"].Value + "," + dgCameras.Rows[i].Cells["Name"].Value + ", " + dgCameras.Rows[i].Cells["Password"].Value + "," + dgCameras.Rows[i].Cells["Company"].Value + "," + dgCameras.Rows[i].Cells["ChannelNo"].Value + "," + dgCameras.Rows[i].Cells["Entrance"].Value + ", " + dgCameras.Rows[i].Cells["ORC"].Value + "," + dgCameras.Rows[i].Cells["SubStream"].Value + "');";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=desktop-ep2qmte\sqlexpress;Initial Catalog=TXTDB;Integrated Security=True"))
                        {
                            using (SqlCommand com = new SqlCommand(str, con))
                            {
                                con.Open();
                                com.ExecuteNonQuery();
                            }
                        }
                        label1.Text = "Lưu thành công";
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < dgReader.Rows.Count - 1; i++)
                {
                    string str2 = @"INSERT INTO READERDB (Type, Port, Lane) VALUES ('" + dgReader.Rows[i].Cells["Type"].Value + ", " + dgReader.Rows[i].Cells["Port"].Value + ", " + dgReader.Rows[i].Cells["Lane"].Value + "');";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=desktop-ep2qmte\sqlexpress;Initial Catalog=TXTDB;Integrated Security=True"))
                        {
                            using (SqlCommand com = new SqlCommand(str2, con))
                            {
                                con.Open();
                                com.ExecuteNonQuery();
                            }
                        }
                        label1.Text = "Lưu thành công";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
