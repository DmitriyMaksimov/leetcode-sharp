using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03216Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03216();
        Assert.That(sut.GetSmallestString("45320"), Is.EqualTo("43520"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03216();
        Assert.That(sut.GetSmallestString("001"), Is.EqualTo("001"));
    }
}