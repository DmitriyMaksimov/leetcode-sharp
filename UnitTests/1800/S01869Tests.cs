using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01869();
        sut.CheckZeroOnes("1101").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01869();
        sut.CheckZeroOnes("111000").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01869();
        sut.CheckZeroOnes("110100010").Should().BeFalse();
    }
}