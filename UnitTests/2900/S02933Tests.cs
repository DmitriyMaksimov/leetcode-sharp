using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02933))]
public class S02933Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02933();
        Assert.That(sut.FindHighAccessEmployees([["a","0549"],["b","0457"],["a","0532"],["a","0621"],["b","0540"]]), Is.EqualTo(["a"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02933();
        Assert.That(sut.FindHighAccessEmployees([["d","0002"],["c","0808"],["c","0829"],["e","0215"],["d","1508"],["d","1444"],["d","1410"],["c","0809"]]), Is.EqualTo(["c","d"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02933();
        Assert.That(sut.FindHighAccessEmployees([["cd","1025"],["ab","1025"],["cd","1046"],["cd","1055"],["ab","1124"],["ab","1120"]]), Is.EqualTo(["ab", "cd"]));
    }
}