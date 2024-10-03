using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03100Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03100();
        sut.MaxBottlesDrunk(13, 6).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S03100();
        sut.MaxBottlesDrunk(10, 3).Should().Be(13);
    }
}
