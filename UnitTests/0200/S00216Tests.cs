using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00216Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00216();
        sut.CombinationSum3(3, 7).Should()
            .BeEquivalentTo(new[] {new List<int> {1, 2, 4}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00216();
        sut.CombinationSum3(3, 9).Should()
            .BeEquivalentTo(new[] {new List<int> {1,2,6 }, new List<int> {1,3,5 }, new List<int> {2,3,4 }});
    }

    [Test]
    public void T3()
    {
        var sut = new S00216();
        sut.CombinationSum3(4, 1).Should().BeEmpty();
    }
}