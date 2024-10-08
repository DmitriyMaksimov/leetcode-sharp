using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03227Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03227();
        sut.DoesAliceWin("leetcoder").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03227();
        sut.DoesAliceWin("bbcd").Should().BeFalse();
    }
}
