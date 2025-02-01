using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00433();
        Assert.That(sut.MinMutation("AACCGGTT", "AACCGGTA", new[] {"AACCGGTA"}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00433();
        Assert.That(sut.MinMutation("AACCGGTT", "AAACGGTA", new[] {"AACCGGTA", "AACCGCTA", "AAACGGTA"}), Is.EqualTo(2));
    }
}