using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03039Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03039();
        Assert.That(sut.LastNonEmptyString("aabcbbca"), Is.EqualTo("ba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03039();
        Assert.That(sut.LastNonEmptyString("abcd"), Is.EqualTo("abcd"));
    }
}
