using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            //for Degree - TEJA
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree {DegreeId = 1, DegreeAbbr="ACS+2", DegreeName="MS ACS+2", NumberOfTerms=4},
                    new Degree {DegreeId = 2, DegreeAbbr="ACS+DB", DegreeName="MS ACS+DB", NumberOfTerms=4},
                    new Degree {DegreeId = 3, DegreeAbbr="ACS+NF", DegreeName="MS ACS+NF", NumberOfTerms=4},
                    new Degree {DegreeId = 4, DegreeAbbr="ACS", DegreeName="MS ACS", NumberOfTerms=4},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }


            //for Credit - Malli

            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist.");
                return;
            }
            else
            {
                var credits = new Credit[]
                {
                    new Credit {CreditId=460, CreditAbbr="DB", CreditName="Databases", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=356, CreditAbbr="NF", CreditName="Network Fundamentals", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=542, CreditAbbr="542", CreditName="OOPS with Java", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=563, CreditAbbr="563", CreditName="Web Apps", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=560, CreditAbbr="560", CreditName="Advanced Databases", IsSummer=1, IsSpring=1, IsFall=1},
                    new Credit {CreditId=664, CreditAbbr="664-UX", CreditName="User Experience", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=618, CreditAbbr="618-PM", CreditName="Project Management", IsSummer=1, IsSpring=0, IsFall=0},
                    new Credit {CreditId=555, CreditAbbr="555-NS", CreditName="Network Security", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=691, CreditAbbr="691-GDP1", CreditName="GDP1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=692, CreditAbbr="692-GDP2", CreditName="GDP2", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=6, CreditAbbr="Mobile", CreditName="643 or 644 Mobile", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=10, CreditAbbr="E1", CreditName="Elective 1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=20, CreditAbbr="E2", CreditName="Elective 2", IsSummer=0, IsSpring=1, IsFall=1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }


            //for Student - Mouni

            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
                return;
            }
            else
            {
                var students = new Student[]
                {
                    new Student {StudentId=533568, Family="Bodepudi", Given="Mallikarjuna", N919=919569870},
                    new Student {StudentId=533708, Family="Kancharla", Given="Sai Krishna Teja", N919=919571315},
                    new Student {StudentId=533897, Family="Atluri", Given="Mouni Krishna", N919=919571233},

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }



            //for DegreeCredit - Malli

            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
                return;

            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                    new DegreeCredit {DegreeCreditId=1, DegreeId=1, CreditId=460},
                    new DegreeCredit {DegreeCreditId=2, DegreeId=1, CreditId=356},
                    new DegreeCredit {DegreeCreditId=3, DegreeId=1, CreditId=542},
                    new DegreeCredit {DegreeCreditId=4, DegreeId=1, CreditId=563},
                    new DegreeCredit {DegreeCreditId=5, DegreeId=1, CreditId=560},
                    new DegreeCredit {DegreeCreditId=6, DegreeId=1, CreditId=664},
                    new DegreeCredit {DegreeCreditId=7, DegreeId=1, CreditId=618},
                    new DegreeCredit {DegreeCreditId=8, DegreeId=1, CreditId=555},
                    new DegreeCredit {DegreeCreditId=9, DegreeId=1, CreditId=691},
                    new DegreeCredit {DegreeCreditId=10, DegreeId=1, CreditId=692},
                    new DegreeCredit {DegreeCreditId=11, DegreeId=1, CreditId=6},
                    new DegreeCredit {DegreeCreditId=12, DegreeId=1, CreditId=10},
                    new DegreeCredit {DegreeCreditId=13, DegreeId=1, CreditId=20},
                    new DegreeCredit {DegreeCreditId=14, DegreeId=2, CreditId=460},
                    new DegreeCredit {DegreeCreditId=15, DegreeId=2, CreditId=542},
                    new DegreeCredit {DegreeCreditId=16, DegreeId=2, CreditId=563},
                    new DegreeCredit {DegreeCreditId=17, DegreeId=2, CreditId=560},
                    new DegreeCredit {DegreeCreditId=18, DegreeId=2, CreditId=664},
                    new DegreeCredit {DegreeCreditId=19, DegreeId=2, CreditId=618},
                    new DegreeCredit {DegreeCreditId=20, DegreeId=2, CreditId=555},
                    new DegreeCredit {DegreeCreditId=21, DegreeId=2, CreditId=691},
                    new DegreeCredit {DegreeCreditId=22, DegreeId=2, CreditId=692},
                    new DegreeCredit {DegreeCreditId=23, DegreeId=2, CreditId=6},
                    new DegreeCredit {DegreeCreditId=24, DegreeId=2, CreditId=10},
                    new DegreeCredit {DegreeCreditId=25, DegreeId=2, CreditId=20},
                    new DegreeCredit {DegreeCreditId=26, DegreeId=3, CreditId=356},
                    new DegreeCredit {DegreeCreditId=27, DegreeId=3, CreditId=542},
                    new DegreeCredit {DegreeCreditId=28, DegreeId=3, CreditId=563},
                    new DegreeCredit {DegreeCreditId=29, DegreeId=3, CreditId=560},
                    new DegreeCredit {DegreeCreditId=30, DegreeId=3, CreditId=664},
                    new DegreeCredit {DegreeCreditId=31, DegreeId=3, CreditId=618},
                    new DegreeCredit {DegreeCreditId=32, DegreeId=3, CreditId=555},
                    new DegreeCredit {DegreeCreditId=33, DegreeId=3, CreditId=691},
                    new DegreeCredit {DegreeCreditId=34, DegreeId=3, CreditId=692},
                    new DegreeCredit {DegreeCreditId=35, DegreeId=3, CreditId=6},
                    new DegreeCredit {DegreeCreditId=36, DegreeId=3, CreditId=10},
                    new DegreeCredit {DegreeCreditId=37, DegreeId=3, CreditId=20},
                    new DegreeCredit {DegreeCreditId=38, DegreeId=4, CreditId=542},
                    new DegreeCredit {DegreeCreditId=39, DegreeId=4, CreditId=563},
                    new DegreeCredit {DegreeCreditId=40, DegreeId=4, CreditId=560},
                    new DegreeCredit {DegreeCreditId=41, DegreeId=4, CreditId=664},
                    new DegreeCredit {DegreeCreditId=42, DegreeId=4, CreditId=618},
                    new DegreeCredit {DegreeCreditId=43, DegreeId=4, CreditId=555},
                    new DegreeCredit {DegreeCreditId=44, DegreeId=4, CreditId=691},
                    new DegreeCredit {DegreeCreditId=45, DegreeId=4, CreditId=692},
                    new DegreeCredit {DegreeCreditId=46, DegreeId=4, CreditId=6},
                    new DegreeCredit {DegreeCreditId=47, DegreeId=4, CreditId=10},
                    new DegreeCredit {DegreeCreditId=48, DegreeId=4, CreditId=20},

                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degree credits.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }


            //for DegreePlan - Mouni 

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exist.");
                return;
            }
            else
            {
                var degreePlans = new DegreePlan[]
                {
                    new DegreePlan {DegreePlanId=1, StudentId=533568, DegreePlanAbbr="Super Fast", DegreePlanName="Cheetah", DegreePlanSelected=5681},
                    new DegreePlan {DegreePlanId=2, StudentId=533568, DegreePlanAbbr="Slow and Easy", DegreePlanName="Tortoise", DegreePlanSelected=5682},
                    new DegreePlan {DegreePlanId=3, StudentId=533708, DegreePlanAbbr="Super Fast", DegreePlanName="Cheetah", DegreePlanSelected=7081},
                    new DegreePlan {DegreePlanId=4, StudentId=533708, DegreePlanAbbr="Slow and Easy", DegreePlanName="Tortoise", DegreePlanSelected=7082},
                    new DegreePlan {DegreePlanId=5, StudentId=533897, DegreePlanAbbr="Super Fast", DegreePlanName="Cheetah", DegreePlanSelected=8971},
                    new DegreePlan {DegreePlanId=6, StudentId=533897, DegreePlanAbbr="Summer Off", DegreePlanName="Rabbit", DegreePlanSelected=8973},


                };
                Console.WriteLine($"Inserted {degreePlans.Length} new Degree Plans.");

                foreach (DegreePlan d in degreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }


            //for Slot - TEJA

            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist.");
                return;
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot {SlotId=1, DegreePlanSelected=5681, Term=1, CreditId=542, Status="C"},
                    new Slot {SlotId=2, DegreePlanSelected=5681, Term=1, CreditId=563, Status="C"},
                    new Slot {SlotId=3, DegreePlanSelected=5681, Term=1, CreditId=560, Status="C"},
                    new Slot {SlotId=4, DegreePlanSelected=5681, Term=2, CreditId=664, Status="A"},
                    new Slot {SlotId=5, DegreePlanSelected=5681, Term=2, CreditId=6, Status="A"},
                    new Slot {SlotId=6, DegreePlanSelected=5681, Term=2, CreditId=10, Status="A"},
                    new Slot {SlotId=7, DegreePlanSelected=5681, Term=3, CreditId=618, Status="P"},
                    new Slot {SlotId=8, DegreePlanSelected=5681, Term=3, CreditId=691, Status="P"},
                    new Slot {SlotId=9, DegreePlanSelected=5681, Term=4, CreditId=692, Status="P"},
                    new Slot {SlotId=10, DegreePlanSelected=5681, Term=4, CreditId=20, Status="P"},
                    new Slot {SlotId=11, DegreePlanSelected=5681, Term=4, CreditId=555, Status="P"},
                    new Slot {SlotId=12, DegreePlanSelected=7082, Term=1, CreditId=542, Status="C"},
                    new Slot {SlotId=13, DegreePlanSelected=7082, Term=1, CreditId=563, Status="C"},
                    new Slot {SlotId=14, DegreePlanSelected=7082, Term=1, CreditId=560, Status="C"},
                    new Slot {SlotId=15, DegreePlanSelected=7082, Term=2, CreditId=664, Status="A"},
                    new Slot {SlotId=16, DegreePlanSelected=7082, Term=2, CreditId=6, Status="A"},
                    new Slot {SlotId=17, DegreePlanSelected=7082, Term=2, CreditId=10, Status="A"},
                    new Slot {SlotId=18, DegreePlanSelected=7082, Term=3, CreditId=618, Status="P"},
                    new Slot {SlotId=19, DegreePlanSelected=7082, Term=4, CreditId=691, Status="P"},
                    new Slot {SlotId=20, DegreePlanSelected=7082, Term=4, CreditId=20, Status="P"},
                    new Slot {SlotId=21, DegreePlanSelected=7082, Term=5, CreditId=692, Status="P"},
                    new Slot {SlotId=22, DegreePlanSelected=7082, Term=5, CreditId=555, Status="P"},
                    new Slot {SlotId=23, DegreePlanSelected=8973, Term=1, CreditId=542, Status="A"},
                    new Slot {SlotId=24, DegreePlanSelected=8973, Term=1, CreditId=563, Status="A"},
                    new Slot {SlotId=25, DegreePlanSelected=8973, Term=1, CreditId=560, Status="A"},
                    new Slot {SlotId=26, DegreePlanSelected=8973, Term=2, CreditId=664, Status="P"},
                    new Slot {SlotId=27, DegreePlanSelected=8973, Term=2, CreditId=6, Status="P"},
                    new Slot {SlotId=28, DegreePlanSelected=8973, Term=2, CreditId=10, Status="P"},
                    new Slot {SlotId=29, DegreePlanSelected=8973, Term=3, CreditId=20, Status="P"},
                    new Slot {SlotId=30, DegreePlanSelected=8973, Term=3, CreditId=555, Status="P"},
                    new Slot {SlotId=31, DegreePlanSelected=8973, Term=3, CreditId=691, Status="P"},
                    new Slot {SlotId=32, DegreePlanSelected=8973, Term=4, CreditId=618, Status="P"},
                    new Slot {SlotId=33, DegreePlanSelected=8973, Term=4, CreditId=692, Status="P"},

                };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot d in slots)
                {
                    context.Slots.Add(d);
                }
                context.SaveChanges();
            }

            //for StudentTerm - TEJA
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
                return;
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm {StudentTermId=1, StudentId=533568, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermId=2, StudentId=533568, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermId=3, StudentId=533568, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermId=4, StudentId=533568, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermId=5, StudentId=533708, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermId=6, StudentId=533708, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermId=7, StudentId=533708, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermId=8, StudentId=533708, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermId=9, StudentId=533708, Term=5, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermId=10, StudentId=533897, Term=1, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermId=11, StudentId=533897, Term=2, TermAbbr="FA20", TermName="Fall 2020"},
                    new StudentTerm {StudentTermId=12, StudentId=533897, Term=3, TermAbbr="SP21", TermName="Spring 2021"},
                    new StudentTerm {StudentTermId=13, StudentId=533897, Term=4, TermAbbr="SU21", TermName="Summer 2021"},

                };
                Console.WriteLine($"Inserted {studentTerms.Length} new student terms.");

                foreach (StudentTerm d in studentTerms)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }


        }

    }
}
