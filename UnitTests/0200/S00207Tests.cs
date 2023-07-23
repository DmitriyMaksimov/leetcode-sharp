using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00207Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00207();
        sut.CanFinish(2, new[] {new[] {1, 0}}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00207();
        sut.CanFinish(2, new[] {new[] {1, 0}, new[] {0, 1}}).Should().BeFalse();
    }
}