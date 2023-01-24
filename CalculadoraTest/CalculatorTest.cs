namespace CalculadoraTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SendEmptyString_ReturnZero()
        {
            var calculator = new Calculator();

            int result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void Add_SendTwoNumbersSeparatedByComma_ReturnAddOfValues(string values, int expected)
        {
            var calculator = new Calculator();

            int result = calculator.Add(values);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10,14,16,12,18", 70)]
        [InlineData("10,10,10", 30)]
        [InlineData("10,14,16,12,18,10,10,20,40", 150)]
        public void Add_SendManyNumbersSeparatedByComma_ReturnAddOfValues(string values, int expected)
        {
            var calculator = new Calculator();

            int result = calculator.Add(values);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_SendNegativeNumber_ReturnException()
        {
            var calculator = new Calculator();

            Assert.Throws<Exception>(() => calculator.Add("3,2,-3"));
        }

        [Fact]
        public void Add_SendNumbersSeparatedByInvalidDelimiter_ReturnException()
        {
            var calculator = new Calculator();

            Assert.Throws<Exception>(() => calculator.Add("1|2|3"));
        }

        [Fact]
        public void Add_SendInvalidCaracterSeparatedByComma_ReturnException()
        {
            var calculator = new Calculator();

            Assert.Throws<Exception>(() => calculator.Add("1,a"));
        }

        [Theory]
        [InlineData("0/100,2/120/3/3001/5", 110)]
        [InlineData("3/12300,3/1210/3/31001/3/99", 111)]
        [InlineData("3/12300,3/1210/3/31001/3/100", 112)]
        public void Add_SendNumbersGreaterThanOneHoundred_ReturnAddOfValuesWithoutNumbersGreaterThanOneHundred(string values, int expected)
        {
            var calcultator = new Calculator();

            int result = calcultator.Add(values);

            Assert.Equal(expected, result);
        }
    }
}