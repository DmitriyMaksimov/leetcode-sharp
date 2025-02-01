using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01016Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01016();
        Assert.That(sut.QueryString("0110", 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01016();
        Assert.That(sut.QueryString("0110", 4), Is.False);
    }
}
