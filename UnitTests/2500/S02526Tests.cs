using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02526Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02526.DataStream(4, 3);
        Assert.That(sut.Consec(4), Is.False); // Only 1 integer is parsed, so returns False.
        Assert.That(sut.Consec(4), Is.False); // Only 2 integers are parsed. Since 2 is less than k, returns False.
        Assert.That(sut.Consec(4), Is.True); // The 3 integers parsed are all equal to value, so returns True.
        Assert.That(sut.Consec(3), Is.False); // The last k integers parsed in the stream are [4,4,3]. Since 3 is not equal to value, it returns False.
    }
}
