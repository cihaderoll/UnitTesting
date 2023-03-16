using System;
using TargetProject;
using Xunit.Abstractions;

namespace XUnitTestDemo
{
    public class GuidGeneratorTest : IClassFixture<GuidGenerator>, IDisposable
    {
        public GuidGenerator _guidGenerator { get; set; }
        public ITestOutputHelper _outputHelper{ get; set; }

        public GuidGeneratorTest(ITestOutputHelper helper, GuidGenerator generator)
        {
            _guidGenerator = generator;
            _outputHelper = helper;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _outputHelper.WriteLine($"new guid -> {guid}");

        }

        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _outputHelper.WriteLine($"new guid -> {guid}");
        }

        public void Dispose()
        {
            _outputHelper.WriteLine($"guid class disposed");
        }
    }
}
