using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01568Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01568();
        sut.MinDays([[0, 1, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0]]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01568();
        sut.MinDays([[1, 1]]).Should().Be(2);
    }
}
