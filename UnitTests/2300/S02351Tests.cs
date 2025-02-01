using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02351Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02351();
        Assert.That(sut.RepeatedCharacter("abccbaacz"), Is.EqualTo('c'));
    }

    [Test]
    public void T2()
    {
        var sut = new S02351();
        Assert.That(sut.RepeatedCharacter("abcdd"), Is.EqualTo('d'));
    }
}