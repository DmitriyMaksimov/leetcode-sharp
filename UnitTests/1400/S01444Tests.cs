using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01444Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01444();
        sut.Ways(new[] {"A..", "AAA", "..."}, 3).Should().Be(3);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01444();
        sut.Ways(new[] {"A..", "AA.", "..."}, 3).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01444();
        sut.Ways(new[] {"A..", "A..", "..."}, 1).Should().Be(1);
    }
}