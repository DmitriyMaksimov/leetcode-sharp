using leetcode_sharp._0300;

namespace UnitTests;

[TestFixture]
public class S00373Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 7, 11}, new[] {2, 4, 6}, 3);
        pairs.Should().HaveCount(3);
        pairs[0].Should().Equal(1, 2);
        pairs[1].Should().Equal(1, 4);
        pairs[2].Should().Equal(1, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 1, 2}, new[] {1, 2, 3}, 2);
        pairs.Should().HaveCount(2);
        pairs[0].Should().Equal(1, 1);
        pairs[1].Should().Equal(1, 1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00373();
        var pairs = sut.KSmallestPairs(new[] {1, 2}, new[] {3}, 3);
        pairs.Should().HaveCount(2);
        pairs[0].Should().Equal(1, 3);
        pairs[1].Should().Equal(2, 3);
    }
}