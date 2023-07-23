using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02643Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02643();
        sut.RowAndMaximumOnes(new[] {new[] {0, 1}, new[] {1, 0}}).Should().Equal(0, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02643();
        sut.RowAndMaximumOnes(new[] {new[] {0, 0, 0}, new[] {0, 1, 1}}).Should().Equal(1, 2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02643();
        sut.RowAndMaximumOnes(new[] {new[] {0, 0}, new[] {1, 1}, new[] {0, 0}}).Should().Equal(1, 2);
    }
}