using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00242Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00242();
        Assert.That(sut.IsAnagram("anagram", "nagaram"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00242();
        Assert.That(sut.IsAnagram("rat", "car"), Is.False);
    }
}
