using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00791Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00791();
        Assert.That(sut.CustomSortString("cba", "abcd"), Is.EqualTo("cbad"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00791();
        Assert.That(sut.CustomSortString("bcafg", "abcd"), Is.EqualTo("bcad"));
    }
}