public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        int value = this.MyProperty * 2; // potential error if MyProperty is not set before this line
    }
}