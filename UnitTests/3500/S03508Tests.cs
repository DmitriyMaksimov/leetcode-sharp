using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03508))]
public class S03508Tests
{
    [Test]
    public void T1()
    {
        var router = new S03508.Router(3);
        Assert.That(router.AddPacket(1, 4, 90), Is.True); // Packet is added. Return True.
        Assert.That(router.AddPacket(2, 5, 90), Is.True); // Packet is added. Return True.
        Assert.That(router.AddPacket(1, 4, 90), Is.False); // This is a duplicate packet. Return False.
        Assert.That(router.AddPacket(3, 5, 95), Is.True); // Packet is added. Return True
        Assert.That(router.AddPacket(4, 5, 105), Is.True); // Packet is added, [1, 4, 90] is removed as number of packets exceeds memoryLimit. Return True.
        Assert.That(router.ForwardPacket(), Is.EqualTo([2, 5, 90])); // Return [2, 5, 90] and remove it from router.
        Assert.That(router.AddPacket(5, 2, 110), Is.True); // Packet is added. Return True.
        Assert.That(router.GetCount(5, 100, 110), Is.EqualTo(1)); // The only packet with destination 5 and timestamp in the inclusive range [100, 110] is [4, 5, 105]. Return 1.
    }

    [Test]
    public void T2()
    {
        var router = new S03508.Router(2);
        Assert.That(router.AddPacket(7, 4, 90), Is.True); // Return True.
        Assert.That(router.ForwardPacket(), Is.EqualTo([7, 4, 90])); // Return [7, 4, 90].
        Assert.That(router.ForwardPacket(), Is.Empty); // There are no packets left, return [].
    }
}