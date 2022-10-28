using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final_project_on_Enviromental_Survey.Models
{
    public class WebContext : DbContext
    {
      
        public WebContext()
            : base("dbconn")
        {
        }




        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<Category> Categoriess { get; set; }
        public DbSet<WorkShops> WorkShops { get; set; }
        public DbSet<Lectures> GetLectures { get; set; }
        public DbSet<Seminars> Seminars { get; set; }
        public DbSet<teaSignUp> teaSignUps { get; set; }
        public DbSet<stdSignUp> stdSignUps { get; set; }


    }

    public class SignUp
    {
        [Key]
        public int SignUp_Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string Father_Name { get; set; }

        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string Date_of_Birth { get; set; }

        public string password { get; set; }


    }

    public class teaSignUp
    {
        [Key]
        public int T_SignUp_Id { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public int Teacher_Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string T_Name { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string T_Father_Name { get; set; }

        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string T_Date_of_Birth { get; set; }
        public string T_password { get; set; }
    }
    public class Survey
    {
        [Key]
        public int Sur_Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Descriptions { get; set; }
        public Category Categories { get; set; }



    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
    }
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public Category Category { get; set; }

    }
    public class Lectures
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Lecturer { get; set; }
        public DateTime DateTime { get; set; }
        public string Decritons { get; set; }
        public string File { get; set; }

    }
    public class WorkShops
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Lecturer { get; set; }
        public DateTime DateTime { get; set; }
        public string Decritons { get; set; }
        public string File { get; set; }

    }
    public class Seminars
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Lecturer { get; set; }
        public DateTime DateTime { get; set; }
        public string Decritons { get; set; }
        public string File { get; set; }
        public string video { get; set; }

    }

    public  class stdSignUp
    {

        [Key]
        public int std_SignUp_Id { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public int Student_Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string std_Name { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
      ErrorMessage = "Characters are not allowed.")]
        public string std_Father_Name { get; set; }

        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string std_Date_of_Birth { get; set; }
        public string std_password { get; set; }

    }

}