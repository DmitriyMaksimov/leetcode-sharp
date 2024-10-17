using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01400Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01400();
        sut.CanConstruct("annabelle", 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01400();
        sut.CanConstruct("leetcode", 3).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01400();
        sut.CanConstruct("true", 4).Should().BeTrue();
    }
}
