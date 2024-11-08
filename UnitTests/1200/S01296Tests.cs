using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01296Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01296();
        sut.IsPossibleDivide([1, 2, 3, 3, 4, 4, 5, 6], 4).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01296();
        sut.IsPossibleDivide([3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11], 3).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01296();
        sut.IsPossibleDivide([1, 2, 3, 4], 3).Should().BeFalse();
    }
}