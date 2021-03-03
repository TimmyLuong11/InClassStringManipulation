using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string artist = "tAylOr sWIFt";
            //string newValue = artist.ToLower();
            artist = artist.ToLower();
            //string artistWithProperName = artist[0].ToString().ToUpper();
            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1,6) + artist.ToUpper()[7] + artist.Substring(8);

            //for (int i = 0; i < artistWithProperName.Length; ++i)
            //{
            //    Console.WriteLine(artistWithProperName[i]);
            //}
            Console.WriteLine(artistWithProperName);


            string realArtist = "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, BilLiE eiLiSh";

            //string[] artistName = realArtist.Split(',');
            string[] artistName = realArtist.Split(", ");
            for (int i = 0; i < artistName.Length; i++)
            {
                string list = artistName[i].ToLower();
                int spaceLoc = list.IndexOf(' ');
                //string artistProperName = list.ToUpper()[0] + list.Substring(1, spaceLoc) + list.ToUpper()[spaceLoc+1] + list.Substring(spaceLoc+2);
                string[] name = list.Split(' ');
                string fName = name[0];
                string lName = name[1];
                fName = fName.ToUpper()[0] + fName.Substring(1);
                lName = lName.ToUpper()[0] + lName.Substring(1);
                //Console.WriteLine(list.Trim());
                //Console.WriteLine(artistProperName);
                Console.WriteLine($"{fName} {lName}");
            }
        }
    }
}
