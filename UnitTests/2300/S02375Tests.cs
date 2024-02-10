using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02375();
        sut.SmallestNumber("IIIDIDDD").Should().Be("123549876");
    }

    [Test]
    public void T2()
    {
        var sut = new S02375();
        sut.SmallestNumber("DDD").Should().Be("4321");
    }
}