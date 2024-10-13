using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapvenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tạo listview item
            ListViewItem lvi = new ListViewItem(txtFirst.Text);
            //THEM DU LIEU CHO CAC COT CON LAI
            lvi.SubItems.Add(txtLast.Text);
            lvi.SubItems.Add(txtPhone.Text);
            lvi.SubItems.Add(dateTimePicker1.Text);
            //dua dong du lieu vua tao len listview
            lvSinhVien.Items.Add(lvi);
            txtFirst.Clear();
            txtLast.Clear();
            txtPhone.Clear();
         
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvSinhVien.SelectedItems.Count > 0) {
                //LAY DONG DUOC CHON
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                //lay du lieu
                String fn= lvi.SubItems[0].Text;
                String ln= lvi.SubItems[1].Text;
                String phone= lvi.SubItems[2].Text;
                lvi.BackColor = Color.Black;
                //hien thi danh sach
                txtFirst.Text = fn;
                txtLast.Text = ln;
                txtPhone.Text = phone;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {

                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                // Xóa dòng đó khỏi ListView
                lvSinhVien.Items.Remove(lvi);
                // Xóa thông tin trên TextBox
                txtFirst.Clear();
                txtLast.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                //LAY DONG DUOC CHON
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                //lay du lieu
                lvi.SubItems[0].Text= txtFirst.Text;
                lvi.SubItems[1].Text= txtLast.Text;
                lvi.SubItems[2].Text= txtPhone.Text;
                lvi.SubItems[3].Text= dateTimePicker1.Text;

                txtFirst.Clear();
                txtLast.Clear();
                txtPhone.Clear();

                lvSinhVien.Refresh();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
  
                MessageBox.Show("Vui lòng chọn một người dùng để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
