public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        try
        {
            //Check for null before accessing
            //This approach avoids the exception entirely
            //Replace NonExistentProperty with actual property name
            int value = this.MyProperty;
            Console.WriteLine(value);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Error accessing property: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}