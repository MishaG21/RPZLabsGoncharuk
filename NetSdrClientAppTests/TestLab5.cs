using NetArchTest.Rules;

namespace NetSdrClientAppTests
{
    public class TestLab5
    {
        [Test]
        public void TestingDependency()
        {
            var assembly = typeof(NetSdrClientApp.NetSdrClient).Assembly;

            var result = Types.InAssembly(assembly)
                .That()
                .ResideInNamespace("NetSdrClientApp")
                .ShouldNot()
                .HaveDependencyOn("EchoTspServer")
                .GetResult();

            Assert.That(result.IsSuccessful, Is.True);
        }
    }
}