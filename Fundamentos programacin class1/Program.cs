#region Actividades 

//banderas();
//intento1();
//intento2();
imprimiratrbutos1(); 

#endregion

#region resuelto
void banderas () {
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write("RU");
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Write("S");
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write("IA");

    Console.WriteLine();

    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write("P");
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("ER");
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write("U");
    Console.ResetColor();
}


void intento1(){
    string separador = "----------------------";
    string nombre = "<Nombre del jugador>";
    int level = 15;
    float exp = 13;

    Console.WriteLine($"nombre: {nombre}" );
    Console.WriteLine($"level: {level}");
    Console.WriteLine($"exp: {exp}");
    Console.WriteLine(separador);
}




void intento2(){
    string separador = "----------------------";
    string nombrenew = "Nombre del jugador";
    int levelNew = 17;    
    long expNew = 8_439_581_839;
    sbyte pociones = 6;
    string arma = "espada sagrada";
    Console.WriteLine($"nombre: {nombrenew}");
    Console.WriteLine($"level: {levelNew}");
    Console.WriteLine($"exp: {expNew}");
    Console.WriteLine($"pociones: {pociones}");
    Console.WriteLine($"arma: {arma}");
    Console.WriteLine(separador);
}

void imprimiratrbutos1(){
    string separador = "----------------------";
    string nombrenew = "Nombre del jugador";
    int levelNew = 17;    
    long expNew = 8_439_581_839;
    sbyte pociones = 6;
    string arma = "espada sagrada";
    int hp = 100;
    int mp = 50;
    int oro = 4712;

    Console.WriteLine("STARFIRE");
    Console.WriteLine(separador);
    Console.WriteLine($"nombre:\t{nombrenew}");
    Console.WriteLine($"HP:\t{hp}");
    Console.WriteLine($"MP:\t{mp}");
    Console.WriteLine($"oro:\t{oro}");
    Console.WriteLine($"exp:\t{expNew}");
    Console.WriteLine(separador);
}
#endregion 