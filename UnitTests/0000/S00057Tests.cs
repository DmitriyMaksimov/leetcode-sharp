using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00057Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00057();
        sut.Insert(new[] {new[] {1, 3}, new[] {6, 9}}, new[] {2, 5}).Should().BeEquivalentTo(new[] {new[] {1, 5}, new[] {6, 9}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00057();
        sut.Insert(new[] {new[] {1, 2}, new[] {3, 5}, new[] {6, 7}, new[] {8, 10}, new[] {12, 16}}, new[] {4, 8}).Should()
            .BeEquivalentTo(new[] {new[] {1, 2}, new[] {3, 10}, new[] {12, 16}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00057();
        sut.Insert(Array.Empty<int[]>(), new[] {5, 7}).Should().BeEquivalentTo(new[] {new[] {5, 7}});
    }

    [Test]
    public void T4()
    {
        var sut = new S00057();
        sut.Insert(new[] {new[] {1, 5}}, new[] {2, 7}).Should().BeEquivalentTo(new[] {new[] {1, 7}});
    }
}