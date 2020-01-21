using NSubstitute;
using NUnit.Framework;
using System;
using UnitTestExample.Entity;

namespace UnitTestexample_Test
{
    [TestFixture]
    public class CustomerServis_Test
    {
        private UnitTestExample.CustomerServis _customerServis;
        private UnitTestExample.Repository.CustomerRepository _customerRepository;
        [SetUp]
        public void SetUp()
        {
            _customerRepository = NSubstitute.Substitute.For<UnitTestExample.Repository.CustomerRepository>(); /*new UnitTestExample.Repository.CustomerRepository();*/
            _customerServis = new UnitTestExample.CustomerServis(_customerRepository);

        }


        [Test]
        public void CustomerServis_Test_True()
        {
            _customerRepository.Add(Arg.Any<Customer>()).Returns(true);

            var result = _customerServis.Add(new Customer { Id = 5, Bakiye = 54, Name = "Deneme" });
            Assert.AreEqual("ok", result);

        }

        [TearDown]
        public void TearDown()
        {

            _customerRepository = null;
            _customerServis = null;
        }

    }
}
