namespace LeapYear.tests;

public class LeapYearTests
{
    
    [Fact]
    public void Is4aLeapYear()
    {
        // Given
        var _sut = new LeapYearCalculator();

        // When
        var result = _sut.isLeapYear(4);
        // Then
        result.Should().Be(true);
    }

    [Fact]
    public void Is100aLeapYear()
    {
        // Given
            var _sut = new LeapYearCalculator();
        // When
            var result = _sut.isLeapYear(100);
        // Then
        result.Should().Be(false);
    }  
}