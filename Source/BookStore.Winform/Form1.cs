using System;
using System.Linq;
using System.Windows.Forms;
using BookStore.Business;
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