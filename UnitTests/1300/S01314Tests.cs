using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01314Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01314();
        Assert.That(sut.MatrixBlockSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]], 1), Is.EquivalentTo([
            [12, 21, 16], [27, 45, 33], new[] {24, 39, 28}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01314();
        Assert.That(sut.MatrixBlockSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]], 2), Is.EquivalentTo([
            [45, 45, 45], [45, 45, 45], new[] {45, 45, 45}
        ]));
    }
}