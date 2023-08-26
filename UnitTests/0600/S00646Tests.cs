using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00646Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00646();
        sut.FindLongestChain(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00646();
        sut.FindLongestChain(new[] {new[] {1, 2}, new[] {7, 8}, new[] {4, 5}}).Should().Be(3);
    }
}