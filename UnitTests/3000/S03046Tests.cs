using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03046Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03046();
        sut.IsPossibleToSplit([1, 1, 2, 2, 3, 4]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03046();
        sut.IsPossibleToSplit([1, 1, 1, 1]).Should().BeFalse();
    }
}