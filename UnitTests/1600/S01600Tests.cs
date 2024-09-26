using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01600Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01600.ThroneInheritance("king");
        sut.Birth("king", "andy"); // order: king > andy
        sut.Birth("king", "bob"); // order: king > andy > bob
        sut.Birth("king", "catherine"); // order: king > andy > bob > catherine
        sut.Birth("andy", "matthew"); // order: king > andy > matthew > bob > catherine
        sut.Birth("bob", "alex"); // order: king > andy > matthew > bob > alex > catherine
        sut.Birth("bob", "asha"); // order: king > andy > matthew > bob > alex > asha > catherine
        sut.GetInheritanceOrder().Should().Equal("king", "andy", "matthew", "bob", "alex", "asha", "catherine");
        sut.Death("bob"); // order: king > andy > matthew > bob > alex > asha > catherine
        sut.GetInheritanceOrder().Should().Equal("king", "andy", "matthew", "alex", "asha", "catherine");
    }
}
