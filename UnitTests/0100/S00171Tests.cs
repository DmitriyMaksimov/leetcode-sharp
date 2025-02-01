using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00171Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00171();

        Assert.That(sut.TitleToNumber("A"), Is.EqualTo(1));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00171();

        Assert.That(sut.TitleToNumber("AB"), Is.EqualTo(28));
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00171();

        Assert.That(sut.TitleToNumber("ZY"), Is.EqualTo(701));
    }
}