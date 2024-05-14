using System;

class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.WriteLine("Hello world!");
    }

    static void Feed(ref string state, ref int size) {
        size++;
        Console.WriteLine("Fish fed");
        
    }
}

// SUB feed(BYREF state, BYREF size);
//    size  size + 1;
//    OUTPUT "Fish fed";
//    IF size = 5 THEN;
//       state  "FISH";
//    ENDIF;
// ENDSUB;
 
// thisFishState  "Fish";
// thisFishSize  1;
// OUTPUT thisFishState, " is of size ", thisFishSize;
// WHILE thisFishState <> "FISH";
//    feed(thisFishState, thisFishSize);
// ENDWHILE;
// OUTPUT "It is now a big ", thisFishState;