using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00884Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00884();
        Assert.That(sut.UncommonFromSentences("this apple is sweet", "this apple is sour"), Is.EqualTo((string[]) ["sweet", "sour"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00884();
        Assert.That(sut.UncommonFromSentences("apple apple", "banana"), Is.EqualTo((string[]) ["banana"]));
    }
}
