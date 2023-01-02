using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00542Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00542();
        sut.UpdateMatrix(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}})
            .Should().BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00542();
        sut.UpdateMatrix(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {1,1,1}})
            .Should().BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {1, 2, 1}});
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00542();
        sut.UpdateMatrix(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}})
            .Should().BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}});
    }
}