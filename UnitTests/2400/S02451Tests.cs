using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02451Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02451();
        sut.OddString(new[] {"adc", "wzy", "abc"}).Should().Be("abc");
    }

    [Test]
    public void T2()
    {
        var sut = new S02451();
        sut.OddString(new[] {"aaa", "bob", "ccc", "ddd"}).Should().Be("bob");
    }
}