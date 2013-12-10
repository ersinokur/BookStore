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
         

            try
            {
                var repo = new BookRepository();
                var service = new BookService(repo);

                service.Add(new Book
                {
                    Title = "c#",
                    Edition = 2,
                    Decription = "test book",
                    Volume = 2000,
                });
                var books = service.GetAll().ToList();
                dataGridView1.DataSource = books;
            }
            catch (Exception ee)
            {
                
                throw;
            }
          

           
        }
    }
}
