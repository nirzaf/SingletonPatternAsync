// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var fooObject = await Foo.CreateAsync();


//Singleton Class with Async Object Initialization 
public sealed class Foo
{
    private Foo()
    {
    }

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    public static Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return result.InitAsync();
    }
}