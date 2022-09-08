namespace TestProgram;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double[] d = Store_Class.exchange(5120.25);
        double[] Test1 = {5,0,1,0,1,0,0,0,0,0,1};  
        Assert.Equal(d,Test1);
    }
}