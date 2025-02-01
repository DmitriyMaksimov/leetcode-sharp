using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01592();
        Assert.That(sut.ReorderSpaces("  this   is  a sentence "), Is.EqualTo("this   is   a   sentence"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01592();
        Assert.That(sut.ReorderSpaces(" practice   makes   perfect"), Is.EqualTo("practice   makes   perfect "));
    }
}