using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01614Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01614();
        Assert.That(sut.MaxDepth("(1+(2*3)+((8)/4))+1"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01614();
        Assert.That(sut.MaxDepth("(1)+((2))+(((3)))"), Is.EqualTo(3));
    }
}