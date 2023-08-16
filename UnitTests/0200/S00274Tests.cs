using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00274Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00274();
        sut.HIndex(new[] {3, 0, 6, 1, 5}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00274();
        sut.HIndex(new[] {1, 3, 1}).Should().Be(1);
    }
}