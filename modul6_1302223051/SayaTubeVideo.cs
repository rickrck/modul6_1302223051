using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random = System.Random;

namespace modul6_1302223051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
                Random random = new Random();
                this.id = random.Next(10000, 99999);
                this.title = title;
                this.playCount = 0;
            
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details");
            Console.WriteLine($"ID \t\t: {id} \n" +
                $"Title \t\t: {title} \n" +
                $"Play Count \t: {playCount} \n");
        }

        public int getCount()
        {
            return this.playCount;
        }

        public string getTitle() { 
            return this.title;
        }
    }
}

