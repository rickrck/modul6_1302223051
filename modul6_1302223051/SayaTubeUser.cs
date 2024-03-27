using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random = System.Random;

namespace modul6_1302223051
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
            this.Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getCount();
            }

            return total;
        }

        public void AddVideo(SayaTubeVideo judul)
        {
            uploadedVideos.Add(judul);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + Username);
            for (int i = 0;i < uploadedVideos.Count;i++)
            {
                Console.WriteLine($"Video {i + 1} judul : {uploadedVideos[i].getTitle()}");
            }
        }
    }
}
