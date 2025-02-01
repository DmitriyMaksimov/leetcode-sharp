using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01832Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01832();
        Assert.That(sut.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01832();
        Assert.That(sut.CheckIfPangram("leetcode"), Is.False);
    }
}
