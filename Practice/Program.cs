using Practice.models;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SavingsAccount johnsSavings = new SavingsAccount("SA123456", "John Doe");
            BankAccount account = johnsSavings;
            //Upcasting - where a derived class object is assigned to a base class reference
            account.Deposit(1000);
            account.Withdraw(200);
            johnsSavings.AddInterest();
            account.DisplayBalance();
            CurrentAccount janesCurrent = new CurrentAccount("CA654321", "Jane Smith");
            janesCurrent.Deposit(500);
            janesCurrent.Withdraw(1000);
            janesCurrent.DisplayBalance();

            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 10);
            circle.Display();
            rectangle.Display();

            Dog dog = new Dog("Tommy");
            Fish fish = new Fish("Jelly");
            dog.Speak();
            dog.Eat();
            fish.Speak();
            fish.Eat();
            
            Car toyota = new Car("Toyota CHR");
            Bicycle trek = new Bicycle("Trek");
            toyota.Move();
            toyota.Refuel();
            trek.Move();
            trek.Refuel(); 

            Manager alice = new Manager("Alice", "M001");
            Developer bob = new Developer("Bob", "D001");
            alice.PerformTask();
            alice.AttendMeeting();
            bob.PerformTask();
            bob.AttendMeeting();

            VideoPlayer videoPlayer = new VideoPlayer("movie.mp4");
            AudioPlayer audioPlayer = new AudioPlayer("song.mp3");
            MediaPlayer mediaPlayer1 = audioPlayer;
            MediaPlayer mediaPlayer2 = videoPlayer;
            mediaPlayer1.Play();
            mediaPlayer2.Play();
            mediaPlayer1.Pause();
            mediaPlayer2.Pause();
            mediaPlayer1.Stop();
            mediaPlayer2.Stop();

            Console.ReadKey();
        }
    }
}