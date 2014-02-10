using System;
using BookStore.Business;
using BookStore.Data.Context;
using BookStore.Data.UnitOfWork;
using BookStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStore.Test
{
    [TestClass]
    public class UnitTestAuthorService
    {
        private BookStoreContext _context;
        private IUnitOfWork _uow;
        private IAuthorService _authorService;
        //   private IBookService = _bookService;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new BookStoreContext();
            _uow = new EFUnitOfWork(_context);
            _authorService = new AuthorService(_uow);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
            _uow.Dispose();
            _authorService = null;
        }

        [TestMethod]
        public void TestMethodInsertUser()
        {
            var author = new Author()
            {
                BirthDate = Convert.ToDateTime("03.01.1892"),
                DeathDate = Convert.ToDateTime("02.09.1973"),
                FirstName = "J.R.R.",
                LastName = "Tolkien",
                IsActive = false,
                //Books = new System.Collections.Generic.List<Book>()
                //{
                //    new Book()
                //    {
                //         Title ="Hobit",
                //          ISBN="1234567890",
                //           Decription="Orta dünya"
                //    }
                //}
            };

            _authorService.Insert(author);
            Assert.AreEqual(1, _uow.Commit());

            _authorService.Delete(author);
            // Delete(author.Books);
            _uow.Commit();
        }
    }
}