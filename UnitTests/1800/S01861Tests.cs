using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01861Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01861();
        Assert.That(sut.RotateTheBox([['#', '.', '#']]), Is.EquivalentTo(
            (char[][]) [
            ['.'],
            ['#'],
            ['#']
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01861();
        Assert.That(sut.RotateTheBox([
            ['#', '.', '*', '.'],
            ['#', '#', '*', '.']
        ]), Is.EquivalentTo(
            (char[][]) [
            ['#', '.'],
            ['#', '#'],
            ['*', '*'],
            ['.', '.']
        ]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01861();
        Assert.That(sut.RotateTheBox([
            ['#', '#', '*', '.', '*', '.'],
            ['#', '#', '#', '*', '.', '.'],
            ['#', '#', '#', '.', '#', '.']
        ]), Is.EquivalentTo(
            (char[][]) [
            ['.', '#', '#'],
            ['.', '#', '#'],
            ['#', '#', '*'],
            ['#', '*', '.'],
            ['#', '.', '*'],
            ['#', '.', '.']
        ]));
    }
}
