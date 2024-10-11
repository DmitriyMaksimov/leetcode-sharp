using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01942))]
public class S01942Test
{
    [Test]
    public void T1()
    {
        var sut = new S01942();
        sut.SmallestChair([[1, 4], [2, 3], [4, 6]], 1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01942();
        sut.SmallestChair([[3, 10], [1, 5], [2, 6]], 0).Should().Be(2);
    }
}
