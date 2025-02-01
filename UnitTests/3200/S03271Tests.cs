using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03271Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03271();
        Assert.That(sut.StringHash("abcd", 2), Is.EqualTo("bf"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03271();
        Assert.That(sut.StringHash("mxz", 3), Is.EqualTo("i"));
    }
}
