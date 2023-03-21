using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00217Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00217();
        sut.ContainsDuplicate(new[] {1, 2, 3, 1}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00217();
        sut.ContainsDuplicate(new[] {1, 2, 3, 4}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00217();
        sut.ContainsDuplicate(new[] {1,1,1,3,3,4,3,2,4,2}).Should().BeTrue();
    }
}