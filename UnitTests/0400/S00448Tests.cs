using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00448();
        sut.FindDisappearedNumbers(new[] {4, 3, 2, 7, 8, 2, 3, 1}).Should().Equal(5, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00448();
        sut.FindDisappearedNumbers(new[] {1, 1}).Should().Equal(2);
    }
}