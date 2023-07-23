using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01834Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01834();
        sut.GetOrder(new[] {new[] {1, 2}, new[] {2, 4}, new[] {3, 2}, new[] {4, 1}}).Should().Equal(0, 2, 3, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01834();
        sut.GetOrder(new[] {new[] {7, 10}, new[] {7, 12}, new[] {7, 5}, new[] {7, 4}, new[] {7, 2}}).Should().Equal(4, 3, 2, 0, 1);
    }
}