using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02460Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02460();
        sut.ApplyOperations(new[] {1, 2, 2, 1, 1, 0}).Should().Equal(1, 4, 2, 0, 0, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02460();
        sut.ApplyOperations(new[] {0, 1}).Should().Equal(1, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02460();
        sut.ApplyOperations(new[] {847, 847, 0, 0, 0, 399, 416, 416, 879, 879, 206, 206, 206, 272}).Should()
            .Equal(1694, 399, 832, 1758, 412, 206, 272, 0, 0, 0, 0, 0, 0, 0);
    }
}