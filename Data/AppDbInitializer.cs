﻿using FreshBooks.Data.Static;
using FreshBooks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FreshBooks.Data
{
    public class AppDbInitializer
    {
        /*public static void Seed(IApplicationBuilder applicationBuilder)
        {


            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookDbContext>();
                context.Database.EnsureCreated();
                //context.Database.EnsureDeleted();
                //User
                if (!context.BookUser.Any())
                {
                    context.BookUser.AddRange(new List<BookUser>()
                    {
                        new BookUser()
                        {
                            Email = "test5@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "schloedle@mail.uc.edu",
                            UserId = "71b2801f-e277-4e5e-a6c2-25abbd970e3f"
                        },
                        new BookUser()
                        {
                            Email = "testing5@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "tsting@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },
                        new BookUser()
                        {
                            Email = "testing@mail.uc.edu",
                            UserId = "f43a6352-f6e2-499c-a947-ef643d0d6e50"
                        },


                    });
                    context.SaveChanges();
                }
                //Books
                if (!context.Book.Any())
                {
                    context.Book.AddRange(new List<Book>()
                    {
                        new Book()

                        {
                            Edition = "7",
                            Title = "Murach’s C#",
                            ISBN = "978-1-943872-53-4",
                            Price = 17.89,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fcsharp.jpg?alt=media&token=191d5623-b438-43e1-a897-3f2e8f1bb750",
                            Author ="Anne Boehm and Joel Murach",
                            Subject="Information Technology",
                            BookUserId =3
                        },
                        new Book()

                        {
                            Edition = "2019",
                            Title = "Murach's SQL Server 2019 for Developers",
                            ISBN = "978-1-943872-57-2",
                            Price = 59.50,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fsql.jpg?alt=media&token=84132a3c-10f6-457c-902c-1bd41832d908",
                            Author ="Bryan Syverson and Joel Murach",
                            Subject="Information Technology",
                            BookUserId =3

                        },
                        new Book()

                        {
                            Edition = "6",
                            Title = "Computer Networks: A Systems Approach",
                            ISBN = "978-0128182000",
                            Price = 15.00,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fcomputernetworks.jpg?alt=media&token=274bacf5-5064-4754-8d33-913845c68394",
                            Author = "Larry L. Peterson and Bruce S. Davie",
                            Subject="Information Technology",
                            BookUserId =3
                        },
                        new Book()

                        {
                            Edition = "1",
                            Title = "IT Architecture For Dummies",
                            ISBN = "978-0470554234",
                            Price = 11.47,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fitdum.jpg?alt=media&token=99fd8c40-760d-4a78-a69d-31a4aea2c688",
                            Author ="Kalani Kirk Hausman and Susan Cook",
                            Subject="Information Technology",
                            BookUserId =4
                        },
                        new Book()

                        {
                            Edition = "N/A",
                            Title = "Learn Microsoft PowerApps: Build customized business applications without writing any code",
                            ISBN = "978-1789805826",
                            Price = 31.50,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FPA.jpg?alt=media&token=ec5f7e27-5129-4dfa-a026-544e4029b0ff",
                            Author = "Matthew Weston",
                            Subject="Information Technology",
                            BookUserId =5
                        },
                        new Book()

                        {
                            Edition = "3",
                            Title = "Game Design Workshop: A Playcentric Approach to Creating Innovative Games",
                            ISBN = "978-1-4822-1716-2",
                            Price = 78.93,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fgame.jpg?alt=media&token=af5bf692-ad75-42e7-a191-39aca2ae6899",
                            Author ="Tracy Fullerton",
                            Subject="Information Technology",
                            BookUserId =6
                        },
                        new Book()

                        {
                            Edition = "N/A",
                            Title = "IT Problem Management",
                            ISBN = "978-0130307705",
                            Price = 6.30,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FITProblemManagement.jpeg?alt=media&token=60e68456-c410-4e75-a75d-38c93503e9fa",
                            Author ="Gary Walker",
                            Subject="Information Technology",
                            BookUserId =7
                        },
                        new Book()

                        {
                            Edition = "5",
                            Title = "JavaScript from Beginner to Professional",
                            ISBN = "978-1800562523",
                            Price = 31.99,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FJS.jpg?alt=media&token=8a63b613-b839-4860-81dd-1f002f19af15",
                            Author ="Laurence Lars Svekis, Maaike van Putten, Rob Percival",
                            Subject="Infomation Technology",
                            BookUserId =8
                        },
                        new Book()

                        {
                            Edition = "4",
                            Title = "Windows 10 For Dummies",
                            ISBN = "978-1119679332",
                            Price = 15.57,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FWin10.jpg?alt=media&token=dc68c571-0444-4c37-899c-be16dff3f034",
                            Author ="Andy Rathbone",
                            Subject="Information Technology",
                            BookUserId =9
                        },
                        new Book()

                        {
                            Edition = "1",
                            Title = "Windows 11 For Dummies",
                            ISBN = "978-1119846475",
                            Price = 20.59,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FWin11.jpg?alt=media&token=37d06ec6-d128-4fd8-8b02-7afbf854692d",
                            Author ="Andy Rathbone",
                            Subject="Information Technology",
                            BookUserId =10
                        },
                        new Book()

                        {
                            Edition = "7",
                            Title = "Complete CompTIA A+ Guide to IT Hardware and Software",
                            ISBN = "978-0789756459",
                            Price = 91.81,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fcomptia.jpg?alt=media&token=f8f94955-bb42-4c1d-a702-374dc7e5d481",
                            Author ="Cheryl Schmidt",
                            Subject="Information Technology",
                            BookUserId =11
                        },
                        new Book()

                        {
                            Edition = "N/A",
                            Title = "The Perfect English Grammar Workbook: Simple Rules and Quizzes to Master Today's English",
                            ISBN = "978-1623157968",
                            Price = 9.99,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fenglish.webp?alt=media&token=728919ed-0631-4e73-9fb7-80d98cb2a0ed",
                            Author ="Lisa McLendon",
                            Subject="English",
                            BookUserId =12
                        },
                        new Book()

                        {
                            Edition = "4",
                            Title = "Game Design Workshop: A Playcentric Approach to Creating Innovative Games",
                            ISBN = "978-1138098770",
                            Price = 69.95,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fgame.jpg?alt=media&token=af5bf692-ad75-42e7-a191-39aca2ae6899",
                            Author ="Tracy Fullerton",
                            Subject="Information Technology",
                            BookUserId =13
                        },
                        new Book()

                        {
                            Edition = "2",
                            Title = "HTML and CSS QuickStart Guide",
                            ISBN = "978-1636100005",
                            Price = 25.00,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fhtmlcs.jpg?alt=media&token=6bbf9510-fcc9-4232-9512-f36ee04f415d",
                            Author ="David DuRocher",
                            Subject="Information Technology",
                            BookUserId =14
                        },
                        new Book()

                        {
                            Edition = "16",
                            Title = "iOS 16 Programming for Beginners",
                            ISBN = "978-1803237046",
                            Price = 30.00,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fios.jpg?alt=media&token=cfbdcaeb-c8b3-45ad-b305-604a9bd434e1",
                            Author ="Ahmad Sahar and Craig Clayton",
                            Subject="Information Technology",
                            BookUserId =15
                        },
                        new Book()

                        {
                            Edition = "N/A",
                            Title = "Cisco Networking Essentials",
                            ISBN = "979-8654241658",
                            Price = 21.0,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fnetworking.jpg?alt=media&token=6778302e-7316-418c-9a71-108ca1cf51aa",
                            Author ="Craig Berg",
                            Subject="Information Technology",
                            BookUserId =16
                        },
                        new Book()

                        {
                            Edition = "1",
                            Title = "Learn PowerShell Scripting in a Month of Lunches",
                            ISBN = "978-1617295096",
                            Price = 44.99,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fpowershell.jpg?alt=media&token=656244b6-15d0-4b1f-b0ef-6ff883b28695",
                            Author ="Don Jones and Jeffery Hicks",
                            Subject="Information Technology",
                            BookUserId =17
                        },
                        new Book()

                        {
                            Edition = "2",
                            Title = "The Science and Application of Positive Psychology",
                            ISBN = "978-1108460835",
                            Price = 64.99,
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fpsych.jpg?alt=media&token=9a1edd96-7f20-40e1-af7e-10e879ee10ed",
                            Author ="Jennifer S. Cheavens",
                            Subject="Psychology",
                            BookUserId =18
                        },

                    });
                    context.SaveChanges();
                }                
            }
        }*/

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "schloede@mail.uc.edu";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "David Schloemer",
                        UserName = "schloede",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Pa$$w0rd");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "test@mail.uc.edu";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Pa$$w0rd");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
