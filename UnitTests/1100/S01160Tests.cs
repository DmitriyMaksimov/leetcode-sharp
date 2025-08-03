using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01160Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01160();
        Assert.That(sut.CountCharacters(["cat", "bt", "hat", "tree"], "atach"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01160();
        Assert.That(sut.CountCharacters(["hello", "world", "leetcode"], "welldonehoneyr"), Is.EqualTo(10));
    }
}