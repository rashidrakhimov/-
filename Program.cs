namespace летучка
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.Write("Веедите ФИО -"); st.FullName = Console.ReadLine();
            Console.Write("Дату рождения -"); st.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Номер"); st.ApplicationNumber = int.Parse(Console.ReadLine());

            Curriculum cr = new Curriculum();
            Console.Write("регистрационный номер"); cr.Code = int.Parse(Console.ReadLine());
            Console.Write(""); cr.Code = int.Parse(Console.ReadLine());
            Degree dgr = new Degree();
            Console.Write("Введите номер программы"); dgr.Code = int.Parse(Console.ReadLine());
            Console.Write("Кол-во нужных к.е."); dgr.CreditsRequired = int.Parse(Console.ReadLine());
            Console.Write("кол-во доп.курсов "); dgr.SpecialCoursesRequired = int.Parse(Console.ReadLine());

           

            Course[] theCourses = new Course[5];  //Чтобы добавить курс, надо увеличить массив и дополнить его. 
            theCourses[0] = new Course()
            {
                Code = 1,
                Title = "dflb",
                HasCoursePaper = true,
                HasExam = false,
                IsSpecial = false,
                LectureHours = 12,
                PracticeHours = 15,
                
            };
            theCourses[1] = new Course()
            {
                Code = 2,
                Title = "fgbfgng",
                HasCoursePaper = true,
                HasExam = true,
                IsSpecial = false,
                LectureHours = 12,
                PracticeHours = 10
            };
            theCourses[2] = new Course()
            {
                Code = 3,
                Title = "rklbmlkrgmb",
                HasCoursePaper = false,
                HasExam = false,
                IsSpecial = false,
                LectureHours = 12,
                PracticeHours = 12
            };
            theCourses[3] = new Course()
            {
                Code = 4,
                Title = "fgbmkfb",
                HasCoursePaper = true,
                HasExam = true,
                IsSpecial = false,
                LectureHours = 10,
                PracticeHours = 10
            };
            theCourses[4] = new Course()
            {
                Code = 5,
                Title = "fgbmpfskbmsf",
                HasCoursePaper = false,
                HasExam = false,
                IsSpecial = false,
                LectureHours = 12,
                PracticeHours = 15
            };

            //Выбор курсов.
        }
    }
}
