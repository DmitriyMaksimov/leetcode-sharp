using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00474))]
public class S00474Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00474();
        Assert.That(sut.FindMaxForm(["10", "0001", "111001", "1", "0"], 5, 3), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00474();
        Assert.That(sut.FindMaxForm(["10", "0", "1"], 1, 1), Is.EqualTo(2));
    }
}
