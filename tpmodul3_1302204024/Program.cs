using System;

namespace tpmodul3_1302204024
{
    //intern
    //al class Program
    public class Program
    {
        //main harus pakai static
        public static void Main(string[] args)
        {
            KodePos kode = new KodePos(); //constructor yg mengembalikan keseluruhan class include attrib n method

            Console.WriteLine();
            kode.getKodePos();

            //string b = "Samaja";
            //Console.WriteLine("");
            //Console.WriteLine(kode.getKodePos(b));

            //Console.WriteLine("");
            //if (b == "1")
            //    Console.WriteLine("b");
            //else if (b == "2")
            //    Console.WriteLine(b);
            //Console.WriteLine(b);
            //else if (b == "3")
            //    Console.WriteLine(b);

            //String[] a = { "1", "2", "3" };
        }

    }
    public class tess
    {
        // harus memiliki modifier public agar dapat diakses leh class program
        public string aa = "ini atribute kelas tess pada file yang sama";
        //access modifier + permitted modifier
        //static tidak bisa diakses oleh class lain pada file yg sama
        public void tes()
        {
            Console.WriteLine("yey ini void tes()");
        }
    }
}
//comment ctrl+k + ctrl+c
//shift+alt+.