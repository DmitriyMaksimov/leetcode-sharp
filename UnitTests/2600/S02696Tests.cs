using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02696Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02696();
        sut.MinLength("ABFCACDB").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02696();
        sut.MinLength("ACBBD").Should().Be(5);
    }
}