
using Xunit;
namespace C_Sharp_Playground.Tests{
public class Tests{
     SlidingWindowTechnique slider;
    [Fact]
    public void TestSlidingWIndow()
    {

        //given 
        int[] numbers = {1,2,3,4,5};
        int windowSize = 2;
        slider = new  SlidingWindowTechnique();

        // When
       int result =  slider.MaxSumSubarray(numbers,windowSize);
    
        // Then
        Assert.Equal(9,result);
    }
    
    [Fact]
    public void TwoNumSumTests()
    {
        // Given
        TwoNumSum sums = new TwoNumSum();
        int[] array = {1,2,3,4,5};
        int target = 7;

    
        // When
        var result = sums.TwoNums(array,target);
    
        // Then
        Assert.Equal<int[]>([1,4],result);
    }
}


}