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
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Students");
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
            list.Add(new Student()
            {
                RollNumber = "A022",
                Name = "Student 022",
                Email = "student022@gmail.com",
                Birthday = DateTime.ParseExact("1998-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2008-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A023",
                Name = "Student 023",
                Email = "student023@gmail.com",
                Birthday = DateTime.ParseExact("1995-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2008-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A024",
                Name = "Student 024",
                Email = "student024@gmail.com",
                Birthday = DateTime.ParseExact("1991-05-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A025",
                Name = "Student 025",
                Email = "student025@gmail.com",
                Birthday = DateTime.ParseExact("1991-07-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A026",
                Name = "Student 026",
                Email = "student026@gmail.com",
                Birthday = DateTime.ParseExact("1992-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A027",
                Name = "Student 027",
                Email = "student02@7gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2018-01-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A028",
                Name = "Student 028",
                Email = "student028@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A029",
                Name = "Student 029",
                Email = "student029@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A030",
                Name = "Student 030",
                Email = "student030@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-06", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A031",
                Name = "Student 031",
                Email = "student031@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-05", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A032",
                Name = "Student 032",
                Email = "student032@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-05", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A033",
                Name = "Student 033",
                Email = "student033@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A034",
                Name = "Student 034",
                Email = "student034@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A035",
                Name = "Student 035",
                Email = "student035@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A036",
                Name = "Student 036",
                Email = "student036@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A037",
                Name = "Student 037",
                Email = "student037@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-04", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A038",
                Name = "Student 038",
                Email = "student038@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A039",
                Name = "Student 039",
                Email = "student039@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A040",
                Name = "Student 040",
                Email = "student040@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A041",
                Name = "Student 041",
                Email = "student041@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A042",
                Name = "Student 042",
                Email = "student042@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A043",
                Name = "Student 043",
                Email = "student043@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A044",
                Name = "Student 044",
                Email = "student044@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A045",
                Name = "Student 045",
                Email = "student045@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A046",
                Name = "Student 046",
                Email = "student046@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A047",
                Name = "Student 047",
                Email = "student047@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A048",
                Name = "Student 048",
                Email = "student048@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A049",
                Name = "Student 049",
                Email = "student049@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A050",
                Name = "Student 050",
                Email = "student050@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-02", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A051",
                Name = "Student 051",
                Email = "student051@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-02", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A052",
                Name = "Student 052",
                Email = "student052@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-02", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A053",
                Name = "Student 053",
                Email = "student053@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-02", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                Image = "https://res.cloudinary.com/xuanhung2401/image/upload/v1575294675/b740b7qurmaekbqahqlb.jpg",
                Status = Student.StudentStatus.Active,
                UpdatedAt = DateTime.Now,
                Note = "Hello Seeding"
            });
            list.Add(new Student()
            {
                RollNumber = "A054",
                Name = "Student 054",
                Email = "student054@gmail.com",
                Birthday = DateTime.ParseExact("1993-07-09", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.ParseExact("2019-12-01", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
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
