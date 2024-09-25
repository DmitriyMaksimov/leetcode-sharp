using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01734Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01734();
        sut.Decode([3, 1]).Should().Equal(1, 2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01734();
        sut.Decode([6, 5, 4, 6]).Should().Equal(2, 4, 1, 5, 3);
    }
}
