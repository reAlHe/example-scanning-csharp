using NUnit.Framework;

namespace V1_0_0.Tests;

public class NexusRepositoryServerVarATests
{

    private NexusRepositoryServerVarA _underTest;
    
    [SetUp]
    public void Setup()
    {
        _underTest = new NexusRepositoryServerVarA();
    }

    [TestCase(TestName="KT Test NexusRepositoryServerVarA Test 1 {VEC_EA_IDs: [EA-01111]}")]
    public void TestThat0IsReturned()
    {
        Assert.AreEqual(0, _underTest.DoSomeMagicAndReturn0());
    }
    
    [TestCase(TestName="KT Test NexusRepositoryServerVarA Test 2 {VEC_EA_IDs: [EA-01456]}")]
    public void TestThatAIsReturned()
    {
        Assert.AreEqual("A", _underTest.DoMoreMagicAndReturnA());
    }
}