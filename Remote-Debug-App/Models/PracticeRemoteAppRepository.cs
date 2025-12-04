namespace Remote_Debug_App.Models
{
    public class PracticeRemoteAppRepository
    {
        public static PracticeRemoteAppRepository Instance;
        public PracticeRemoteAppRepository()
        {
            Instance = new PracticeRemoteAppRepository("https://github.com/coherentsolutionsinc/dotnet-acd-training-practice-remote-debugging");
        }
        private PracticeRemoteAppRepository(string repository)
        {
            Repository = repository;
        }

        public string Repository ;
    }
}
