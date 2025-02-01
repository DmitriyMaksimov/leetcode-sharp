using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00347();
        Assert.That(sut.TopKFrequent(new[] {1,1,1,2,2,3}, 2), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00347();
        Assert.That(sut.TopKFrequent(new[] {1}, 1), Is.EqualTo((int[]) [1]));
    }
}