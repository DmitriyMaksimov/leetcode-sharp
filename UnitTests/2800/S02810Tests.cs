using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02810Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02810();
        sut.FinalString("string").Should().Be("rtsng");
    }

    [Test]
    public void T2()
    {
        var sut = new S02810();
        sut.FinalString("poiinter").Should().Be("ponter");
    }
}