using System.Collections.Generic;
using StudentManagement.Models;

namespace StudentManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagement.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManagement.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE students");
            var list = new List<Student>();
            list.Add(new Student()
            {
                RollNumber = "A001",
                Name = "Student 001",
                Email = "student01@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A002",
                Name = "Student 002",
                Email = "student02@gmail.com",
                Birthday = DateTime.ParseExact("1998-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2016-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A003",
                Name = "Student 003",
                Email = "student03@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2015-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A004",
                Name = "Student 004",
                Email = "student04@gmail.com",
                Birthday = DateTime.ParseExact("1996-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A005",
                Name = "Student 005",
                Email = "student05@gmail.com",
                Birthday = DateTime.ParseExact("1995-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A006",
                Name = "Student 006",
                Email = "student06@gmail.com",
                Birthday = DateTime.ParseExact("1994-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A007",
                Name = "Student 007",
                Email = "student07@gmail.com",
                Birthday = DateTime.ParseExact("1989-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2016-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A008",
                Name = "Student 008",
                Email = "student08@gmail.com",
                Birthday = DateTime.ParseExact("1998-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A009",
                Name = "Student 009",
                Email = "student09@gmail.com",
                Birthday = DateTime.ParseExact("1994-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2017-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A010",
                Name = "Student 010",
                Email = "student010@gmail.com",
                Birthday = DateTime.ParseExact("1999-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-01", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A011",
                Name = "Student 011",
                Email = "student011@gmail.com",
                Birthday = DateTime.ParseExact("1999-02-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2017-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A012",
                Name = "Student 012",
                Email = "student012@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-07", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-03-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A013",
                Name = "Student 013",
                Email = "student013@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-11-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A014",
                Name = "Student 014",
                Email = "student014@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A015",
                Name = "Student 015",
                Email = "student015@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2015-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A016",
                Name = "Student 016",
                Email = "student016@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2015-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A017",
                Name = "Student 017",
                Email = "student017@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2017-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A018",
                Name = "Student 018",
                Email = "student018@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2000-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A019",
                Name = "Student 019",
                Email = "student019@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2010-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A020",
                Name = "Student 020",
                Email = "student020@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2009-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A021",
                Name = "Student 021",
                Email = "student021@gmail.com",
                Birthday = DateTime.ParseExact("1999-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2008-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            context.Students.AddRange(list);
            context.SaveChanges();
        }
    }
}
