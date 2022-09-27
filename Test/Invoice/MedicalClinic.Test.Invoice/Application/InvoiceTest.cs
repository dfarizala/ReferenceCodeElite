/*
using AutoMapper;
using MediatR;
using MedicalClinic.Application.Invoice;
using MedicalClinic.Domain.Invoice.Entities.Request;
using MedicalClinic.Infrastructure.Helper.Services;
using MedicalClinic.Test.Invoice.Extend;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace MedicalClinic.Test.Invoice.Application
{
    /// <summary>
    /// Invoices Test
    /// </summary>
    [TestFixture]
    public class InvoiceTest
    {

        ILogger<ExecutorOrchestrator> logger;
        IMapper mapper;
        ExecutorOrchestrator orchestrator;
        IMediator mediator;

        /// <summary>
        /// Setup init data
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            var loggerOrchestratorMock = new Mock<ILogger<ExecutorOrchestrator>>();
            logger = loggerOrchestratorMock.Object;

            var configMapper = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile<MedicalClinic.Domain.Invoice.Entities.Request.RequestInvoice>();
            });
            mapper = new AutoMapper.Mapper(configMapper);
            mediator = TestServiceExtensions.BuildMediator(TestServiceExtensions.AddServices());

            orchestrator = new(mapper, mediator,loggerOrchestratorMock.Object);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GetInvoice()
        {
            InvoiceApplication application = new(orchestrator);

            var request = new RequestInvoice();
            var resultTask = application.GetInvoice(request);
            var result = resultTask.GetAwaiter().GetResult();


            Assert.AreNotEqual(result.Data, null);
            Assert.AreEqual(result.Error, null);
            
        }
    }
}
*/