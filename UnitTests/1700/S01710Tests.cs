using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01710Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01710();
        sut.MaximumUnits(new[] {new[] {1, 3}, new[] {2, 2}, new[] {3, 1}}, 4).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S01710();
        sut.MaximumUnits(new[] {new[] {5, 10}, new[] {2, 5}, new[] {4, 7}, new[] {3, 9}}, 10).Should().Be(91);
    }
}