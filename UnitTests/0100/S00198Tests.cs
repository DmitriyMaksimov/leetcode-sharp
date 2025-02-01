using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00198Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00198();
        Assert.That(sut.Rob(new[] {1, 2, 3, 1}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00198();
        Assert.That(sut.Rob(new[] {2, 7, 9, 3, 1}), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S00198();
        Assert.That(sut.Rob(new[]
        {
            114, 117, 207, 117, 235, 82, 90, 67, 143, 146, 53, 108, 200, 91, 80, 223, 58, 170, 110, 236, 81, 90, 222, 160, 165, 195, 187, 199, 114, 235, 197, 187, 69, 129, 64, 214,
            228, 78, 188, 67, 205, 94, 205, 169, 241, 202, 144, 240
        }), Is.EqualTo(4173));
    }
}