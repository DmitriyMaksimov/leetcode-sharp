using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01925();
        sut.CountTriples(5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01925();
        sut.CountTriples(10).Should().Be(4);
    }
}