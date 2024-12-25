using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03396Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03396();
        sut.MinimumOperations([1, 2, 3, 4, 2, 3, 3, 5, 7]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S03396();
        sut.MinimumOperations([4, 5, 6, 4, 4]).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S03396();
        sut.MinimumOperations([6, 7, 8, 9]).Should().Be(0);
    }
}
