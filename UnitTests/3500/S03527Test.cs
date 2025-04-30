using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03527))]
public class S03527Test
{
    [Test]
    public void T1()
    {
        var sut = new S03527();
        Assert.That(sut.FindCommonResponse([["good", "ok", "good", "ok"], ["ok", "bad", "good", "ok", "ok"], ["good"], ["bad"]]), Is.EqualTo("good"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03527();
        Assert.That(sut.FindCommonResponse([["good", "ok", "good"], ["ok", "bad"], ["bad", "notsure"], ["great", "good"]]), Is.EqualTo("bad"));
    }
}
