namespace CRUDTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            MyMath math = new MyMath();
            int inp1 = 10, inp2 = 20;
            int expected = 30;

            //Act
            int actual = math.Add(inp1, inp2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}