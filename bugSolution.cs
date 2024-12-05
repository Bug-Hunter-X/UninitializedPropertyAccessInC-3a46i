public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty with a default value

    public void MyMethod()
    {
        // Initialize MyProperty before use 
        // int value = this.MyProperty * 2; //This line is safe now

        //Alternative
        if(this.MyProperty !=0)
        {
            int value = this.MyProperty * 2;
        }
        else
        {
            //Handle it
        }
    }
}