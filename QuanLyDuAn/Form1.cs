using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDuAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDgv();
            LoadCbb();
        }

        private void LoadDgv()
        {
            dgv_da_load.DataSource = Database.Query("select * from DuAn");
            btn_sua.Enabled = btn_xoa.Enabled = dgv_da_load.Rows.Count > 0;
        }

        private void LoadCbb()
        {
            cbb_nv_id.DataSource = Database.Query("select * from DuAn");
            cbb_nv_id.ValueMember = "MaNhanVienPhuTrach";
            cbb_nv_id.DisplayMember = "MaNhanVienPhuTrach";
        }

        private bool Check()
        {
            bool check = true;
            erp_loi.Clear();
            if (txt_id.Text.Trim() == "")
            {
                erp_loi.SetError(txt_id, "ID khong duoc trong");
                check = false;
            }
            if (txt_name.Text.Trim() == "")
            {
                erp_loi.SetError(txt_name, "Ten khong duoc de trong");
                check = false;
            }
            if (txt_cost.Text.Trim() == "")
            {
                erp_loi.SetError(txt_cost, "Gia khong duoc de trong");
                check = false;
            }
            return check;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            string sql = "EXEC ThemDuAn @MaDuAn, @TenDuAn, @TongKinhPhi, @MaNhanVienPhuTrach";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaDuAn", txt_id.Text);
            dictionary.Add("@TenDuAn", txt_name.Text);
            dictionary.Add("TongKinhPhi", txt_cost.Text);
            dictionary.Add("@MaNhanVienPhuTrach", cbb_nv_id.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
                txt_id.Text = txt_name.Text = txt_cost.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            string sql = "EXEC SuaDuAn @MaDuAn, @TenDuAn, @TongKinhPhi, @MaNhanVienPhuTrach";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaDuAn", txt_id.Text);
            dictionary.Add("TenDuAn", txt_name.Text);
            dictionary.Add("@TongKinhPhi", txt_cost.Text);
            dictionary.Add("@MaNhanVienPhuTrach", cbb_nv_id.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaDuAn @MaDuAn";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaDuAn", txt_id.Text);
            try
            {
                DialogResult result = MessageBox.Show(
                    "Co chac muon xoa khong",
                    "ThongBao",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    Database.Execute(sql, dictionary);
                    LoadDgv();
                    txt_id.Text = txt_name.Text = txt_cost.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_da_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_da_load.Rows[e.RowIndex].Cells["colMaDuAn"].Value.ToString();
            txt_name.Text = dgv_da_load.Rows[e.RowIndex].Cells["colTenDuAn"].Value.ToString();
            txt_cost.Text = dgv_da_load.Rows[e.RowIndex].Cells["colTongKinhPhi"].Value.ToString();
            cbb_nv_id.SelectedValue = dgv_da_load
                .Rows[e.RowIndex]
                .Cells["colMaNhanVienPhuTrach"]
                .Value.ToString();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TimKiemDuAn(@TuKhoa)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_find_da.Checked)
            {
                dictionary.Add("@TuKhoa", txt_find_da.Text);
            }
            else
            {
                dictionary.Add("@TuKhoa", DBNull.Value);
            }
            dgv_da_load.DataSource = Database.Query(sql, dictionary);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_id.Text.Length >= 3 && !char.IsControl(e.KeyChar) && char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
