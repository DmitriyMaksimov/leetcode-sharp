using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00832Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00832();
        var image = sut.FlipAndInvertImage([[1, 1, 0], [1, 0, 1], [0, 0, 0]]);
        Assert.That(image, Has.Length.EqualTo(3));
        Assert.That(image[0], Is.EqualTo((int[]) [1, 0, 0]));
        Assert.That(image[1], Is.EqualTo((int[]) [0, 1, 0]));
        Assert.That(image[2], Is.EqualTo((int[]) [1, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00832();
        var image = sut.FlipAndInvertImage([
            [1, 1, 0, 0], [1, 0, 0, 1], [0, 1, 1, 1], [1, 0, 1, 0]
        ]);
        Assert.That(image, Has.Length.EqualTo(4));
        Assert.That(image[0], Is.EqualTo((int[]) [1, 1, 0, 0]));
        Assert.That(image[1], Is.EqualTo((int[]) [0, 1, 1, 0]));
        Assert.That(image[2], Is.EqualTo((int[]) [0, 0, 0, 1]));
        Assert.That(image[3], Is.EqualTo((int[]) [1, 0, 1, 0]));
    }
}
