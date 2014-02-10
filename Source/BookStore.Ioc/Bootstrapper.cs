using BookStore.Business;
using BookStore.Data.Abstracts;
using BookStore.Data.Concretes;
using BookStore.Data.UnitOfWork;
using BookStore.Domain.Entities;
using Microsoft.Practices.Unity;

namespace BookStore.Ioc
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // repos

            container.RegisterType<IGenericRepository<Author>, GenericRepositoryforEF<Author>>();
            container.RegisterType<IGenericRepository<Book>, GenericRepositoryforEF<Book>>();
            container.RegisterType<IGenericRepository<Category>, GenericRepositoryforEF<Category>>();

            ////container.RegisterType<BookStore.Data.Abstracts.IRepository<>, BookStore.Data.Concretes.Repository<Category>>();
            //container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepositoryforEF<>));
            ////container.BindInRequestScope<IBookRepository, BookRepository>();
            ////container.BindInRequestScope<ICategoryRepository, CategoryRepository>();
            //container.RegisterType<ICategoryRepository, CategoryRepository>();

            // services
            container.BindInRequestScope<IBookService, BookService>();
            container.BindInRequestScope<IAuthorService, AuthorService>();
            container.BindInRequestScope<ICategoryService, CategoryService>();

            // UnitOfWork
            container.BindInRequestScope<IUnitOfWork, EFUnitOfWork>();

            return container;
        }
    }
}