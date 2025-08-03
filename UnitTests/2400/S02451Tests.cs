using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02451Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02451();
        Assert.That(sut.OddString(["adc", "wzy", "abc"]), Is.EqualTo("abc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02451();
        Assert.That(sut.OddString(["aaa", "bob", "ccc", "ddd"]), Is.EqualTo("bob"));
    }
}