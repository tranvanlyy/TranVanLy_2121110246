using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranVanLy_2121110246
{
    public partial class Form2 : Form
    {
        public bool isThoat = true;
 

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosingEventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        public event EventHandler DangXuat;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int .Parse(tbAge.Text);
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            dgvEmployee.Rows.RemoveAt(idx); 
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }
            public List<Employee>GetData()
            {
                List<Employee> lst = new List<Employee>();
                Employee em = new Employee();
                em.Id = "53418";
                em.Name = "Trần Tiến";
                em.Age = 20;
                lst.Add(em);

                em = new Employee();
                em.Id = "53416";
                em.Name = "Nguyễn Cường";
                em.Age = 25;
                lst.Add(em);

                em = new Employee();
                em.Id = "53417";
                em.Name = "Nguyễn Hào";
                em.Age = 23;
                lst.Add(em);
                return lst;
            }

        List<Employee> lst;
        private void Form2_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id,em.Name,em.Age);
            }    
        }
    }
}
