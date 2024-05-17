using System;

class Program
{
    static void Main()
    {
        string thisFishState = "Fish";
        int thisFishSize =1;
        Console.WriteLine($"{thisFishState} is of size {thisFishSize}");
        while (thisFishState != "FISH")
        {
            Feed(ref thisFishState, ref thisFishSize);
        }
        Console.WriteLine($"It is now a big {thisFishState}");
    }

    static void Feed(ref string state, ref int size) {
        size++;
        Console.WriteLine("Fish fed");
        if (size == 5) {
            state = "FISH";
        }
    }
}

// thisFishState  "Fish";
// thisFishSize  1;
// OUTPUT thisFishState, " is of size ", thisFishSize;
// WHILE thisFishState <> "FISH";
//    feed(thisFishState, thisFishSize);
// ENDWHILE;
// OUTPUT "It is now a big ", thisFishState;

// SUB feed(BYREF state, BYREF size);
//    size  size + 1;
//    OUTPUT "Fish fed";
//    IF size = 5 THEN;
//       state  "FISH";
//    ENDIF;
// ENDSUB;
 