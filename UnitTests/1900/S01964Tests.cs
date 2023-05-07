using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01964Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01964();
        sut.LongestObstacleCourseAtEachPosition(new[] {1, 2, 3, 2}).Should().Equal(1, 2, 3, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01964();
        sut.LongestObstacleCourseAtEachPosition(new[] {2, 2, 1}).Should().Equal(1, 2, 1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01964();
        sut.LongestObstacleCourseAtEachPosition(new[] {3, 1, 5, 6, 4, 2}).Should().Equal(1, 1, 2, 3, 2, 2);
    }
}