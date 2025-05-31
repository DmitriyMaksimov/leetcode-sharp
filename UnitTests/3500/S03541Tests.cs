using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03541))]
public class S03541Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03541();
        Assert.That(sut.MaxFreqSum("successes"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03541();
        Assert.That(sut.MaxFreqSum("aeiaeia"), Is.EqualTo(3));
    }
}
