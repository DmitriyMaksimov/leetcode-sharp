using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00401Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00401();
        Assert.That(sut.ReadBinaryWatch(1), Is.EqualTo((string[]) ["0:01","0:02","0:04","0:08","0:16","0:32","1:00","2:00","4:00","8:00"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00401();
        Assert.That(sut.ReadBinaryWatch(9), Is.Empty);
    }
}
