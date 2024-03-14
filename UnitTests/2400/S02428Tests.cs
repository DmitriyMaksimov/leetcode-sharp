using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02428Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02428();
        sut.MaxSum([[6, 2, 1, 3], [4, 2, 1, 5], [9, 2, 8, 7], [4, 1, 2, 9]]).Should().Be(30);
    }

    [Test]
    public void T2()
    {
        var sut = new S02428();
        sut.MaxSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).Should().Be(35);
    }
}