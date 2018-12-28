using Mediatr.Cqrs;
using Mediatr.Cqrs.Commands.Add;
using Mediatr.Cqrs.Queries.GetNumericString;
using Mediatr.Cqrs.Services;
using MediatR;
using MediatR.Pipeline;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Mediatr.Tests
{
    [TestClass]
    public class Mediator_CqrsTests
    {
        private Container container;
        private IMediator mediator;

        [TestInitialize]
        public void Initialize()
        {
            container = new Container();
            container.RegisterSingleton<IMediator, Mediator>();
            var assemblies = GetAssemblies().ToArray();
            var writer = new StringWriter();
            container.Register(typeof(IRequestHandler<,>), assemblies);
            container.Register(() => (TextWriter)writer, Lifestyle.Singleton);

            // Pipeline
            container.Collection.Register(typeof(IPipelineBehavior<,>), new[]
            {
                typeof(RequestPreProcessorBehavior<,>),
                typeof(RequestPostProcessorBehavior<,>),
                typeof(GenericPipelineBehavior<,>)
            });

            container.Collection.Register(typeof(IRequestPreProcessor<>), new[] { typeof(GenericRequestPreProcessor<>) });
            container.Collection.Register(typeof(IRequestPostProcessor<,>), new[] { typeof(GenericRequestPostProcessor<,>) });

            container.Register<INumberService, DictionaryNumberService>();

            container.Register(() => new ServiceFactory(container.GetInstance), Lifestyle.Singleton);

            container.Verify();

            mediator = container.GetInstance<IMediator>();
        }

        private IEnumerable<Assembly> GetAssemblies()
        {
            yield return typeof(IMediator).GetTypeInfo().Assembly;
            yield return typeof(INumberService).GetTypeInfo().Assembly;
            yield return typeof(AddCommand).GetTypeInfo().Assembly;
        }

        [TestMethod]
        public async Task AddCommand_OnNewNumber_ReturnsTrue()
        {
            // Arrange
            var expected = true;

            // Act
            var actual = await mediator.Send(new AddCommand { Number = 6, NumericString = "Six" });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task AddCommand_OnExistingNumber_ReturnsFalse()
        {
            // Arrange
            var expected = false;

            // Act
            var actual = await mediator.Send(new AddCommand { Number = 3, NumericString = "Three" });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task GetNumericString_OnExistingNumber_ReturnsNumericString()
        {
            // Arrange
            var expected = "Two";

            // Act
            var actual = await mediator.Send(new GetNumericStringQuery { Number = 2 });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task GetNumericString_OnNonExistingNumber_ReturnsNull()
        {
            // Arrange
            string expected = null;

            // Act
            var actual = await mediator.Send(new GetNumericStringQuery { Number = 6 });

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
