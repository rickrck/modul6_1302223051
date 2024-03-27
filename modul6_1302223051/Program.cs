using modul6_1302223051;

internal class Program
{
    private static void Main(string[] args)
    {

        SayaTubeUser praktikan = new SayaTubeUser("Ricky");
        SayaTubeVideo video1 = new SayaTubeVideo("tes1");
        SayaTubeVideo video2 = new SayaTubeVideo("tes2");
        SayaTubeVideo video3 = new SayaTubeVideo("tes3");
        SayaTubeVideo video4 = new SayaTubeVideo("tes4");
        SayaTubeVideo video5 = new SayaTubeVideo("tes5");
        SayaTubeVideo video6 = new SayaTubeVideo("tes6");
        SayaTubeVideo video7 = new SayaTubeVideo("tes7");
        SayaTubeVideo video8 = new SayaTubeVideo("tes8");
        SayaTubeVideo video9 = new SayaTubeVideo("tes9");
        SayaTubeVideo video10 = new SayaTubeVideo("tes10");
        video1.IncreasePlayCount(200);
        video2.IncreasePlayCount(200);
        video3.IncreasePlayCount(200);
        video4.IncreasePlayCount(200);
        video5.IncreasePlayCount(200);
        video6.IncreasePlayCount(200);
        video7.IncreasePlayCount(200);
        video8.IncreasePlayCount(200);
        video9.IncreasePlayCount(200);
        video10.IncreasePlayCount(200);
        praktikan.AddVideo(video1);
        praktikan.AddVideo(video2);
        praktikan.AddVideo(video3);
        praktikan.AddVideo(video4);
        praktikan.AddVideo(video5);
        praktikan.AddVideo(video6);
        praktikan.AddVideo(video7);
        praktikan.AddVideo(video8);
        praktikan.AddVideo(video9);
        praktikan.AddVideo(video10);
        video1.PrintVideoDetails();
        praktikan.PrintAllVideoPlaycount();
        praktikan.GetTotalVideoPlayCount();
    }
}