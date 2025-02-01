using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00415Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00415();
        Assert.That(sut.AddStrings("11", "123"), Is.EqualTo("134"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00415();
        Assert.That(sut.AddStrings("456", "77"), Is.EqualTo("533"));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00415();
        Assert.That(sut.AddStrings("0", "0"), Is.EqualTo("0"));
    }
}