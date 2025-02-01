using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00229Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00229();
        Assert.That(sut.MajorityElement(new[] {3, 2, 3}), Is.EqualTo((int[]) [3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00229();
        Assert.That(sut.MajorityElement(new[] {1}), Is.EqualTo((int[]) [1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00229();
        Assert.That(sut.MajorityElement(new[] {1, 2}), Is.EqualTo((int[]) [1, 2]));
    }
}