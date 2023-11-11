using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02670Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02670();
        sut.DistinctDifferenceArray(new[] {1, 2, 3, 4, 5}).Should().Equal(-3, -1, 1, 3, 5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02670();
        sut.DistinctDifferenceArray(new[] {3, 2, 3, 4, 2}).Should().Equal(-2, -1, 0, 2, 3);
    }
}