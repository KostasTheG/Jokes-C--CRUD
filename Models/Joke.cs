namespace Jokes.Models
{
    public class Joke
    {
        public string Id { get; set; }
        public string? jokeQuestion { get; set; }

        public string? jokeAnswer { get; set; }
        public Joke() { 
        }

        public Joke(string id, string jokeQuestion, string jokeAnswer)
        {
            Id = id;
            this.jokeQuestion = jokeQuestion;
            this.jokeAnswer = jokeAnswer;
        }


    }
}
