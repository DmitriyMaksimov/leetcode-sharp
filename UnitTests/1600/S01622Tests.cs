using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01622))]
public class S01622Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01622.Fancy();
        sut.Append(2); // fancy sequence: [2]
        sut.AddAll(3); // fancy sequence: [2+3] -> [5]
        sut.Append(7); // fancy sequence: [5, 7]
        sut.MultAll(2); // fancy sequence: [5*2, 7*2] -> [10, 14]
        Assert.That(sut.GetIndex(0), Is.EqualTo(10)); // return 10
        sut.AddAll(3); // fancy sequence: [10+3, 14+3] -> [13, 17]
        sut.Append(10); // fancy sequence: [13, 17, 10]
        sut.MultAll(2); // fancy sequence: [13*2, 17*2, 10*2] -> [26, 34, 20]
        Assert.That(sut.GetIndex(0), Is.EqualTo(26)); // return 26
        Assert.That(sut.GetIndex(1), Is.EqualTo(34)); // return 34
        Assert.That(sut.GetIndex(2), Is.EqualTo(20)); // return 20
    }
}