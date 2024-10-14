using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00858Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00858();
        sut.MirrorReflection(2, 1).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00858();
        sut.MirrorReflection(3, 1).Should().Be(1);
    }
}
