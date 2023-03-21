using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00167Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00167();
        sut.TwoSum(new[] {2, 7, 11, 15}, 9).Should().Equal(1, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00167();
        sut.TwoSum(new[] {2, 3, 4}, 6).Should().Equal(1, 3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00167();
        sut.TwoSum(new[] {-1, 0}, -1).Should().Equal(1, 2);
    }

    [Test]
    public void T4()
    {
        var sut = new S00167();
        sut.TwoSum(new[] {5, 25, 75}, 100).Should().Equal(2, 3);
    }
}