using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00636Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00636();
        Assert.That(sut.ExclusiveTime(2, ["0:start:0", "1:start:2", "1:end:5", "0:end:6"]), Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00636();
        Assert.That(sut.ExclusiveTime(1, ["0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7"]), Is.EqualTo((int[]) [8]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00636();
        Assert.That(sut.ExclusiveTime(2, ["0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7"]), Is.EqualTo((int[]) [7, 1]));
    }
}
