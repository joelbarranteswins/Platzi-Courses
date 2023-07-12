using System.Collections.ObjectModel;

namespace DependencyInversion
{
    public class StudentRepository : IStudentRepository
    {
        private static ObservableCollection<Student> collection;

        public StudentRepository()
        {
            InitData();
        }

        private void InitData()
        {
            if (collection == null) 
            {
                collection = new();
                collection.Add(new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }));
                collection.Add(new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }));
                collection.Add(new Student(3, "José Molina", new List<double>() { 2, 3 }));
            }
        }

        public IEnumerable<Student> GetAll()
        {
            return collection;
        }

        public void Add(Student student)
        {
            collection.Add(student);
        }
    }

    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();

        void Add(Student student);

    }
}