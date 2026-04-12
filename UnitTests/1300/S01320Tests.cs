using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01320))]
public class S01320Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01320();
        Assert.That(sut.MinimumDistance("CAKE"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01320();
        Assert.That(sut.MinimumDistance("HAPPY"), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01320();
        Assert.That(sut.MinimumDistance("OPVUWZLCKTDPSUKGHAXIDWHLZFKNBDZEWHBSURTVCADUGTSDMCLDBTAGFWDPGXZBVARNTDICHCUJLNFBQOBTDWMGILXPSFWVGYBZVFFKQIDTOVFAPVNSQJULMVIERWAOXCKXBRI"), Is.EqualTo(295));
    }
}