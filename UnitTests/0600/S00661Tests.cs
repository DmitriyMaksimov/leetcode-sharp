using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00661Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00661();
        sut.ImageSmoother(new[] {new[] {1, 1, 1}, new[] {1, 0, 1}, new[] {1, 1, 1}}).Should()
            .BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {0, 0, 0}, new[] {0, 0, 0}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00661();
        sut.ImageSmoother(new[] {new[] {100, 200, 100}, new[] {200, 50, 200}, new[] {100, 200, 100}}).Should()
            .BeEquivalentTo(new[] {new[] {137, 141, 137}, new[] {141, 138, 141}, new[] {137, 141, 137}});
    }
}