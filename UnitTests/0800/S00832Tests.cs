using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00832Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00832();
        var image = sut.FlipAndInvertImage(new[] {new[] {1, 1, 0}, new[] {1, 0, 1}, new[] {0, 0, 0}});
        image.Should().HaveCount(3);
        image[0].Should().Equal(1, 0, 0);
        image[1].Should().Equal(0, 1, 0);
        image[2].Should().Equal(1, 1, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00832();
        var image = sut.FlipAndInvertImage(new[] {new[] {1, 1, 0, 0}, new[] {1, 0, 0, 1}, new[] {0, 1, 1, 1}, new[] {1, 0, 1, 0}});
        image.Should().HaveCount(4);
        image[0].Should().Equal(1, 1, 0, 0);
        image[1].Should().Equal(0, 1, 1, 0);
        image[2].Should().Equal(0, 0, 0, 1);
        image[3].Should().Equal(1, 0, 1, 0);
    }
}