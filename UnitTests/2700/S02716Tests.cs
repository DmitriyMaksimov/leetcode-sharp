using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02716Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02716();
        Assert.That(sut.MinimizedStringLength("aaabc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02716();
        Assert.That(sut.MinimizedStringLength("cbbd"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02716();
        Assert.That(sut.MinimizedStringLength("dddaaa"), Is.EqualTo(2));
    }
}