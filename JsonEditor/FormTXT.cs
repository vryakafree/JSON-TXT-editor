using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using JsonEditor.Class;

namespace JsonEditor
{
    public partial class FormTXT : Form
    {
        DataTable table = new DataTable();
        public FormTXT()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            FormJSON doiform = new FormJSON();
            doiform.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Mở File...",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Filter = "txt file (*.txt)|*.txt",
                InitialDirectory = @"C:pathtofile",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = openFileDialog1.FileName;
                try
                {
                    StreamReader read = new StreamReader(txtfile.Text);
                    List<Loaddl> listData = new List<Loaddl>();

                    string data = read.ReadToEnd();
                    string data1 = data.Trim().Replace(" ", string.Empty);
                    string data2 = data1.Trim().Replace("\r", string.Empty);
                    var a = data2.Split('|', '\n');

                    foreach (var item in a)
                    {
                        if (item != string.Empty)
                        {
                            listData.Add(new Loaddl { STT1 = item });
                        }
                    }
                    read.Close();
                    dgvtxt.DataSource = listData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không đọc được file. " + ex.Message);
                }
            }
        }

        private void btnsav_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName.Trim() != string.Empty)
            {
                for (int i = 0; i < dgvtxt.Rows.Count - 1; i++)
                {
                    string str = @"INSERT INTO TXTDB (STT1) VALUES ('" + dgvtxt.Rows[i].Cells["STT1"].Value + "');";
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
            }
        }
    }
}
