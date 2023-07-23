using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00989Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00989();
        sut.AddToArrayForm(new[] {1, 2, 0, 0}, 34).Should().Equal(1, 2, 3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00989();
        sut.AddToArrayForm(new[] {2, 7, 4}, 181).Should().Equal(4, 5, 5);
    }

    [Test]
    public void T3()
    {
        var sut = new S00989();
        sut.AddToArrayForm(new[] {2, 1, 5}, 806).Should().Equal(1, 0, 2, 1);
    }
}