using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01047Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01047();
        Assert.That(sut.RemoveDuplicates("abbaca"), Is.EqualTo("ca"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01047();
        Assert.That(sut.RemoveDuplicates("azxxzy"), Is.EqualTo("ay"));
    }
}