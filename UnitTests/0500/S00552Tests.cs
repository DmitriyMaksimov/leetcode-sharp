using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00552Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00552();
        sut.CheckRecord(2).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00552();
        sut.CheckRecord(1).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00552();
        sut.CheckRecord(10101).Should().Be(183236316);
    }
}