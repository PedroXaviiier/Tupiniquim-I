namespace Robotico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, roboY = 0, roboX = 0;
            int numerorobo = 0;
            string roboDirec = " ";
            string roboComando = " ";
            string resposta;



            Console.WriteLine("Informe as dimensões do mapa: (ex: 5 5) ");
            string[] mapa = Console.ReadLine().ToLower().Split();

            x = Convert.ToInt32(mapa[0]);
            y = Convert.ToInt32(mapa[1]);


            do
            {
                numerorobo++;

                Console.WriteLine("Informe as coordenadas iniciais e a direção para Tupiniquim " + numerorobo + ": (ex: 5 5 N)");
                string[] xyd = Console.ReadLine().Split();
                roboX = Convert.ToInt32(xyd[0]);
                roboY = Convert.ToInt32(xyd[1]);
                roboDirec = xyd[2].ToLower();

                while (roboX > x || roboY > y)
                {
                    Console.WriteLine("Coordernadas invalidas informe novas coordenadas iniciais e a direção para Tupiniquim " + numerorobo + ": (ex: 5 5 N)");
                    xyd = Console.ReadLine().Split();
                    roboX = Convert.ToInt32(xyd[0]);
                    roboY = Convert.ToInt32(xyd[1]);
                    roboDirec = xyd[2].ToLower();
                }




                Console.WriteLine("Informe o comando: ex(E= esquerda, D= direita M= mover, EEMMDDM)");
                roboComando = Console.ReadLine().ToLower();

                foreach (char letra in roboComando)
                {
                    switch (letra)
                    {
                        case 'd': //direita
                            switch (roboDirec)
                            {
                                case "s":
                                    roboDirec = "o";
                                    break;

                                case "n":
                                    roboDirec = "l";
                                    break;

                                case "o":
                                    roboDirec = "n";
                                    break;

                                case "l":
                                    roboDirec = "s";
                                    break;
                            }
                            break;


                        case 'e': //esquerda
                            switch (roboDirec)
                            {
                                case "s":
                                    roboDirec = "l";
                                    break;

                                case "n":
                                    roboDirec = "o";
                                    break;

                                case "o":
                                    roboDirec = "s";
                                    break;

                                case "l":
                                    roboDirec = "n";
                                    break;
                            }
                            break;


                        case 'm':     //mover
                            switch (roboDirec)
                            {
                                case "s":
                                    roboY--;
                                    break;

                                case "n":
                                    roboY++;
                                    break;

                                case "o":
                                    roboX--;
                                    break;

                                case "l":
                                    roboX++;
                                    break;
                            }
                            break;
                    }
                }

                if (x < roboX || y < roboY || roboY < 0 || roboX < 0)
                    Console.WriteLine($"Tupiquiniquim??? TUPINIQUIM!!!!!!!!! Game over, tupiniquim {numerorobo} se perdeu\n");


                else
                    Console.WriteLine($"Tupiniquim {numerorobo} parou nas coordenadas: X: {roboX}, Y: {roboY}, Direção: {roboDirec.ToUpper()}\n");

                Console.WriteLine(" Deseja enviar outro Robo? S/N ");
                resposta = Console.ReadLine().ToLower();

                while (resposta != "n" || resposta != "s" || resposta != "N" || resposta != "S")
                    Console.WriteLine("Resposta invalida, Deseja enviar outro Robo? S/N ");
                resposta = Console.ReadLine().ToLower();

            }
            while (resposta != "n");
        }
    }
    }

