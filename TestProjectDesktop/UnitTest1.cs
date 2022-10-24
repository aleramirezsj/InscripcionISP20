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
        public async Task TestAñoCarrera()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();

            var listaAñoCarrera = await unitOfWork.AniocarreraRepository.GetAllAsync(); 
            Assert.That(listaAñoCarrera.Count(), Is.EqualTo(22));
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