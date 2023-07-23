using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00242Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00242();
        sut.IsAnagram("anagram", "nagaram").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00242();
        sut.IsAnagram("rat", "car").Should().BeFalse();
    }
}