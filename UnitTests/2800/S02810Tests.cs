using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02810Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02810();
        Assert.That(sut.FinalString("string"), Is.EqualTo("rtsng"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02810();
        Assert.That(sut.FinalString("poiinter"), Is.EqualTo("ponter"));
    }
}