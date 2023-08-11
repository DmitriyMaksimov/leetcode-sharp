using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00238Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00238();
        sut.ProductExceptSelf(new[] {1, 2, 3, 4}).Should().Equal(24, 12, 8, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00238();
        sut.ProductExceptSelf(new[] {-1, 1, 0, -3, 3}).Should().Equal(0, 0, 9, 0, 0);
    }
}