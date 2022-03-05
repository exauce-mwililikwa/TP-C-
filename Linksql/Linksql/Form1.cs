using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linksql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        private void btninsert_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string design = txtdesign.Text;
            string color = cbcolor.Text;
            DateTime expirydate = DateTime.Parse(dtdate.Text);
            var st = new productinfo_table
            {
                name = name,
                designation = design,
                color = color,
                insertdate = DateTime.Now,
                expiredate = expirydate,

            };
            db.productinfo_tables.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("successfully inserded");
            loaddata();
        }
        //adding method to load data in datagridview
        void loaddata()
        {
            var st = from s in db.productinfo_tables select s;
            dataGridView1.DataSource = st;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // update
            string name = txtname.Text;
            string design = txtdesign.Text;
            string color = cbcolor.Text;
            DateTime expirydate = DateTime.Parse(dtdate.Text);
            var st = (from s in db.productinfo_tables where s.id == int.Parse(txtid.Text) select s).First();
                st.name = name;
                st.designation = design;
                st.color = color;
                st.insertdate = DateTime.Now;
                st.updatedate = DateTime.Now;
                st.expiredate = expirydate;
                db.SubmitChanges();
                MessageBox.Show("successfully updated");
                loaddata();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            // Search
            var st = from s in db.productinfo_tables where s.id== int.Parse(txtid.Text) select s;
            dataGridView1.DataSource = st;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete
            if (MessageBox.Show("Are sure to delete?", "delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            var st = (from s in db.productinfo_tables where s.id == int.Parse(txtid.Text) select s).First();
            db.productinfo_tables.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("successfully deletd");
            loaddata();
            }
        }
    }
}
