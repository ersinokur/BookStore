using BookStore.Business;
using BookStore.Data;
using BookStore.Data.Concretes;
using BookStore.Domain.Entities;
using Microsoft.Practices.Unity;
using BookStore.Data.Abstracts;

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
            //container.RegisterType<BookStore.Data.Abstracts.IRepository<>, BookStore.Data.Concretes.Repository<Category>>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.BindInRequestScope<IBookRepository, BookRepository>();
            //container.BindInRequestScope<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            // services
            container.BindInRequestScope<IBookService, BookService>();
            //container.BindInRequestScope<ICategoryService, ICategoryService>();
            container.RegisterType<ICategoryService, CategoryService>();

            container.RegisterType<Interface1, Class1>();

            return container;
        }
    }
}
