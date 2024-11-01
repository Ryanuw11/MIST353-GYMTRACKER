##API DOCUMENTATION
###Ryan Dowd's work

####I created two API's that serve the purpose of lookups. The first being the UserData API which serves to allow the user to view the contents of their profile when they search by their ID which will display their profile details. 
####When implemeted fully it will allow the user to search for their profile and make changes to the data. The user inputs their unique ID and it will come up with their user name, email, level, etc.

####The second API is meant to serve as a gym lookup feature which will allow the user to search for a gym by name and view their address and hours of operation. The user will input FITFUSION for example and it will come up with its city and its hours of operation

####Dalton Knippel's work
#####The first API I decided to go with is one for the user to add an exercise they want to share with the community. The user will have the option to input the intended muscles a workout is going to target, as well as what additional eqiupment is required.
The user is also going to name the exercise they are sharing. The second API is one for the user to search about an apperal item they want to know the details of. The user just needs the apperal ID number, and they will get the details all about it  and what they are good for. 
########ChatGPT for Exercise and Apperal Classes:
               ###########################I am converting sql server stored procedures to apis in ASP.NET Core 8. I need to convert this table to a class. Give me the code: CREATE TABLE [dbo].[ext_exercise](
	            [exercise_id] [int] IDENTITY(1,1) NOT NULL,
	            [exercise_name] [nvarchar](255) NOT NULL,
	            [exercise_equipment] [nvarchar](255) NULL,
	            [exercise_muscleTarget] [nvarchar](255) NOT NULL,
            ChatGPT said:
            ChatGPT
            Here is the code for your ext_exercise table as a C# class in ASP.NET Core:

            csharp
            Copy code
            using System.ComponentModel.DataAnnotations;
            using System.ComponentModel.DataAnnotations.Schema;

            namespace YourNamespace.Models
            {
                [Table("ext_exercise")]
                public class Exercise
                {
                    [Key]
                    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                    public int ExerciseId { get; set; }

                    [Required]
                    [StringLength(255)]
                    public string ExerciseName { get; set; }

                    [StringLength(255)]
                    public string? ExerciseEquipment { get; set; }

                    [Required]
                    [StringLength(255)]
                    public string ExerciseMuscleTarget { get; set; }
                }
            }

                        I am converting sql server stored procedures to apis in ASP.NET Core 8. I need to convert this table to a class. Give me the code: CREATE TABLE [dbo].[ext_exercise_apperal]( 
	            [apperal_id] [int] IDENTITY(1,1) NOT NULL,
	            [apperal_type] [nvarchar](255) NOT NULL,
	            [apperal_brand] [nvarchar](255) NOT NULL,
	            [apperal_material] [nvarchar](255) NOT NULL,
	            [apperal_exercise] [int] NOT NULL,
            ChatGPT said:
            ChatGPT
            Here's the C# code for your ext_exercise_apperal table as a class in ASP.NET Core:

            csharp
            Copy code
            using System.ComponentModel.DataAnnotations;
            using System.ComponentModel.DataAnnotations.Schema;

            namespace YourNamespace.Models
            {
                [Table("ext_exercise_apperal")]
                public class ExerciseApparel
                {
                    [Key]
                    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                    public int ApparelId { get; set; }

                    [Required]
                    [StringLength(255)]
                    public string ApparelType { get; set; }

                    [Required]
                    [StringLength(255)]
                    public string ApparelBrand { get; set; }

                    [Required]
                    [StringLength(255)]
                    public string ApparelMaterial { get; set; }

                    [Required]
                    public int ApparelExercise { get; set; }
                }
            }



     #### Joshua Morrison Work ####

     I created 2 APIS that looked up the class price and looked up the Membership Level of each person. The point was to be able for users to lookup there membership easier and to be able to make it easier. 

     CHAT GPT USE 
[HttpGet("{Membership_ID}")]
        public async Task<List<Membership>> MembershipLevelLength(string MembershipLevel)
        {
            var MembershipDetails = await MembershipService.MembershipLevelLength(MembershipLevel);
            if (MembershipDetails == null)
            {
            }
            return MembershipDetails;

I used this portion in chat GPT. I also used this part as well from ChatGPT.

I just looked up how to put data visual studio from my sql. 

    public class Course
    {
        public int CID { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(255)]
        public int LengthMinutes { get; set; }

        [Required]
        [StringLength(255)]
        public string TrainerFirstName { get; set; }


        [Required]
        [StringLength(255)]
        public string TrainerLastName { get; set; }


        [Required]
        [StringLength(255)]
        public int Price { get; set; }



    }
