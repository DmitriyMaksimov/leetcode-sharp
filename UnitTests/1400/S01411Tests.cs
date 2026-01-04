using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01411))]
public class S01411Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01411();
        Assert.That(sut.NumOfWays(1), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S01411();
        Assert.That(sut.NumOfWays(5000), Is.EqualTo(30228214));
    }
}