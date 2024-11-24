using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00816Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00816();
        sut.AmbiguousCoordinates("(123)").Should().BeEquivalentTo("(1, 2.3)", "(1, 23)", "(1.2, 3)", "(12, 3)");
    }

    [Test]
    public void T2()
    {
        var sut = new S00816();
        sut.AmbiguousCoordinates("(0123)").Should().BeEquivalentTo("(0, 1.23)", "(0, 12.3)", "(0, 123)", "(0.1, 2.3)", "(0.1, 23)", "(0.12, 3)");
    }

    [Test]
    public void T3()
    {
        var sut = new S00816();
        sut.AmbiguousCoordinates("(00011)").Should().BeEquivalentTo("(0, 0.011)", "(0.001, 1)");
    }
}
