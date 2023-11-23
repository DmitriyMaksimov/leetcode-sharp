using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01630Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01630();
        sut.CheckArithmeticSubarrays(new[] {4, 6, 5, 9, 3, 7}, new[] {0, 0, 2}, new[] {2, 3, 5}).Should()
            .Equal(true, false, true);
    }

    [Test]
    public void T2()
    {
        var sut = new S01630();
        sut.CheckArithmeticSubarrays(new[] {-12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10}, new[] {0, 1, 6, 4, 8, 7},
            new[] {4, 4, 9, 7, 9, 10}).Should().Equal(false, true, false, false, true, true);
    }
}