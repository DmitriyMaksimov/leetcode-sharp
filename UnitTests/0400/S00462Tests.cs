using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00462Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00462();
        sut.MinMoves2([1, 2, 3]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00462();
        sut.MinMoves2([1, 10, 2, 9]).Should().Be(16);
    }
}
