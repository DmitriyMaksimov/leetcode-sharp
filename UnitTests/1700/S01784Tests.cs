using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01784Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01784();
        sut.CheckOnesSegment("1001").Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01784();
        sut.CheckOnesSegment("110").Should().BeTrue();
    }
}