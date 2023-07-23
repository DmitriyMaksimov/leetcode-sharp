using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02399Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02399();
        sut.CheckDistances("abaccb",
            new[] {1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02399();
        sut.CheckDistances("aa",
            new[] {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}).Should().BeFalse();
    }
}