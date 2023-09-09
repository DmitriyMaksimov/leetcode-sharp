using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01576Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01576();
        sut.ModifyString("?zs").Should().Be("azs");
    }

    [Test]
    public void T2()
    {
        var sut = new S01576();
        sut.ModifyString("ubv?w").Should().Be("ubvaw");
    }
}