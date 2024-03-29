using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01310Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01310();
        sut.XorQueries([1, 3, 4, 8], [[0, 1], [1, 2], [0, 3], [3, 3]]).Should().Equal(2, 7, 14, 8);
    }

    [Test]
    public void T2()
    {
        var sut = new S01310();
        sut.XorQueries([4, 8, 2, 10], [[2, 3], [1, 3], [0, 0], [0, 3]]).Should().Equal(8, 0, 4, 4);
    }
}