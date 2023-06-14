namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // 테스트 실패 
            var failTest = 1;
            Assert.True(failTest == 2);
            // Assert.True(failTest == 1);
        }
    }
}