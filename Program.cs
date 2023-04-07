using System.Diagnostics;
using System;

Magikarp myMagikarp = new Magikarp();
myMagikarp.attack = -1; 

myMagikarp.DoSplash();


Console.ReadKey();

class Magikarp
{
    public float attack;

    public string description = "Only magikarp, the best pokémon";

    public void DoSplash()
    {
        Console.WriteLine("Splash, splash");
        Console.ReadKey();
        Console.WriteLine("Magikarp <3");
        Console.ReadKey();

    }

}
