using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00747Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00747();
        sut.DominantIndex(new[] {3, 6, 1, 0}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00747();
        sut.DominantIndex(new[] {1, 2, 3, 4}).Should().Be(-1);
    }
}