using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03370();
        sut.SmallestNumber(5).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S03370();
        sut.SmallestNumber(10).Should().Be(15);
    }

    [Test]
    public void T3()
    {
        var sut = new S03370();
        sut.SmallestNumber(3).Should().Be(3);
    }

    [Test]
    public void T4()
    {
        var sut = new S03370();
        sut.SmallestNumber(4).Should().Be(7);
    }
}
