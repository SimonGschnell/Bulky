using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Internal;

namespace bulky.Injection;

public class TestInjection: ITestInjection{
    
    public int Value1 {get; set;}
    public int Value2 {get; set;}

    public TestInjection(){
        Value1 = Random.Shared.Next(1,1000);
        Value2 = Random.Shared.Next(1,1000);
    }


}