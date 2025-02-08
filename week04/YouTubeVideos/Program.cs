using System;
class Program
{
    static void Main()
    {
        List<Video> videos = CreateVideos.GenerateVideoList();
        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("--------------------------");
        }
    }
}