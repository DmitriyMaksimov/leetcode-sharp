using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01299();
        sut.ReplaceElements(new[] {17, 18, 5, 4, 6, 1}).Should().Equal(18, 6, 6, 6, 1, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01299();
        sut.ReplaceElements(new[] {400}).Should().Equal(-1);
    }
}