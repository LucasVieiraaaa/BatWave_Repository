using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Media;
using System.Text;
class URI
{
    private static StreamReader sr = new StreamReader("c:\\BatWave_Repository\\SysPass.txt");
    public static void getArq()
    {
        StreamWriter s1 = new StreamWriter("c:\\BatWave_Repository\\SysPass.txt", true, Encoding.ASCII);

        StreamWriter s2 = new StreamWriter("c:\\BatWave_Repository\\SysurName.txt", true, Encoding.ASCII);

        StreamWriter s3 = new StreamWriter("c:\\BatWave_Repository\\SysColor.txt", true, Encoding.ASCII);

        StreamWriter s4 = new StreamWriter("c:\\BatWave_Repository\\SysName.txt", true, Encoding.ASCII);

        FileInfo sr1 = new FileInfo("c:\\BatWave_Repository\\SysPass.txt");

        if (sr1.Length == 0)
        {
            Console.WriteLine("Você ainda não tem uma senha definida, use a senha default: 123");
            s1.WriteLine("123");
        }
        FileInfo sr2 = new FileInfo("c:\\BatWave_Repository\\SysName.txt");
        if (sr2.Length == 0)
        {
            s4.WriteLine("Batwave");
        }
        FileInfo sr3 = new FileInfo("c:\\BatWave_Repository\\SysColor.txt");
        {
            s3.WriteLine("white");
        }
        FileInfo sr4 = new FileInfo("c:\\BatWave_Repository\\SysurName.txt");
        if (sr4.Length == 0)
        {
            s2.WriteLine("Guest");
        }
        s1.Close();
        s2.Close();
        s3.Close();
        s4.Close();
    }
    public static void getCacula()
    {
        try {
            string[] values;
            string input = "", command = "0";
            double z = 0, x = 0;
            Console.WriteLine("\n\t\t\t\tCalculadora");
            Console.WriteLine("Comandos:    1-Soma: 2 + 2 = 4\t\t2- Subtração: 2 - 2 = 0\t\t3-Multiplicação: 2 * 2 = 4\n\t     4-Divisão 2 D 2 = 1\t5-Resto: 2 % 2 = 0\t\t6-Raiz quadrada: R 9 0 = 3" +
                "\n\t     7-Desligamento: Off 0 0\t8-Apaga: ACC 0 0\t        9-Expoente: 2 o 2 = 4\n");
            while (1 == 1)
            {
                Console.WriteLine($"\t\t\t\t\t __________________________________________"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|\t\t\t\t\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|\t\t\t\t\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|   ____________________________________   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|  |{z}\t\t\t\t\t|  |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|  |____________________________________|  |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|\t\t\t\t\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|  ______________________________________  |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |        |         |         |\t | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| | OFF/0  |   V/R   |   %/P   |   ÷/D\t | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |________|_________|_________|_________| |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |        |         |         |  \t | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |   7    |    8    |    9    |    X    | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |________|_________|_________|_________| |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |        |         |         |         | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |   4    |    5    |    6    |    _    | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |________|_________|_________|_________| |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |        |\t     |         |\t | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |   1    |   2     |    3    |    +\t | |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |________|_________|_________|_________| |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |        |\t     |         |\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |    0   |\t°    |   ACC   |\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t| |________|_________|_________|\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|\t\t\t\t\t   |"); Thread.Sleep(40);
                Console.WriteLine($"\t\t\t\t\t|__________________________________________|");
                input = Console.ReadLine();
                if (input.Length < 3 || input.Length > 80)
                    Console.WriteLine("Isso não é uma operação válida");
                else
                {
                    values = input.Split(' ');
                    if (values[0].Contains('0') || values[0].Contains('1') || values[0].Contains('2')
                        || values[0].Contains('3') || values[0].Contains('4') || values[0].Contains('5')
                        || values[0].Contains('6') || values[0].Contains('7') || values[0].Contains('8')
                        || values[0].Contains('9'))

                        z = Convert.ToDouble(values[0]);

                    else if (values[0].ToLower() == "r")
                    {
                        z = Convert.ToDouble(values[1]);
                        x = 0;
                        z = Math.Sqrt(z);
                        Console.Write($"Raiz Quadrada: {z}");
                    }
                    else if (values[0].ToLower() == "acc")
                    {
                        z = 0;
                        x = 0;
                    }
                    else if (values[0].ToLower() == "off")
                        break;
                    else
                        Console.WriteLine("O primeiro não é um número, logo o segundo sera utilizado com o anterior");


                    if (command is string)
                        command = values[1];
                    else
                        Console.WriteLine("Sinal inválido");


                    if (values[2].Contains('0') || values[2].Contains('1') || values[2].Contains('2') ||
                        values[2].Contains('3') || values[2].Contains('4') || values[2].Contains('5') ||
                        values[2].Contains('6') || values[2].Contains('7') || values[2].Contains('8') ||
                        values[2].Contains('9'))
                        x = Convert.ToDouble(values[2]);

                    else
                        Console.WriteLine("Você não pode fazer isso");

                    if (command == "+")
                        z += x;
                    else if (command == "-")
                        z -= x;
                    else if (command.ToLower() == "x")
                        z *= x;
                    else if (command.ToLower() == "d" || command == "÷")
                        z /= x;
                    else if (command == "%" || command.ToLower() == "p")
                        z %= x;
                    else if (command == "°" || command.ToLower() == "o")
                        z = Math.Pow(z, x);
                }
            }
        }
        catch
        {
            Console.WriteLine();
        }
    }
    public static void getPPT()
    {
        int a = 0, b = 0;
        Console.WriteLine("\t\t\t\t\t\tMelhor de 3,Vamos lá!!");
        Console.WriteLine("\t\t\t\t\t\t-Pedra -Papel -Tesoura");
        for (int l = 0; l < 3; l++)
        {

            string bot = string.Empty;
            Random r = new Random();
            int i = r.Next(1, 3);
            if (i == 1)
            {
                bot = "Pedra";
            }
            else if (i == 2)
            {
                bot = "Papel";
            }
            else if (i == 3)
            {
                bot = "Tesoura";
            }

            string x = Console.ReadLine();
            string xx = char.ToUpper(x[0]) + x.Substring(1);
            Console.WriteLine($"\t\t\t\t\t        (  {xx} VS {bot}  )");
            Thread.Sleep(100);

            if (x.ToLower() == "pedra" && bot == "Pedra")
            {
                Console.WriteLine("\t\t\t\t\t\tEmpate");
            }

            else if (x.ToLower() == "pedra" && bot == "Papel")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Perdeu");
                b++;
            }
            else if (x.ToLower() == "pedra" && bot == "Tesoura")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Ganhou!!");
                a++;
            }
            else if (x.ToLower() == "papel" && bot == "Pedra")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Ganhou!!");
                a++;
            }

            else if (x.ToLower() == "papel" && bot == "Papel")
            {
                Console.WriteLine("\t\t\t\t\t\tEmpate");
            }

            else if (x.ToLower() == "papel" && bot == "Tesoura")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Perdeu");
                b++;
            }
            else if (x.ToLower() == "tesoura" && bot == "Pedra")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Perdeu");
                b++;
            }

            else if (x.ToLower() == "tesoura" && bot == "Papel")
            {
                Console.WriteLine("\t\t\t\t\t\tVocê Ganhou!!");
                a++;
            }

            else if (x.ToLower() == "tesoura" && bot == "Tesoura")
            {
                Console.WriteLine("\t\t\t\t\t\tEmpate");
            }
            else
            {
                Console.WriteLine($"\t\t\t\t\t\t{x} não é válido");
                l--;
            }
        }
        Console.WriteLine("\t\t\t\t Placar:\n" +
              "\t\t\t\t\t ________________________________________\n" +
          $"\t\t\t\t\t|                                        |\n" +
          $"\t\t\t\t\t           {geturName()}: {a}  {getSystemName()}: {b}              \n" +
          $"\t\t\t\t\t|________________________________________|\n");
    }
    public static void getRoleta()
    {
        string repeat = "";
        string x = "", l = "";
        int y = 0, z = 0;
        Random r = new Random();//25% de chance cada individuo
            y = r.Next(1, 40);
            if (y >= 1 && y <= 10) x = "Caio";
            if (y > 10 && y <= 20) x = "Dola";
            if (y > 20 && y <= 30) x = "ChaoLin";
            if (y > 30 && y <= 40) x = "Luketa";
            z = r.Next(0, 40);
            if (z >= 0 && z <= 10) l = "O Viadinho";
            if (z > 10 && z <= 20) l = "A Boneca";
            if (z > 20 && z <= 30) l = "O Devorador";
            if (z > 30 && z <= 40) l = "O Mano";
        repeat = x;
        if (repeat == x)
        {
            y = r.Next(1, 40);
            if (y >= 1 && y <= 10) x = "Luketa";
            if (y > 10 && y <= 20) x = "Chaolin";
            if (y > 20 && y <= 30) x = "Dola";
            if (y > 30 && y <= 40) x = "Caio";
        }

            for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(600);
            Console.WriteLine("\t\t\t\t\t\tRoletando...");
        }
        for (int i = 0; i < 2; i++)
        {
            Thread.Sleep(800);
            Console.WriteLine("\t\t\t\t\t\tÉ OFICIAL!!!");
        }
        Thread.Sleep(600);
        Console.WriteLine($"\n\t\t\t\t\t\t{l} {x} foi sorteado\n");
        Thread.Sleep(1500);
    }
    public static void getAge()
    {
        var created = new DateTime(2023, 11, 3, 5, 10, 23);
        Console.WriteLine("\t\t\t\t\t\tO momento exato que fui criado: " + created + "\n");
    }
    public static void getDate()
    {
        string line = "", d, m, a; string[] values;
        char[] c = { ' ', '/', ':' };
        int dias = 0;
        var data = DateTime.Now;
        line = data.ToString();
        values = line.Split(c);

        d = values[0];
        m = values[1];
        a = values[2];

        dias = (Convert.ToInt32(m) * 30) - 26;
        dias = Convert.ToInt32(d) + dias;
        dias = (dias - 365) * -1;
        Console.WriteLine($"\t\t\t\t\t\t Faltam {dias} dias pro ano de {a} acabar...\n");
    }
    public static void getBirthday()
    {
        string line = "", d, m, a; string[] values;
        char[] c = { ' ', '/', ':' };
        int idade = 0;
        var data = DateTime.Now;
        line = data.ToString();
        values = line.Split(c);

        d = values[0];
        m = values[1];
        a = values[2];
        Console.WriteLine($"\t\t\t\t\t\t Dia: {d}  Mês: {m} Ano: {a}");
        if (d.Equals("18") && m.Equals("12"))
        {
            idade = (2004 - Convert.ToInt32(a)) * -1;
            Console.WriteLine($"\t\t\t\t\t\t Feliz Aniversário de {idade} anos Luketa,Obrigado por me criar!!");
        }
    }
    public static string putTime()
    {
        string[] values = new string[3];
        var data = DateTime.Now;
        string line = data.ToString();
        line = line.Substring(11);
        values = line.Split(":");
        return $"{values[0]}:{values[1]}";
    }
    public static string getTime()
    {
        string[] values = new string[3];
        var data = DateTime.Now;
        string line = data.ToString();
        line = line.Substring(11);
        values = line.Split(":");
        //Console.WriteLine($"{values[0]}:{values[1]}:{values[2]}");

        if (Convert.ToInt32(values[0]) >= 12 && Convert.ToInt32(values[0]) < 18)
            return "Boa Tarde";
        if (Convert.ToInt32(values[0]) >= 18 && Convert.ToInt32(values[0]) <= 23)
            return "Boa Noite";
        if (Convert.ToInt32(values[0]) >= 6 && Convert.ToInt32(values[0]) < 12)
            return "Bom Dia";
        else
            return "Boa Madrugada";
    }
    public static string getSystemName()
    {
        string name = "";
        StreamReader sr = new StreamReader("c:\\BatWave_Repository\\SysName.txt");
        name = sr.ReadLine();
        sr.Close();
        return name;
    }
    public static void Logo()
    {
        Console.WriteLine($"               ...............................                                ................................");
        Thread.Sleep(30);
        Console.WriteLine($"                 .                         .                                   .                          .");
        Thread.Sleep(30);
        Console.WriteLine($"\t\t  .\t\t\t    .           |\\        /|          .                         .");
        Thread.Sleep(30);
        Console.WriteLine($"   \t\t    ..\t\t\t     ...        | \\....../ |       ...                       ..");
        Thread.Sleep(30);
        Console.WriteLine($"\t             .    \t\t      .....     |          |     ....                        .");
        Thread.Sleep(30);
        Console.WriteLine($"                     .                            ......            ......                            .");
        Thread.Sleep(30);
        Console.WriteLine($"                   ..\t\t\t\t\t\t\t\t\t\t      ..");
        Thread.Sleep(30);
        Console.WriteLine($"                  .\t\t\t\t\t\t\t\t\t\t        .");
        Thread.Sleep(30);
        Console.WriteLine($"                ............\t\t\t\t\t\t\t\t      ............");
        Thread.Sleep(30);
        Console.WriteLine($"                           ...........\t\t\t\t\t\t    ...........");
        Thread.Sleep(30);
        Console.WriteLine($"                                      ...     \t\t\t\t\t  ...");
        Thread.Sleep(30);
        Console.WriteLine($"                                         ....... \t\t             .......");
        Thread.Sleep(30);
        Console.WriteLine($"                                                ......                  ......");
        Thread.Sleep(30);
        Console.WriteLine($" \t\t\t\t\t \t       ...          ...");
        Thread.Sleep(30);
        Console.WriteLine($" \t\t\t\t\t\t\t  ...     ...");
        Thread.Sleep(30);
        Console.WriteLine($" \t\t\t\t\t\t\t     ..  ..");
        Thread.Sleep(30);
        Console.WriteLine($"\t\t\t\t\t\t\t       \\/");
        Thread.Sleep(30);
    }
    public static void setSystemName()
    {
        string name = "";
        StreamWriter sw = new StreamWriter("c:\\BatWave_Repository\\SysName.txt", false, Encoding.ASCII);
        name = Console.ReadLine();
        sw.WriteLine(name);
        sw.Close();
    }
    public static void setSenha()
    {
        int x = 0;
        do
        {
            string g = string.Empty;
            StreamWriter s = new StreamWriter("c:\\BatWave_Repository\\SysPass.txt");
            Console.WriteLine("\t\tDigite a sua nova senha abaixo: ");
            g = Console.ReadLine();
            if (g.Length < 4)
            {
                Console.WriteLine("\t\tSua senha precisa ter mais de 4 caracteres");
            }
            else
            {
                s.WriteLine(g);
                s.Close();
                Console.WriteLine("\t\tSenha atualizada com sucesso!\n");
                x = 1;
            }
            s.Close();
        } while (x == 0);
    }
    public static int putSenha()
    {
        string p = "", password = "";
        p = sr.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            if (i == 4)
            {
                Console.WriteLine("Você possui apenas mais uma tentativa");
                Thread.Sleep(1700);
            }

            Console.Write("Digite a Senha: ");
            password = Console.ReadLine();

            if (password == p)
            {
                Console.WriteLine("\nACESSO CONCEDIDO");
                i += 5;
                sr.Close();
                return 1;
            }
            else
                Console.WriteLine("Acesso Negado");
        }
        sr.Close();
        return 0;
    }
    public static void setLimpaCacha()
    {
        string pasta = "c:\\Windows\\Temp";
        var dir = new DirectoryInfo(pasta);
        Console.WriteLine("\n\t\t\t\t\t\tLimpando Memória Cache...");    
        foreach (FileInfo a in dir.GetFiles())
            a.Delete();
        Thread.Sleep(2000);
    }
    public static ConsoleColor SetFontColor()
    {
        StreamWriter s = new StreamWriter("c:\\BatWave_Repository\\SysColor.txt", false, Encoding.ASCII);
        string input = "";
        Console.WriteLine("\t\t\t\t\tEscolha a cor que deseja: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write($"\t  1-Verde Escuro\t\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"2-Verde \t\t");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"3-Amarelo Escuro \t\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"4-Amarelo \t\t\t\n");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"\t  5-Vermelho escuro \t\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"6-Vermelho  \t\t");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write($"7-Roxo Escuro   \t\t");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"8-Roxo   \t\t\n\n");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"\t  9-Azul Escuro   \t\t");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"10-Azul   \t\t");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"11-Ciano Escuro   \t\t");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"12-Ciano  \t\t\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"\t  13-Branco  \t\t\n");
        input = Console.ReadLine();
        Console.Write($"\n");


        if (input == "1")
        {
            s.WriteLine("dg");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (input == "2")
        {
            s.WriteLine("green");
            s.Close();
            return Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (input == "3")
        {
            s.WriteLine("dy");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (input == "4")
        {
            s.WriteLine("yellow");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (input == "5")
        {
            s.WriteLine("dr");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        else if (input == "6")
        {
            s.WriteLine("red");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (input == "7")
        {
            s.WriteLine("dm");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else if (input == "8")
        {
            s.WriteLine("magenta");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (input == "9")
        {
            s.WriteLine("db");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else if (input == "10")
        {
            s.WriteLine("blue");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (input == "11")
        {
            s.WriteLine("dc");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        else if (input == "12")
        {
            s.WriteLine("cyan");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (input == "13")
        {
            s.WriteLine("white");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            s.WriteLine("white");
            s.Close();
            return Console.ForegroundColor = ConsoleColor.White;
        }

    }
    public static ConsoleColor getFontColor()
    {
        StreamReader s = new StreamReader("c:\\BatWave_Repository\\SysColor.txt");
        string input = "";
        input = s.ReadLine();
        if (input == "dg")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (input == "green")
        {
            s.Close();
            return Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (input == "dy")
        {
            s.Close(); 
            return Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (input == "yellow")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Yellow;

        }
        else if (input == "dr")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        else if (input == "red")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (input == "dm")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else if (input == "magenta")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (input == "db")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else if (input == "blue")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (input == "dc")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        else if (input == "cyan")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (input == "white")
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            s.Close();
            return Console.ForegroundColor = ConsoleColor.White;
        }

    }
    public static ConsoleColor getDefaultColor()
    {
        return Console.ForegroundColor = ConsoleColor.White;
    }
    public static void seturName()
    {
        Console.WriteLine("\t\tEscreva abaixo o nome que eu posso te chamar: ");
        string x = Console.ReadLine();
        StreamWriter s = new StreamWriter("c:\\BatWave_Repository\\SysurName.txt");
        s.WriteLine(x);    s.Close();
    }
    public static string geturName()
    {
        StreamReader st = new StreamReader("c:\\BatWave_Repository\\SysurName.txt");
        string x = st.ReadLine();  st.Close();
        return x;
    }

    static void Main()
        {
        //try
        {
            string Pasta = "c:\\BatWave_Repository";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
                Console.WriteLine("Made by Luketa_Studios");
                Thread.Sleep(900);
                Console.WriteLine("Sistema está sendo carregado...");
                Thread.Sleep(400);
            }

            StreamWriter sw5 = new StreamWriter("c:\\BatWave_Repository\\Verify.txt", false, Encoding.ASCII);
            FileInfo sr5 = new FileInfo("c:\\BatWave_Repository\\Verify.txt");
            if (sr5.Length == 0)
            {
                getArq();
                sw5.WriteLine("1");   sw5.Close();
            }
            else
                sw5.Close();

            getDefaultColor();
            string name = getSystemName(),urname = geturName();
            string first = "", version = "v0.08";

            if (putSenha() == 0)
                Console.WriteLine("Tente novamente mais tarde...");
            else
            {
                getFontColor();
                Console.Clear(); Console.WriteLine($"        {putTime()}\t\t\t\t\t    Sistema {name} {version}");

                Logo();
                getBirthday();

                Console.WriteLine($"\t\t\t\t\t\t {getTime()} {urname}, como posso ajudar?");
                do
                {
                    Console.WriteLine("\t\t _____________________________________________________________________________________________\n\t\t| 0-Desligar Sistema\t\t8-Mudar Cor\t\t\t\t\t\t      |\n\t\t| 1-Dias pro ano acabar\t\t9-Mudar seu Nome\t\t\t\t\t      |\n\t" +
                        "\t| 2-Manutenção \t\t\t10-Mudar Senha\t\t\t\t\t\t      |\n\t\t| 3-Dia que fui criado \t\t11-Pedra,Papel,Tesoura\t\t\t\t\t      |\n\t\t| 4-Roleta Devoradores\t\t\t\t\t\t\t\t\t      " +
                        "|\n\t\t| 5-Limpar Console\t\t\t\t\t\t\t\t\t      |\n\t\t| 6-Mudar meu nome\t\t\t\t\t\t\t\t\t      |\n\t\t" +
                        "| 7-Calculadora  \t\t\t\t\t\t\t\t\t      |\n\t\t-----------------------------------------------------------------------------------------------");
                    first = Console.ReadLine();
                    if (first.Length > 2)
                        Console.WriteLine($"\t\t\tNão é possivel digitar '{first}' pois não tem uma função, tente de novo: ");
                    if (first.Equals("0"))
                        break;
                    if (first.ToLower() == "l")
                        Logo();
                    if (first.Equals("1"))
                        getDate();
                    if (first.Equals("2"))
                        Console.Write("\t\t\t\t\t\t Manutenção...");
                    if (first.Equals("3"))
                        getAge();
                    if (first.Equals("4"))
                        getRoleta();
                    if (first.Equals("5"))
                        Console.Clear();
                    if (first.Equals("6"))
                        setSystemName();
                    if (first.Equals("7"))
                        getCacula();
                    if (first.Equals("8"))
                        SetFontColor();
                    if (first.Equals("9"))
                        seturName();
                    if(first.Equals("10"))
                        setSenha();
                    if (first.Equals("11"))
                        getPPT();
                    Console.WriteLine($"        {putTime()}\t\t\t\t\t    Sistema {name} {version}");
                } while (1 == 1);
                Console.WriteLine($"\nDesligando {name}...");
                if(getTime() == "Bom Dia")
                    Console.WriteLine($"Tchau tchau {urname} tenha um {getTime()} ");
                else
                Console.WriteLine($"Tchau tchau {urname} tenha uma {getTime()} ");
            }
        }
       // catch
        {
           // Console.WriteLine($"Ocorreu um Erro...{}");
        }
    }
}