using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01985))]
public class S01985Test
{
    [Test]
    public void T1()
    {
        var sut = new S01985();
        Assert.That(sut.KthLargestNumber(["3", "6", "7", "10"], 4), Is.EqualTo("3"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01985();
        Assert.That(sut.KthLargestNumber(["2", "21", "12", "1"], 3), Is.EqualTo("2"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01985();
        Assert.That(sut.KthLargestNumber(["0", "0"], 2), Is.EqualTo("0"));
    }
}