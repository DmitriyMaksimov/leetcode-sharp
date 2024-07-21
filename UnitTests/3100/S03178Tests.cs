using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03178Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03178();
        sut.NumberOfChild(2, 5).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03178();
        sut.NumberOfChild(5, 6).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S03178();
        sut.NumberOfChild(4, 2).Should().Be(2);
    }
}