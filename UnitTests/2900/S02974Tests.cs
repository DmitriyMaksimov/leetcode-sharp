using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02974Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02974();
        sut.NumberGame(new[] {5, 4, 2, 3}).Should().Equal(3, 2, 5, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02974();
        sut.NumberGame(new[] {2, 5}).Should().Equal(5, 2);
    }
}