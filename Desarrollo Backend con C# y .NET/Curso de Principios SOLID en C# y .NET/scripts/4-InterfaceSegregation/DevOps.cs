namespace InterfaceSegregation
{
    public class DevOps : IWorkTeamActivities, IDesignActivities, IDevelopActivities
    {
        public DevOps()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Design()
        {
            throw new ArgumentException();
        }


        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}