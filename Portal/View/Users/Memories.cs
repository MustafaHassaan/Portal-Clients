using Controler;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Users
{
    public partial class Memories : Form
    {
        int mov;
        int movx;
        int movy;
        int Charcount = 0;
        PortalContext Db;
        public static string SMSPassing;
        public static string SMSCount;
        public Memories()
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
                var List = from Memo in Db.Memories
                           where Memo.UserId == user.Id
                           join Emp in Db.Users
                           on Memo.UserId equals Emp.Id
                           select new
                           {
                               Memo.Id,
                               Memo.MemoryName,
                               Memo.Message,
                               Emp.UserName,
                           };
                DGV.DataSource = List.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();
                NI.Visible = true;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
        private async void BSave_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = long.Parse(LbluserId.Text);
            var user = await Db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (string.IsNullOrEmpty(TMN.Text) || string.IsNullOrEmpty(TSM.Text))
            {
                MessageBox.Show("Please Insert Memory Name & Memory Message ...", "Faild");
                return;
            }
            else
            {
                var memo = new Memory();
                memo.MemoryName = TMN.Text;
                memo.Message = TSM.Text;
                memo.UserId = user.Id;
                Db.Memories.Add(memo);
                await Db.SaveChangesAsync();
                List();
                MessageBox.Show("Memory Is Saved Successfully ...", "Success");
                TMN.Clear();
                TSM.Clear();
            }
        }
        private async void Memories_Load(object sender, EventArgs e)
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
        private void TSM_TextChanged(object sender, EventArgs e)
        {
            if (TSM.Text != "")
            {
                InputLanguage MCL = InputLanguage.CurrentInputLanguage;
                var Lang = "Language Is : " + MCL.Culture.EnglishName;
                if (Lang == "Language Is : English (United States)")
                {
                    TSM.MaxLength = 160;
                    Charcount = TSM.Text.Length;
                    Count.Text = Charcount.ToString() + " " + "/" + " " + "160";
                }
                else
                {
                    TSM.MaxLength = 70;
                    Charcount = TSM.Text.Length;
                    Count.Text = Charcount.ToString() + " " + "/" + " " + "70";
                }
                BSave.Enabled = true;
            }
            else
            {
                TSM.MaxLength = 0;
                BSave.Enabled = false;
            }
        }
        private void TMN_TextChanged(object sender, EventArgs e)
        {
            if (TMN.Text != "")
            {
                TSM.Enabled = true;
            }
            else
            {
                TSM.Enabled = false;
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Rows.Count > 0)
            {
                LblId.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TMN.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TSM.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                BSave.Enabled = false;
                BEdit.Visible = true;
                BDel.Visible = true;
            }
        }
        private void Memories_Click(object sender, EventArgs e)
        {

        }
        private void History_Click(object sender, EventArgs e)
        {
            TMN.Clear();
            TSM.Clear();
            BEdit.Visible = false;
            BDel.Visible = false;
        }
        private async void BEdit_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var Memo = await Db.Memories.Where(X => X.Id == id).FirstOrDefaultAsync();
            Memo.MemoryName = TMN.Text;
            Memo.Message = TSM.Text;
            Db.Entry(Memo).State = EntityState.Modified;
            await Db.SaveChangesAsync();
            MessageBox.Show("Memory Is Editing Successfully ...", "Success");
            List();
            TMN.Clear();
            TSM.Clear();
        }
        private async void BDel_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var memod = await Db.Memories.Where(X => X.Id == id).FirstOrDefaultAsync();
            Db.Memories.Remove(memod);
            await Db.SaveChangesAsync();
            MessageBox.Show("Memory Is Deleted Successfully ...", "Success");
            List();
            TMN.Clear();
            TSM.Clear();
        }
        private void BImport_Click(object sender, EventArgs e)
        {
            SMSPassing = TSM.Text;
            Employees EF = new Employees();
            EF.Show();
            this.Close();
        }
        private void TSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Lang = InputLanguage.CurrentInputLanguage.LayoutName;
            if (Lang == "Arabic (101)")
            {
                TSM.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                TSM.RightToLeft = RightToLeft.No;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employees EF = new Employees();
            EF.Show();
            this.Close();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process p = System.Diagnostics.Process.GetCurrentProcess();
            //int id = p.Id;
            //string name = p.ProcessName;
            Close();
            foreach (var process in Process.GetProcessesByName("Clients"))
            {
                process.Kill();
            }
        }
        private void maxmizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NI.Visible = false;
        }
        private void NI_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                NI.Visible = false;
            }
        }
    }
}
