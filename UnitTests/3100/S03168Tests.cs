using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03168Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03168();
        sut.MinimumChairs("EEEEEEE").Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S03168();
        sut.MinimumChairs("ELELEEL").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S03168();
        sut.MinimumChairs("ELEELEELLL").Should().Be(3);
    }
}