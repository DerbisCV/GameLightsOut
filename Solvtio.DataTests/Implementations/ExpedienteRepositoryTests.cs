using AutoMoq;
using Flurl.Http.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solvtio.Data.Contracts;
using Solvtio.Data.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations.Tests
{
    [TestClass()]
    public class ExpedienteRepositoryTests
    {
        private AutoMoqer _mocker;
        private HttpTest _httpTest;
        private IExpedienteRepository _repository;
        private SolvtioDbContext solvtioDbContext;

        [TestInitialize]
        public void TestInitialize()
        {
            _mocker = new AutoMoqer();
            _httpTest = new HttpTest();


            var contextOptions = new DbContextOptionsBuilder<SolvtioDbContext>()
                .UseSqlServer(@"Data Source=solvtiodbserver.database.windows.net,1433;Initial Catalog=SolvtioSpCore;user id=AdminDB;password=Iv3rvsk@pital501;MultipleActiveResultSets=True")
                .Options;
            solvtioDbContext = new SolvtioDbContext(contextOptions);
            //SolvtioDbContext solvtioDbContext = new SolvtioDbContext();




            _repository = new ExpedienteRepository(solvtioDbContext);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            _mocker = null;
            _httpTest = null;
        }

        [TestMethod()]
        public void GetWithPaginationTest()
        {
            //_mocker.GetMock<IHttpClient>().Setup(x => x.GetAsync<List<Expediente>>(It.IsAny<string>()))
            //    .Returns(Task.FromResult(new List<Expediente>() { new Expediente() }));

            var actual = _repository.GetWithPagination(new Models.PaginationFilter());

        }

    }
}