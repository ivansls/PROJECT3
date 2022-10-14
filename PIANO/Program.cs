using System.Runtime.ExceptionServices;

bool cicle = true;
int [] allOctave = new int [12];
int[] firstOctave = new int[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 };
int[] secondOctave = new int[] {131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247};
int[] thirdOctave = new int[] {262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 46, 494};
int[] fourthOctave = new int[] {523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988};

void Octave(ConsoleKeyInfo note, int[] allOct, int[] firstOctave, int[] secondOctave, int[] thirdOctave, int[] fourthOctave)
{
    if (note.Key == ConsoleKey.F1)
    {
        Console.WriteLine("1 Octave");
        allOctave = firstOctave;
    }
    else if (note.Key == ConsoleKey.F2)
    {
        Console.WriteLine("2 Octave");
        allOctave = secondOctave;
    }
    else if (note.Key == ConsoleKey.F3)
    {
        Console.WriteLine("3 Octave");
        allOctave = thirdOctave;
    }
    else if (note.Key == ConsoleKey.F4)
    {
        Console.WriteLine("4 Octave");
        allOctave = fourthOctave;
    }

    else if (note.Key == ConsoleKey.Escape)
    {
        cicle = false;
    }
    else
    {
        Sound(note, allOctave);
    }


}
void Sound(ConsoleKeyInfo note, int[] allOctave)
{
    if (note.Key == ConsoleKey.A)
    {
        Console.Beep(allOctave[5], 300);
    }
    else if (note.Key == ConsoleKey.W)
    {
        Console.WriteLine("w");
        Console.Beep(allOctave[1], 300);
    }
    else if (note.Key == ConsoleKey.S)
    {
        Console.WriteLine("s");
        Console.Beep(allOctave[2], 50);
    }
    else if (note.Key == ConsoleKey.E)
    {
        Console.WriteLine("e");
        Console.Beep(allOctave[3], 50);
    }
    else if (note.Key == ConsoleKey.D)
    {
        Console.WriteLine("d");
        Console.Beep(allOctave[4], 50);
    }
    else if (note.Key == ConsoleKey.F)
    {
        Console.WriteLine("f");
        Console.Beep(allOctave[5], 50);
    }
    else if (note.Key == ConsoleKey.T)
    {
        Console.WriteLine("t");
        Console.Beep(allOctave[6], 50);
    }
    else if (note.Key == ConsoleKey.G)
    {
        Console.WriteLine("g");
        Console.Beep(allOctave[7], 50);
    }
    else if (note.Key == ConsoleKey.Y)
    {
        Console.WriteLine("y");
        Console.Beep(allOctave[8], 50);
    }
    else if (note.Key == ConsoleKey.H)
    {
        Console.WriteLine("h");
        Console.Beep(allOctave[9], 50);
    }
    else if (note.Key == ConsoleKey.U)
    {
        Console.WriteLine("u");
        Console.Beep(allOctave[10], 50);
    }
    else if (note.Key == ConsoleKey.J)
    {
        Console.WriteLine("j");
        Console.Beep(allOctave[11], 50);
    }
}

while (cicle == true)
{
    ConsoleKeyInfo note = Console.ReadKey();
    Octave(note, allOctave, firstOctave, secondOctave, thirdOctave, fourthOctave);
}