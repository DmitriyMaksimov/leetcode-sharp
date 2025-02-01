using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01598();
        Assert.That(sut.MinOperations(new[] {"d1/", "d2/", "../", "d21/", "./"}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01598();
        Assert.That(sut.MinOperations(new[] {"d1/", "d2/", "./", "d3/", "../", "d31/"}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01598();
        Assert.That(sut.MinOperations(new[] {"d1/", "../", "../", "../"}), Is.EqualTo(0));
    }
}