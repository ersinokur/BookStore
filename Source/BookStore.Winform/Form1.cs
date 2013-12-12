using BookStore.Business;
using BookStore.Data;
using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Ioc;

namespace BookStore.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var container = Bootstrapper.Initialise();
                var class1 = container.Resolve(typeof (Interface1), "") as Interface1;

                //class1.doSomething();

                var service = container.Resolve(typeof(ICategoryService), "") as ICategoryService;


                dataGridView1.DataSource = service.GetAll().ToList();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
    
        }

    }
}
