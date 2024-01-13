using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02079Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02079();
        sut.WateringPlants(new[] {2, 2, 3, 3}, 5).Should().Be(14);
    }

    [Test]
    public void T2()
    {
        var sut = new S02079();
        sut.WateringPlants(new[] {1, 1, 1, 4, 2, 3}, 4).Should().Be(30);
    }

    [Test]
    public void T3()
    {
        var sut = new S02079();
        sut.WateringPlants(new[] {7, 7, 7, 7, 7, 7, 7}, 8).Should().Be(49);
    }
}