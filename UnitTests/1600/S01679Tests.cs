using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01679Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01679();
        sut.MaxOperations(new[] {1, 2, 3, 4}, 5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01679();
        sut.MaxOperations(new[] {3, 1, 3, 4, 3}, 6).Should().Be(1);
    }
}