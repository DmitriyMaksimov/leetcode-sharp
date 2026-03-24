using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02906))]
public class S02906Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02906();
        var result = sut.ConstructProductMatrix([[1, 2], [3, 4]]);
        Assert.That(result, Is.EqualTo([(int[])[24, 12], [8, 6]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02906();
        var result = sut.ConstructProductMatrix([[12345], [2], [1]]);
        Assert.That(result, Is.EqualTo([(int[])[2], [0], [0]]));
    }
}