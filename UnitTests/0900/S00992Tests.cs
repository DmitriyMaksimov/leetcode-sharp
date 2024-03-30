using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00992Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00992();
        sut.SubarraysWithKDistinct([1,2,1,2,3], 2).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00992();
        sut.SubarraysWithKDistinct([1,2,1,3,4], 3).Should().Be(3);
    }
}