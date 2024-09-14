using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01130Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01130();
        sut.MctFromLeafValues([6, 2, 4]).Should().Be(32);
    }

    [Test]
    public void T2()
    {
        var sut = new S01130();
        sut.MctFromLeafValues([4, 11]).Should().Be(44);
    }
}
