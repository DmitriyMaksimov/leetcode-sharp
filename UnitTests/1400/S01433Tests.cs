using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01433();
        sut.CheckIfCanBreak("abc", "xya").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01433();
        sut.CheckIfCanBreak("abe", "acd").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01433();
        sut.CheckIfCanBreak("leetcodee", "interview").Should().BeTrue();
    }
}
