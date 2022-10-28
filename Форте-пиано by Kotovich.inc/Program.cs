int[] octave4 = new int[] { 2093, 2349, 2637, 2793, 3135, 3520, 3951, 4186, 2217, 2489, 2959, 3322, 3729 };
int[] octave3 = new int[] { 1046, 1174, 1318, 1396, 1568, 1760, 1975, 2093, 1244, 1480, 1661, 1864, 2093 };
int[] octave2 = new int[] { 523, 587, 659, 698, 783, 880, 987, 1046, 622, 739, 830, 932, 1046 };
int[] octave5 = new int[] { 4186, 4698, 5274, 5587, 6271, 7040, 7902, 4434, 4978, 5919, 6644, 7458, 8372 };
int[] selectedOctave = octave2;
while (true)
{

    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine(key.Key);
    if (key.Key == ConsoleKey.Q) // До
    {
        Console.Beep(selectedOctave[0], 300);

    }
    if (key.Key == ConsoleKey.W) // Ре
    {
        Console.Beep(selectedOctave[1], 300);
    }

    if (key.Key == ConsoleKey.E) // Ми
    {
        Console.Beep(selectedOctave[2], 300);
    }
    if (key.Key == ConsoleKey.R) // Фа
    {
        Console.Beep(selectedOctave[3], 300);
    }
    if (key.Key == ConsoleKey.T) // Соль
    {
        Console.Beep(selectedOctave[4], 300);
    }
    if (key.Key == ConsoleKey.Y) // Ля
    {
        Console.Beep(selectedOctave[5], 300);
    }
    if (key.Key == ConsoleKey.U) // Си
    {
        Console.Beep(selectedOctave[6], 300);
    }
    if (key.Key == ConsoleKey.I) // До
    {
        Console.Beep(selectedOctave[7], 300);
    }
    if (key.Key == ConsoleKey.D1) // До# и Ре бемоль
    {
        Console.Beep(selectedOctave[8], 300);
    }
    if (key.Key == ConsoleKey.D2) // Ре# и Ми Бемоль
    {
        Console.Beep(selectedOctave[9], 300);
    }
    if (key.Key == ConsoleKey.D3) // Фа# и Соль Бемоль
    {
        Console.Beep(selectedOctave[10], 300);
    }
    if (key.Key == ConsoleKey.D4) //Соль# и Ля Бемоль
    {
        Console.Beep(selectedOctave[11], 300);
    }
    if (key.Key == ConsoleKey.D5) //Ля# и Си бемоль
    {
        Console.Beep(selectedOctave[12], 300);
    }
    if (key.Key == ConsoleKey.F1)
    {
        selectedOctave = octave2;
    }
    if (key.Key == ConsoleKey.F2)
    {
        selectedOctave = octave3;
    }
    if (key.Key == ConsoleKey.F3)
    {
        selectedOctave = octave4;
    }
    if (key.Key == ConsoleKey.F4)
    {
        selectedOctave = octave5;
    }
    if (key.Key == ConsoleKey.F12)
    {
        selectedOctave = octave5;
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
    }
    

}











