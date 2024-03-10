using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100233Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100233();
        sut.MinimumBoxes([1, 3, 2], [4, 3, 1, 5, 2]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S100233();
        sut.MinimumBoxes([5, 5, 5], [2, 4, 2, 7]).Should().Be(4);
    }
}