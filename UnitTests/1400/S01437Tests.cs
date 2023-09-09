using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01437Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01437();
        sut.KLengthApart(new[] {1, 0, 0, 0, 1, 0, 0, 1}, 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01437();
        sut.KLengthApart(new[] {1, 0, 0, 1, 0, 1}, 2).Should().BeFalse();
    }
}