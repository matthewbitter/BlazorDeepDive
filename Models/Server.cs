namespace BlazorDeepDive.Models
{
    public class Server
    {

        public Server()
        {

            var random = new Random();
            var randomNumber = random.Next(0, 2);

            IsOnline = randomNumber == 0 ? false : true;

            ServerId = 0;
            Name = string.Empty;
            City = string.Empty;

        }

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }


}
}
