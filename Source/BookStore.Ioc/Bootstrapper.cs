using BookStore.Business;
using BookStore.Data;
using BookStore.Data.Concretes;
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
            container.BindInRequestScope<IBookRepository, BookRepository>();
            //container.BindInRequestScope<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>("ICategoryRepository");

            // services
            container.BindInRequestScope<IBookService, BookService>();
            //container.BindInRequestScope<ICategoryService, ICategoryService>();
            container.RegisterType<ICategoryService, CategoryService>("ICategoryService");

            return container;
        }
    }
}
