class CreateVideos
{
    public static List<Video> GenerateVideoList()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The book of Mormon", "Carl Smith", 650);
        video1.AddComment("John", "Great explanation!");
        video1.AddComment("Barry", "Nice and helpful, thanks!");
        video1.AddComment("Cherry", "Thanks!");
        video1.AddComment("Dory", "This was really special!");
        
        Video video2 = new Video("Eternal Life", "Jessy Brown", 757);
        video2.AddComment("Mary", "I love how you explained!");
        video2.AddComment("Franky", "Can you explain the DYC 23:5");
        video2.AddComment("Grace", "Thank you!");
        video2.AddComment("Harry", "Helped me a lot");
        
        Video video3 = new Video("The Power of Faith", "Michael Monzon", 420);
        video3.AddComment("Idrac", "Awesome!");
        video3.AddComment("Jack", "Can you explain more about faith?");
        video3.AddComment("Rosy", "Thanks for making it simple.");
        video3.AddComment("Leonidas", "This was super useful great!");
        
        Video video4 = new Video("The Covenant Path:", "Adeyinka A. Ojediran", 930);
        video4.AddComment("Moana", "Great, that was awsome!");
        video4.AddComment("Nathalee", "Loved the explanation.");
        video4.AddComment("Oliver", "Very nice speach!");
        video4.AddComment("Paul", "Thanks for the valuable content!");
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        
        return videos;
    }
}