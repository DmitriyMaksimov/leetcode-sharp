using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00980Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00980();
        sut.UniquePathsIII(new[] {new[] {1, 0, 0, 0}, new[] {0, 0, 0, 0}, new[] {0, 0, 2, -1}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00980();
        sut.UniquePathsIII(new[] {new[] {1, 0, 0, 0}, new[] {0, 0, 0, 0}, new[] {0, 0, 0, 2}}).Should().Be(4);
    }
}