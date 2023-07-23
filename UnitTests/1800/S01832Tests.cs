using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01832Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01832();
        sut.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01832();
        sut.CheckIfPangram("leetcode").Should().BeFalse();
    }
}