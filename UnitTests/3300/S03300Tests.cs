using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03300Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03300();
        sut.MinElement([10, 12, 13, 14]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03300();
        sut.MinElement([1, 2, 3, 4]).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S03300();
        sut.MinElement([999, 19, 199]).Should().Be(10);
    }
}
