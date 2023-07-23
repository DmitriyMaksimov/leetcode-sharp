using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00119Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00119();
        sut.GetRow(3).Should().Equal(1, 3, 3, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00119();
        sut.GetRow(0).Should().Equal(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00119();
        sut.GetRow(1).Should().Equal(1, 1);
    }

    [Test]
    public void T4()
    {
        var sut = new S00119();
        sut.GetRow(30).Should().Equal(1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225, 119759850, 145422675, 155117520, 145422675,
            119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800, 593775, 142506, 27405, 4060, 435, 30, 1);
    }
}