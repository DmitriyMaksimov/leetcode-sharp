using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00528))]
public class S00528Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00528.Solution([1, 3]);
        var array = Enumerable.Repeat(0, 4).Select(_ => sut.PickIndex()).ToArray();
        Assert.That(array.Count(x => x == 0), Is.AtMost(2));
        Assert.That(array.Count(x => x == 1), Is.AtLeast(2));
    }
}