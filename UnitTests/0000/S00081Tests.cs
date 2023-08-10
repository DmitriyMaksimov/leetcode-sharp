using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00081Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00081();
        sut.Search(new[] {2, 5, 6, 0, 0, 1, 2}, 0).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00081();
        sut.Search(new[] {2, 5, 6, 0, 0, 1, 2}, 3).Should().BeFalse();
    }
}