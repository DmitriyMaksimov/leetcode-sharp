using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02215Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02215();
        var list = sut.FindDifference(new[] {1, 2, 3}, new[] {2, 4, 6});
        list.Should().HaveCount(2);
        list[0].Should().Equal(1, 3);
        list[1].Should().Equal(4, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02215();
        var list = sut.FindDifference(new[] {1, 2, 3, 3}, new[] {1, 1, 2, 2});
        list.Should().HaveCount(2);
        list[0].Should().Equal(3);
        list[1].Should().BeEmpty();
    }
}