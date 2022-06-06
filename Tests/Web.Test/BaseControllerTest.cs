using Data;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Web.Infrastructure;

namespace Web.Test
{
    public class BaseControllerTest
    {
        protected IDbContext _dbContext;
        protected ServiceProvider _serviceProvider;

        [SetUp]
        public void BeforeEach()
        {
            this.SetUp();
        }

        public void SetUp(bool dropDatabase = false)
        {
            string[] args = { };
            Program.Main(args);

            //_container = _cb.Build();
            //_dbContext = _container.Resolve<IDbContext>();
            //if (dropDatabase) _dbContext.DropDatabase();
            //else _dbContext.BeginTransaction();
        }
    }
}