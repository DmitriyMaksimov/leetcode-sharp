using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01029Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01029();
        sut.TwoCitySchedCost([[10, 20], [30, 200], [400, 50], [30, 20]]).Should().Be(110);
    }

    [Test]
    public void T2()
    {
        var sut = new S01029();
        sut.TwoCitySchedCost([[259, 770], [448, 54], [926, 667], [184, 139], [840, 118], [577, 469]]).Should().Be(1859);
    }

    [Test]
    public void T3()
    {
        var sut = new S01029();
        sut.TwoCitySchedCost([[515, 563], [451, 713], [537, 709], [343, 819], [855, 779], [457, 60], [650, 359], [631, 42]]).Should().Be(3086);
    }
}
