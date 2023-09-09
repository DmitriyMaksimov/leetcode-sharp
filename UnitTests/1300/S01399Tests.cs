using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01399Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01399();
        sut.CountLargestGroup(13).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01399();
        sut.CountLargestGroup(2).Should().Be(2);
    }
}