using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02596Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02596();
        sut.CheckValidGrid([[0, 11, 16, 5, 20], [17, 4, 19, 10, 15], [12, 1, 8, 21, 6], [3, 18, 23, 14, 9], [24, 13, 2, 7, 22]]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02596();
        sut.CheckValidGrid([[0, 3, 6], [5, 8, 1], [2, 7, 4]]).Should().BeFalse();
    }
}
