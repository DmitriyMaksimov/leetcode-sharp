using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01579Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01579();
        sut.MaxNumEdgesToRemove(4, new[] {new[] {3,1,2}, new[] {3,2,3}, new[] {1,1,3}, new[] {1,2,4}, new[] {1,1,2}, new[] {2,3,4}}).Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01579();
        sut.MaxNumEdgesToRemove(4, new[] {new[] {3,1,2}, new[] {3,2,3}, new[] {1,1,4}, new[] {2,1,4}}).Should().Be(0);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01579();
        sut.MaxNumEdgesToRemove(4, new[] {new[] {3,2,3}, new[] {1,1,2}, new[] {2,3,4}}).Should().Be(-1);
    }
}