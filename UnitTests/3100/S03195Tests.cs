using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03195Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03195();
        sut.MinimumArea([[0, 1, 0], [1, 0, 1]]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S03195();
        sut.MinimumArea([[1, 0], [0, 0]]).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S03195();
        sut.MinimumArea([[0, 1]]).Should().Be(1);
    }
}
