using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01636Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01636();
        sut.FrequencySort(new[] {1, 1, 2, 2, 2, 3}).Should().Equal(3, 1, 1, 2, 2, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01636();
        sut.FrequencySort(new[] {2, 3, 1, 3, 2}).Should().Equal(1, 3, 3, 2, 2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01636();
        sut.FrequencySort(new[] {-1, 1, -6, 4, 5, -6, 1, 4, 1}).Should().Equal(5, -1, 4, 4, -6, -6, 1, 1, 1);
    }
}