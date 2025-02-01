using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01370();
        Assert.That(sut.SortString("aaaabbbbcccc"), Is.EqualTo("abccbaabccba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01370();
        Assert.That(sut.SortString("rat"), Is.EqualTo("art"));
    }
}