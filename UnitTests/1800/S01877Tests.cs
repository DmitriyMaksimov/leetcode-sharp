using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01877Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01877();
        sut.MinPairSum(new[] {3, 5, 2, 3}).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01877();
        sut.MinPairSum(new[] {3, 5, 4, 2, 4, 6}).Should().Be(8);
    }
}