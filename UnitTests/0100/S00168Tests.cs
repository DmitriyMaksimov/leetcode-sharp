using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00168Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00168();
        sut.ConvertToTitle(1).Should().Be("A");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00168();
        sut.ConvertToTitle(28).Should().Be("AB");
    }

    [Test]
    public void T3()
    {
        var sut = new S00168();
        sut.ConvertToTitle(701).Should().Be("ZY");
    }

    [Test]
    public void T4()
    {
        var sut = new S00168();
        sut.ConvertToTitle(26).Should().Be("Z");
    }

}