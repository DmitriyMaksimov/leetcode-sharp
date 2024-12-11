using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02249Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02249();
        sut.CountLatticePoints([[2, 2, 1]]).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02249();
        sut.CountLatticePoints([[2, 2, 2], [3, 4, 1]]).Should().Be(16);
    }
}
