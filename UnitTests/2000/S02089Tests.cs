using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02089Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02089();
        sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 2).Should().Equal(1, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02089();
        sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 3).Should().Equal(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02089();
        sut.TargetIndices(new[] {1, 2, 5, 2, 3}, 5).Should().Equal(4);
    }
}