public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod() {
        // Initialize MyProperty before using it
        MyProperty = 10;
        Console.WriteLine(MyProperty); 
    }
    public void MyMethod2(){
        if(MyProperty == 0){
            // handle the case of MyProperty not being initialized
            Console.WriteLine("MyProperty is not initialized");
            MyProperty = 10; //or assign a value
        }
        Console.WriteLine(MyProperty);
    }
} 