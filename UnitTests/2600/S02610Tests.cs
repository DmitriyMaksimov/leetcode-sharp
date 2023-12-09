using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02610Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02610();
        sut.FindMatrix(new[] {1, 3, 4, 1, 2, 3, 1}).Should()
            .BeEquivalentTo(new[] {new[] {1, 3, 4, 2}, new[] {1, 3}, new[] {1}});
    }

    [Test]
    public void T2()
    {
        var sut = new S02610();
        sut.FindMatrix(new[] {1, 2, 3, 4}).Should().BeEquivalentTo(new[] {new[] {1, 2, 3, 4}});
    }
}