using System;

public class VideoGenerator{
    List<Video> _videos;

    public VideoGenerator(){
        _videos=new List<Video>();
    }
    public void AddVideo (){
    Console.Write("Please write a video title ");
    string title = Console.ReadLine();
    Console.Write("Please write the author name ");
    string name = Console.ReadLine();
    Console.Write("Please introduce the lenth of the video ");
    int lenth = Convert.ToInt32(Console.ReadLine());
    Video video = new Video(title, name, lenth);
    _videos.Add(video);
}
    public void CreateComment(){
        Console.WriteLine("Please choose the video number for comment");
        int number = Convert.ToInt32(Console.ReadLine());
        Video video = _videos[number-1];
        video.AddComment();
    }
    public void DisplayAllVideosInfo(){
        for (int i=0; i<_videos.Count();i++){
            Console.WriteLine($"Video {i+1}:");
            _videos[i].DisplayVideoInfo();
        }
    }
    public void Start(){
        while (true){
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create a new video");
            Console.WriteLine("2.Create a new comment");
            Console.WriteLine("3.Show a list of videos");
            Console.WriteLine("4.Quit");
            Console.Write("What is your choice 1-4? ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(choice){
                case 1:
                AddVideo();
                break;
                case 2:
                CreateComment();
                break;
                case 3:
                DisplayAllVideosInfo();
                break;
                case 4:
                return;

            }
        }
    }
}