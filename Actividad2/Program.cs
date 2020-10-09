using System;
using System.Threading.Tasks.Dataflow;

namespace Actividad2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
           
            Console.Write("1º) Leer un número por teclado y definir si es par o impar " + "\n" + 
                          "2º) Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10 " + "\n" +
                          "3º) Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10 " + "\n" +
                          "4º) Leer un número por teclado y definir si es primo o no" + "\n"+ 
                          "5º) Ordenar vectores de edad de forma ascendente" + "\n" + 
                          "6º) Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad " + "\n" +
                          "7º) Con los vectores previos buscar el menor y el mayor y presentar sus respectivos nombres con su edad." + "\n" +
                          "8º) Dado una palabra definir si es palíndromo o no." + "\n"+ 
                          "9º) Salir"+"\n");
            Console.Write("Seleccione una opción: ");
            
            switch (Console.Read())
               
            {
                case '1':
                    Console.Write("Seleccione una opción: " );
                    Console.Clear();
                    Console.Write("....................PAR O IMPAR...................."+"\n");
                    string numero;
                    int s;
                    Console.WriteLine("Introduzca un numero entero: ");
                    Console.ReadLine();
                    numero = Console.ReadLine();
                    s = Convert.ToInt32(numero);
                    if (s % 2 == 0)
                    {
                        Console.WriteLine("El numero " + s + " es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + s + " es impar");
                    }
                    Console.ReadKey();
                    Console.WriteLine("\n");
                    break;
                case '2':
                    Console.Clear();
                    Console.Write("..........TABLAS DE MULTIPLICAR DE UN NUMERO ESPECIFICO.........."+"\n");
                    Console.WriteLine("Usuario, digita un numero entero para mostrate su tabla de multiplicar");
                    string n;
                    Console.ReadLine();
                    n= Console.ReadLine();
                    int num, j;
                    num = Convert.ToInt32(n);
                    for (j = 1; j <= 10; j++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", num, j, (num * j));
                    }
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    break;
                case '3':
                    Console.Clear();
                    Console.Write("................TODAS LAS TABLAS DEL 2 AL 9................."+"\n");
                    for (int ni = 2; ni < 10; ni++)
                    {
                        Console.WriteLine("\nTabla de multiplicar del {0}", ni);
                        Console.WriteLine("------------------------------");
                        for (int nj = 1; nj <= 10; nj++)
                        {
                            Console.WriteLine("{0} * {1} = {2}", ni, nj, (ni * nj));
                        }
                        Console.WriteLine("\n");
                        Console.ReadKey();
                    }
                    break;
                case '4':
                    Console.Clear();
                    Console.Write("....................NUMEROS PRIMOS O NO PRIMOS...................." +"\n");
                    int a = 0; 
                    Console.WriteLine("Digita el numero del que deses saber si es primo o no");
                    Console.ReadLine();
                    num = Convert.ToInt32(Console.ReadLine());
                    for (int mi = 1; mi < (num + 1); mi++)
                    {
                        if (num % mi == 0)
                        {
                            a++;
                        }
                    }
                    if (a != 2)
                    {
                        Console.WriteLine("El numero "+num + " NO es primo");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num + " SI es primo");
                    }
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    break;
                    
                case '5':
                    Console.Clear();
                    Console.Write(".................ORDENAR EDADES DE FORMA ASCENDENTE................."+"\n");
                    {
                        int[] array2 = new int[10];
                        Console.WriteLine("Entra los diez numeros a ordenar");
                        Console.WriteLine("Algunos numeros que te pueden servir son: 12,50,23,10,18,35,41,85,16,45");
                        Console.ReadLine();
                        for (int x = 0; x < 10; x++)
                        {
                            
                            
                            array2[x] = Convert.ToInt32(Console.ReadLine());
                           
                        }
                        ordena(array2);
                    }

                    static void ordena(int[] array2)
                    {
                        Array.Sort(array2);
                        Console.WriteLine("los diez numeros ordenados son:");

                        for (int x = 0; x < 10; x++)
                        {
                            Console.WriteLine(array2[x]);
                        }
                        Console.WriteLine("\n");
                        Console.ReadLine();
                    }
                    break;
                case '6':
                    Console.Clear();
                    Console.Write("..................LEER UN NOMBRE Y MOSTAR SU EDAD.................."+"\n");
                    Console.WriteLine("Digita el nombre de la persona de la que desseas conocer su edad");
                    string nombre;
                    Console.ReadLine();
                    nombre = Console.ReadLine();
                    if (nombre == "Juan" || nombre == "juan")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 12);
                    }
                    else if (nombre == "Maria" || nombre == "maria")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 50);
                    }
                    else if (nombre == "Tereza" || nombre == "tereza")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 23);
                    }
                    else if (nombre == "Pedro" || nombre == "pedro")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 10);
                    }
                    else if (nombre == "Javier" || nombre == "javier")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 18);
                    }
                    else if (nombre == "Ana" || nombre == "ana")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 35);
                    }
                    else if (nombre == "Diana" || nombre == "diana")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 41);
                    }
                    else if (nombre == "Jorge" || nombre == "jorge")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 85);
                    }
                    else if (nombre == "Dayana" || nombre == "dayana")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 16);
                    }
                    else if (nombre == "Lady" || nombre == "lady")
                    {
                        Console.WriteLine("La edad de " + nombre + " es " + 45);
                    }
                    else
                    {
                        Console.WriteLine("El nombre que usted digito no existe por lo tanto no le puedo informar su edad ");
                    }
                    Console.ReadKey();
                    break;
                case '7':
                    Console.Clear();
                    Console.Write(".................BUSCAR Y MOSTRAR LA MAYOR Y LA MENOR EDAD................."+"\n");

                    string nombrebuscar;
                    bool existe = false;
                    int indice = 0;
                    int indicemayor = 0;
                    int edadmayor = 0;
                    int indicemenor = 0;
                    int edadmenor = 0;
                    //Console.WriteLine("Buscar usuario y mostar su edad");
                    int[] edad_e = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    string[] nombres = { "juan", "maria", "teresa", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                    Console.WriteLine("**** muestra el array del nombre ****");
                    foreach (string nombre_n in nombres) ;
                    {
                        Console.WriteLine(nombres + " | ");
                    }
                    Console.Write("\n");
                    Console.WriteLine("Digite el nombre a buscar");
                    Console.ReadLine();
                    nombrebuscar = Console.ReadLine();
                    Console.WriteLine("los usurios mayor y menor son:");
                    Console.ReadKey();
                    for (int ei = 0; ei < nombres.Length; ei++)
                    {
                        if (nombrebuscar == nombres[ei])
                        {
                            existe = true;
                            indice = ei;
                        }
                        for (int ej = 0; ej < edad_e.Length; ej++)
                        {
                            if (edad_e[ej] > edadmayor)
                            {
                                edadmayor = edad_e[ej];
                                indicemayor = ej;
                            }
                        }

                        for (int ej = 0; ej < edad_e.Length; ej++)
                        {
                            if (edad_e[ej] < edadmenor)
                            {
                                edadmenor = edad_e[ej];
                                indicemenor = ej;
                            }
                        }
                      
                    }; 

                    Console.WriteLine("El usuario mayor es " + nombres[indicemayor] + " y su edad es " + edad_e[indicemayor]);
                    Console.WriteLine("El usuario menor es " + nombres[indicemenor] + " y su edad es " + edad_e[indicemenor]);
                    if (existe)
                    {
                        Console.WriteLine("La edad de " + nombrebuscar + " es " + edad_e[indice]);
                    }
                    else
                        Console.WriteLine("El usuario " + nombrebuscar + " no existe");

                    Console.ReadKey();
                    break;
                case '8':
                    Console.Clear();
                    Console.Write("................DEFINIR SI UNA PALABRA ES PALINDROMO O NO................."+"\n");
                    string str = string.Empty;
                    Console.WriteLine("Usuario, introduce una palabra y te dire si es palindromo o no ");
                    Console.ReadLine();
                    string ns = Console.ReadLine();
                    int i = ns.Length;
                    for (int lj = i - 1; lj >= 0; lj--)
                    {
                        str = str + ns[lj];
                    }
                    if (str == ns)
                    {
                        Console.WriteLine("Tu palabra " + ns + " si  es palindromo");
                    }
                    else
                    {
                        Console.WriteLine("Tu palabra " + ns + " no  es palindromo");
                    }
                    Console.WriteLine("Ya que invertida queda asi: " + str);
                    Console.Read();
                    break;
                case '9':
                     Console.Clear();
                    Console.Write(".........................SALIR.........................");
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
