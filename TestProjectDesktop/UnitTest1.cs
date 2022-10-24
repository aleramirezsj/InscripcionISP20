using Data.Interfaces;
using Data.Repositories;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace TestProjectDesktop
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestA�oCarrera()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();

            var listaA�oCarrera = await unitOfWork.AniocarreraRepository.GetAllAsync(); 
            Assert.That(listaA�oCarrera.Count(), Is.EqualTo(22));
        }

        [Test]
        public async Task TestCarrera()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();

            var listaCarrera = await unitOfWork.CarreraRepository.GetAllAsync();
            Assert.That(listaCarrera.Count(), Is.EqualTo(22));
        }
    }
}