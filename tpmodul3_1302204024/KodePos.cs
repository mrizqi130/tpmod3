using System;

namespace tpmodul3_1302204024
{
	//belajar passbyvalue passbyref
	public class KodePos
	{
		//string b = "rara"; //jika tidak menggunakan public sbg modifier maka b mjd var global pada class ini saja
		public string b = "ini class KodePos";
        //not all code paths return value -> ketika return value tidak diset pada func
        enum State
        {
            START, GAME, PAUSE, EXIT,
            Batununggal, Kujangsari, Mengger, Wates,
            Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
            Maleer, Samoja
        };
        //Batununggal
        //Kujangsari
        //Mengger
        //Wates
        //Cijaura
        //Jatisari
        //Margasari
        //Sekejati
        //Kebonwaru
        //Maleer
        //Samoja
        public void getKodePos()
        {

            State state = State.START;
            State kel = State.START;
            string[] screenName = { "START", "GAME", "PAUSE", "EXIT", "40266",
                "40287", "40267", "40256", "40287", "40286", "40286", "40286",
                "40272", "40274", "40273"

            };

            while (state != State.EXIT)
            {
                //Console.WriteLine(screenName[(int)state] + " SCREEN");
                Console.WriteLine("Ketikkan kelurahan untuk menampilkan kode pos");
                Console.Write("Kelurahan : ");
                //KONSTRUKSI PERANGKAT LUNAK 17

                //string command = Console.ReadLine();
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.START:
                        if (command == "ENTER")
                        {
                            state = State.GAME;
                        }
                        else if (command == "QUIT")
                        {
                            state = State.EXIT;
                        }
                        else if (command == "Batununggal")
                        {
                            //Console.Write("INI BATUNUNGGAL");
                            kel = State.Batununggal;
                        }
                        else if (command == "Kujangsari")
                        {
                            kel = State.Kujangsari;
                        }
                        else if (command == "Mengger")
                        {
                            kel = State.Mengger;
                        }
                        else if (command == "Wates")
                        {
                            kel = State.Wates;
                        }
                        else if (command == "Cijaura")
                        {
                            kel = State.Cijaura;
                        }
                        else if (command == "Jatisari")
                        {
                            kel = State.Jatisari;
                        }
                        else if (command == "Margasari")
                        {
                            kel = State.Margasari;
                        }
                        else if (command == "Sekejati")
                        {
                            kel = State.Sekejati;
                        }
                        else if (command == "Kebonwaru")
                        {
                            kel = State.Kebonwaru;
                        }
                        else if (command == "Maleer")
                        {
                            kel = State.Maleer;
                        }
                        else if (command == "Samoja")
                        {
                            kel = State.Samoja;
                        }
                        else
                        {
                            state = State.START;
                            command = "QUIT";
                            
                        }
                        break;
                        //case State.Batununggal:
                        //    if (command == "ESC")
                        //        state = State.PAUSE;
                        //    else
                        //        state = State.GAME;
                        //    break;
                        //case State.GAME:
                        //    if (command == "ESC")
                        //        state = State.PAUSE;
                        //    else
                        //        state = State.GAME;
                        //    break;
                        //case State.PAUSE:
                        //    if (command == "BACK")
                        //        state = State.GAME;
                        //    else if (command == "HOME")
                        //        state = State.START;
                        //    else if (command == "QUIT")
                        //        state = State.EXIT;
                        //    else
                        //        state = State.PAUSE;
                        //    break;
                }
                if (command != "QUIT")
                    //a = screenName[(int)kel];
                    Console.WriteLine("Kode Pos " + command + " : " + screenName[(int)kel]);
                //Console.WriteLine("yes1" + command);
            }
            Console.WriteLine("EXIT SCREEN");
        }
    }
}