using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00864Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00864();
        sut.ShortestPathAllKeys(new[] {"@.a..", "###.#", "b.A.B"}).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00864();
        sut.ShortestPathAllKeys(new[] {"@..aA", "..B#.", "....b"}).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S00864();
        sut.ShortestPathAllKeys(new[] {"@Aa"}).Should().Be(-1);
    }
}