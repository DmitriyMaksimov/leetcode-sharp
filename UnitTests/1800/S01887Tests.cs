using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01887Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01887();
        sut.ReductionOperations(new[] {5, 1, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01887();
        sut.ReductionOperations(new[] {1, 1, 1}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01887();
        sut.ReductionOperations(new[] {1, 1, 2, 2, 3}).Should().Be(4);
    }
}