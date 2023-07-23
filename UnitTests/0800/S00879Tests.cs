using leetcode_sharp;

namespace UnitTests;

public class S00879Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00879();
        sut.ProfitableSchemes(5, 3, new[] {2, 2}, new[] {2, 3}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00879();
        sut.ProfitableSchemes(10, 5, new[] {2, 3, 5}, new[] {6, 7, 8}).Should().Be(7);
    }
}