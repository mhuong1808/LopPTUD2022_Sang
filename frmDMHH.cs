using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LopPTUD2022_Sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        String sql, constr;
        int i;
        Boolean addnewflag = false;

        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = " Data Source=DESKTOP-1HQR0PF\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaNhom, MaHH, TenHH, dvt, Dgvnd, SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NạpCT();

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NạpCT();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NạpCT();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i-1];
            NạpCT();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i==grdData.RowCount-1)
            {
                grdData.CurrentCell = grdData[0, 0];
                NạpCT();
            }
            else
            {
                grdData.CurrentCell = grdData[0, i+1];
                NạpCT();
            }
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == 0)
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
                NạpCT();

            }
            else
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NạpCT();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTenTruong.Text + " From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTenTruong.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, dvt, Dgvnd, SanXuat from tblDMHH" + " where " + comTenTruong.Text + "='" + comGT.Text +"'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NạpCT();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, dvt, Dgvnd, SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NạpCT();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này? (Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây");
                sql = "delete from tblDMHH where MaHH='" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdData.CurrentRow.Index;
                grdData.Rows.RemoveAt(i);
                NạpCT();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, chào nhé!");
            }
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 1];
            NạpCT();
            txtMaNhom.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (addnewflag==true )
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không? Giờ tôi sẽ chạy lệnh Insert into");
                addnewflag = false;
                sql = "Insert into tblDMHH (MaNhom, MaHH, TenHH, dvt, Dgvnd, Sanxuat)" +
                    "Values ('" + txtMaNhom.Text + "',N'" + txtMaHH.Text + "','" + txtTenHH.Text + "'," + "N'" + txtdvt.Text + "'," 
                    + txtDgvnd.Text + ",N'" + txtSanXuat.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bạn vừa sửa chữa đúng không? Giờ tôi sẽ chạy lệnh Update");
                sql = "Update tblDMHH Set TenHH = N'" + txtTenHH.Text + "',dvt=N'" + txtdvt.Text +
                    "',dgvnd=" + txtDgvnd.Text + ",SanXuat=N'" + txtSanXuat.Text + "' WHERE MaHH='" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows[i].Cells["MaNhom"].Value = txtMaNhom.Text;
                grdData.Rows[i].Cells["MaHH"].Value = txtMaHH.Text;
                grdData.Rows[i].Cells["TenHH"].Value = txtTenHH.Text;
                grdData.Rows[i].Cells["dvt"].Value = txtdvt.Text; ;
                grdData.Rows[i].Cells["Dgvnd"].Value = txtDgvnd.Text;
                grdData.Rows[i].Cells["SanXuat"].Value = txtSanXuat.Text;


            }
        }

        private void frmDMHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void NạpCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtdvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDgvnd.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
            txtSanXuat.Text = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
        }
    }
}
