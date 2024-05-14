using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01219Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01219();
        sut.GetMaximumGold([[0, 6, 0], [5, 8, 7], [0, 9, 0]]).Should().Be(24);
    }

    [Test]
    public void T2()
    {
        var sut = new S01219();
        sut.GetMaximumGold([[1, 0, 7], [2, 0, 6], [3, 4, 5], [0, 3, 0], [9, 0, 20]]).Should().Be(28);
    }
}