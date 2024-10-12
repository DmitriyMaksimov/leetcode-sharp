using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02406Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02406();
        sut.MinGroups([[5, 10], [6, 8], [1, 5], [2, 3], [1, 10]]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02406();
        sut.MinGroups([[1, 3], [5, 6], [8, 10], [11, 13]]).Should().Be(1);
    }
}
