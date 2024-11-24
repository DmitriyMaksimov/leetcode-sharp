using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01975Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01975();
        sut.MaxMatrixSum([[1, -1], [-1, 1]]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01975();
        sut.MaxMatrixSum([[1, 2, 3], [-1, -2, -3], [1, 2, 3]]).Should().Be(16);
    }
}
