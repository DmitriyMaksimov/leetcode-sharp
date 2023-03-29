using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02520Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02520();
        sut.CountDigits(7).Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02520();
        sut.CountDigits(121).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02520();
        sut.CountDigits(1248).Should().Be(4);
    }
}