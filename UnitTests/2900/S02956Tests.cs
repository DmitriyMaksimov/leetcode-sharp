using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02956Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02956();
        sut.FindIntersectionValues(new[] {4, 3, 2, 3, 1}, new[] {2, 2, 5, 2, 3, 6}).Should().Equal(3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02956();
        sut.FindIntersectionValues(new[] {3, 4, 2, 3}, new[] {1, 5}).Should().Equal(0, 0);
    }
}