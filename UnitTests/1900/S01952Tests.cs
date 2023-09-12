using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01952Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01952();
        sut.IsThree(2).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01952();
        sut.IsThree(4).Should().BeTrue();
    }
}