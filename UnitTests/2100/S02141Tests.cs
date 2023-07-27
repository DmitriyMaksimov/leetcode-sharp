using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02141Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02141();
        sut.MaxRunTime(2, new[] {3, 3, 3}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02141();
        sut.MaxRunTime(2, new[] {1, 1, 1, 1}).Should().Be(2);
    }
}