using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00718Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00718();
        sut.FindLength([1, 2, 3, 2, 1], [3, 2, 1, 4, 7]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00718();
        sut.FindLength([0, 0, 0, 0, 0], [0, 0, 0, 0, 0]).Should().Be(5);
    }
}
