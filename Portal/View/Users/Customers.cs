using Controler;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Users
{
    public partial class Customers : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public Customers()
        {
            InitializeComponent();
            LblName.Text = Employees.UNPassing;
            LbluserId.Text = Employees.IDPassing;
        }
        private async void List()
        {
            Db = new PortalContext();
            var id = long.Parse(LbluserId.Text);
            try
            {
                var user = await Db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
                var List = from Cust in Db.Customers
                           where Cust.UserId == user.Id
                           join Emp in Db.Users
                           on Cust.UserId equals Emp.Id
                           select new
                           {
                               Cust.Id,
                               Cust.CustName,
                               Cust.CustPhone,
                               Cust.AnotherPhone,
                               Cust.LinePhone
                           };
                DGV.DataSource = List.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Doewn ...","Error");
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            try
            {
                List();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
            
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }
        private void Close_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void NI_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BClear_Click(object sender, EventArgs e)
        {
            TCName.Clear();
            TCPhone.Clear();
            TCAPhone.Clear();
            TCLPhone.Clear();
            BSave.Enabled = true;
            Bedit.Enabled = false;
            BDelete.Enabled = false;
        }
        private async void BSave_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = long.Parse(LbluserId.Text);
            var user = await Db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (string.IsNullOrEmpty(TCName.Text) || string.IsNullOrEmpty(TCPhone.Text))
            {
                MessageBox.Show("Please Insert Customer Name & Customer Phone ...", "Faild");
                return;
            }
            else
            {
                var Cust = new Customer();
                Cust.CustName = TCName.Text;
                Cust.CustPhone = TCPhone.Text;
                Cust.AnotherPhone = TCAPhone.Text;
                Cust.LinePhone = TCLPhone.Text;
                Cust.UserId = user.Id;
                Db.Customers.Add(Cust);
                await Db.SaveChangesAsync();
                List();
                MessageBox.Show("Customer Is Saved Successfully ...", "Success");
                TCName.Clear();
                TCPhone.Clear();
                TCAPhone.Clear();
                TCLPhone.Clear();
                BSave.Enabled = true;
                Bedit.Enabled = false;
                BDelete.Enabled = false;
            }
        }
        private void TCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Pres Number Only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TCAPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Pres Number Only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TCLPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Pres Number Only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Rows.Count > 0)
            {
                LblId.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TCName.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TCPhone.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TCAPhone.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                TCLPhone.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                BSave.Enabled = false;
                Bedit.Enabled = true;
                BDelete.Enabled = true;
            }
        }
        private async void Bedit_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var Cust = await Db.Customers.Where(X => X.Id == id).FirstOrDefaultAsync();
            Cust.CustName = TCName.Text;
            Cust.CustPhone = TCPhone.Text;
            Cust.AnotherPhone = TCAPhone.Text;
            Cust.LinePhone = TCLPhone.Text;
            Db.Entry(Cust).State = EntityState.Modified;
            await Db.SaveChangesAsync();
            MessageBox.Show("Customer Is Editing Successfully ...", "Success");
            List();
            TCName.Clear();
            TCPhone.Clear();
            TCAPhone.Clear();
            TCLPhone.Clear();
            BSave.Enabled = true;
            Bedit.Enabled = false;
            BDelete.Enabled = false;
        }
        private async void BDelete_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var Cust = await Db.Customers.Where(X => X.Id == id).FirstOrDefaultAsync();
            Db.Customers.Remove(Cust);
            await Db.SaveChangesAsync();
            MessageBox.Show("Customer Is Deleted Successfully ...", "Success");
            List();
            TCName.Clear();
            TCPhone.Clear();
            TCAPhone.Clear();
            TCLPhone.Clear();
            BSave.Enabled = true;
            Bedit.Enabled = false;
            BDelete.Enabled = false;
        }
    }
}
