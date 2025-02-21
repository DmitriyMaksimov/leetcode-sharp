using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02115Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02115();
        Assert.That(sut.FindAllRecipes(["bread"], [["yeast", "flour"]], ["yeast", "flour", "corn"]), Is.EqualTo(["bread"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02115();
        Assert.That(sut.FindAllRecipes(["bread", "sandwich"], [["yeast", "flour"], ["bread", "meat"]], ["yeast", "flour", "meat"]), Is.EqualTo(["bread", "sandwich"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02115();
        Assert.That(sut.FindAllRecipes(["bread", "sandwich", "burger"], [["yeast", "flour"], ["bread", "meat"], ["sandwich", "meat", "bread"]], ["yeast", "flour", "meat"]),
            Is.EqualTo(["bread", "sandwich", "burger"]));
    }
}
