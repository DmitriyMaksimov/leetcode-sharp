using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01945Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01945();
        Assert.That(sut.GetLucky("iiii", 1), Is.EqualTo(36));
    }

    [Test]
    public void T2()
    {
        var sut = new S01945();
        Assert.That(sut.GetLucky("leetcode", 2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01945();
        Assert.That(sut.GetLucky("zbax", 2), Is.EqualTo(8));
    }

    [Test]
    public void T4()
    {
        var sut = new S01945();
        Assert.That(sut.GetLucky("iaozzbyqzwbpurzze", 2), Is.EqualTo(5));
    }

    [Test]
    public void T5()
    {
        var sut = new S01945();
        Assert.That(sut.GetLucky("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss", 2), Is.EqualTo(1));
    }
}