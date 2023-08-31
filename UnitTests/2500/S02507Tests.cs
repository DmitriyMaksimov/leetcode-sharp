using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02507();
        sut.SmallestValue(15).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02507();
        sut.SmallestValue(3).Should().Be(3);
    }
}