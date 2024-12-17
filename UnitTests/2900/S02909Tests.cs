using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02909Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02909();
        sut.MinimumSum([8, 6, 1, 5, 3]).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02909();
        sut.MinimumSum([5, 4, 8, 7, 10, 2]).Should().Be(13);
    }

    [Test]
    public void T3()
    {
        var sut = new S02909();
        sut.MinimumSum([6, 5, 4, 3, 4, 5]).Should().Be(-1);
    }
}
