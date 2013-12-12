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
            using (var db = new BookStoreContext())
            {
                db.Categories.Add(new Category
                    {
                        Name = "cat1"
                    });

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ee)
                {
                    
                }
          
            }
          

           
        }
    }
}
