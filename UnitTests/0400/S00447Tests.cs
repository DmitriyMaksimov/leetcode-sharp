using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00447Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00447();
        sut.NumberOfBoomerangs([[0, 0], [1, 0], [2, 0]]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00447();
        sut.NumberOfBoomerangs([[1, 1], [2, 2], [3, 3]]).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00447();
        sut.NumberOfBoomerangs([[1, 1]]).Should().Be(0);
    }
}
