using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random randomId = new Random();
            id = randomId.Next(10000, 99999);
        }

        public void increasePlayCount(int increment)
        {
            try
            {
                checked
                {
                    playCount += increment;
                    if (playCount + increment > 10000000) throw new ArgumentOutOfRangeException();
                }
            }

            catch (ArgumentOutOfRangeException argex)
            {
                Console.WriteLine(argex.Message);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");
        }


    }
}
