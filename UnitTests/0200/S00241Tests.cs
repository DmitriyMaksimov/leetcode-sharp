using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00241Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00241();
        sut.DiffWaysToCompute("2-1-1").Should().BeEquivalentTo([0, 2]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00241();
        sut.DiffWaysToCompute("2*3-4*5").Should().BeEquivalentTo([-34, -14, -10, -10, 10]);
    }
}
