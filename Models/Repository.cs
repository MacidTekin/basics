namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();    //readonly sadece okunabilir olması için. Private oldugu için _courses

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course(){
                    Id = 1, 
                    Title = "ASP.NET Kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "1.jpg",
                    Tags = new string[]{"aspnet","web geliştirme"},
                    isActive = true,
                    isHome = true
                    },
                new Course(){
                    Id = 2, 
                    Title = "Php", 
                    Description = "Güzel bir kurs", 
                    Image = "2.jpg",
                    Tags = new string[]{"php","web geliştirme"},
                    isActive = true,
                    isHome = true
                    },
                new Course(){Id = 3, 
                    Title = "Django Kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "3.jpg",
                    isActive = true,
                    isHome = false
                    },
                new Course(){
                    Id = 4, 
                    Title = "JavaScript Kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "1.jpg",
                    isActive = true,
                    isHome = true
                    }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course GetById(int id){//public diyerek dışarıya bir Course objesi göndereceğiz.
            return _courses.FirstOrDefault(c => c.Id == id); //_courses içersindeki her bi dosyayı c'nin içersine kopyaladığımızı düşün.
        } 
    }
}