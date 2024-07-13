using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03200();
        sut.MaxHeightOfTriangle(2, 4).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03200();
        sut.MaxHeightOfTriangle(2, 1).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S03200();
        sut.MaxHeightOfTriangle(1, 1).Should().Be(1);
    }

    [Test]
    public void T4()
    {
        var sut = new S03200();
        sut.MaxHeightOfTriangle(10, 1).Should().Be(2);
    }
}