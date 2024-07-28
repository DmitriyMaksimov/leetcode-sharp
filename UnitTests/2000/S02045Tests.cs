using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02045Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02045();
        sut.SecondMinimum(5, [[1, 2], [1, 3], [1, 4], [3, 4], [4, 5]], 3, 5).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S02045();
        sut.SecondMinimum(2, [[1, 2]], 3, 2).Should().Be(11);
    }
}