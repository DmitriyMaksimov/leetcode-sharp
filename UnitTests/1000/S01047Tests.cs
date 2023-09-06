using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01047Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01047();
        sut.RemoveDuplicates("abbaca").Should().Be("ca");
    }

    [Test]
    public void T2()
    {
        var sut = new S01047();
        sut.RemoveDuplicates("azxxzy").Should().Be("ay");
    }
}