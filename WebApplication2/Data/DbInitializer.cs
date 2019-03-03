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
            //for Degree - TEJA
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree { DegreeID = 1, DegreeAbbr = "ACS+2", DegreeName = "MS ACS+2" },
                    new Degree { DegreeID = 2, DegreeAbbr = "ACS+DB", DegreeName = "MS ACS+DB" },
                    new Degree { DegreeID = 3, DegreeAbbr = "ACS+NF", DegreeName = "MS ACS+NF" },
                    new Degree { DegreeID = 4, DegreeAbbr = "ACS", DegreeName = "MS ACS" },
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
            }
            else
            {
                var credits = new Credit[]
                {
                    new Credit {CreditID=460, CreditAbbr='DB', CreditName='Databases', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=356, CreditAbbr='NF', CreditName='Network Fundamentals', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=542, CreditAbbr='542', CreditName='OOPS with Java', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=563, CreditAbbr='563', CreditName='Web Apps', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=560, CreditAbbr='560', CreditName='Advanced Databases', IsSummer=1, IsSpring=1, IsFall=1},
                    new Credit {CreditID=664, CreditAbbr='664-UX', CreditName='User Experience', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=618, CreditAbbr='618-PM', CreditName='Project Management', IsSummer=1, IsSpring=0, IsFall=0},
                    new Credit {CreditID=555, CreditAbbr='555-NS', CreditName='Network Security', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=691, CreditAbbr='691-GDP1', CreditName='GDP1', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=692, CreditAbbr='692-GDP2', CreditName='GDP2', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=6, CreditAbbr='Mobile', CreditName='643 or 644 Mobile', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=10, CreditAbbr='E1', CreditName='Elective 1', IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditID=20, CreditAbbr='E2', CreditName='Elective 2', IsSummer=0, IsSpring=1, IsFall=1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }


            //for Student - Mouni

            //for DegreeCredit - Malli

            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                    new DegreeCredit {DegreeCreditID=1, DegreeID=1, CreditID=460},
                    new DegreeCredit {DegreeCreditID=2, DegreeID=1, CreditID=356},
                    new DegreeCredit {DegreeCreditID=3, DegreeID=1, CreditID=542},
                    new DegreeCredit {DegreeCreditID=4, DegreeID=1, CreditID=563},
                    new DegreeCredit {DegreeCreditID=5, DegreeID=1, CreditID=560},
                    new DegreeCredit {DegreeCreditID=6, DegreeID=1, CreditID=664},
                    new DegreeCredit {DegreeCreditID=7, DegreeID=1, CreditID=618},
                    new DegreeCredit {DegreeCreditID=8, DegreeID=1, CreditID=555},
                    new DegreeCredit {DegreeCreditID=9, DegreeID=1, CreditID=691},
                    new DegreeCredit {DegreeCreditID=10, DegreeID=1, CreditID=692},
                    new DegreeCredit {DegreeCreditID=11, DegreeID=1, CreditID=6},
                    new DegreeCredit {DegreeCreditID=12, DegreeID=1, CreditID=10},
                    new DegreeCredit {DegreeCreditID=13, DegreeID=1, CreditID=20},
                    new DegreeCredit {DegreeCreditID=14, DegreeID=2, CreditID=460},
                    new DegreeCredit {DegreeCreditID=15, DegreeID=2, CreditID=542},
                    new DegreeCredit {DegreeCreditID=16, DegreeID=2, CreditID=563},
                    new DegreeCredit {DegreeCreditID=17, DegreeID=2, CreditID=560},
                    new DegreeCredit {DegreeCreditID=18, DegreeID=2, CreditID=664},
                    new DegreeCredit {DegreeCreditID=19, DegreeID=2, CreditID=618},
                    new DegreeCredit {DegreeCreditID=20, DegreeID=2, CreditID=555},
                    new DegreeCredit {DegreeCreditID=21, DegreeID=2, CreditID=691},
                    new DegreeCredit {DegreeCreditID=22, DegreeID=2, CreditID=692},
                    new DegreeCredit {DegreeCreditID=23, DegreeID=2, CreditID=6},
                    new DegreeCredit {DegreeCreditID=24, DegreeID=2, CreditID=10},
                    new DegreeCredit {DegreeCreditID=25, DegreeID=2, CreditID=20},
                    new DegreeCredit {DegreeCreditID=26, DegreeID=3, CreditID=356},
                    new DegreeCredit {DegreeCreditID=27, DegreeID=3, CreditID=542},
                    new DegreeCredit {DegreeCreditID=28, DegreeID=3, CreditID=563},
                    new DegreeCredit {DegreeCreditID=29, DegreeID=3, CreditID=560},
                    new DegreeCredit {DegreeCreditID=30, DegreeID=3, CreditID=664},
                    new DegreeCredit {DegreeCreditID=31, DegreeID=3, CreditID=618},
                    new DegreeCredit {DegreeCreditID=32, DegreeID=3, CreditID=555},
                    new DegreeCredit {DegreeCreditID=33, DegreeID=3, CreditID=691},
                    new DegreeCredit {DegreeCreditID=34, DegreeID=3, CreditID=692},
                    new DegreeCredit {DegreeCreditID=35, DegreeID=3, CreditID=6},
                    new DegreeCredit {DegreeCreditID=36, DegreeID=3, CreditID=10},
                    new DegreeCredit {DegreeCreditID=37, DegreeID=3, CreditID=20},
                    new DegreeCredit {DegreeCreditID=38, DegreeID=4, CreditID=542},
                    new DegreeCredit {DegreeCreditID=39, DegreeID=4, CreditID=563},
                    new DegreeCredit {DegreeCreditID=40, DegreeID=4, CreditID=560},
                    new DegreeCredit {DegreeCreditID=41, DegreeID=4, CreditID=664},
                    new DegreeCredit {DegreeCreditID=42, DegreeID=4, CreditID=618},
                    new DegreeCredit {DegreeCreditID=43, DegreeID=4, CreditID=555},
                    new DegreeCredit {DegreeCreditID=44, DegreeID=4, CreditID=691},
                    new DegreeCredit {DegreeCreditID=45, DegreeID=4, CreditID=692},
                    new DegreeCredit {DegreeCreditID=46, DegreeID=4, CreditID=6},
                    new DegreeCredit {DegreeCreditID=47, DegreeID=4, CreditID=10},
                    new DegreeCredit {DegreeCreditID=48, DegreeID=4, CreditID=20},

                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degree credits.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }


            //for DegreePlan - Mouni 

            //for Slot - TEJA

            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist.");
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot {SlotID=1, DegreePlanSelected=5681, Term=1, CreditID=542, Status="C"},
                    new Slot {SlotID=2, DegreePlanSelected=5681, Term=1, CreditID=563, Status="C"},
                    new Slot {SlotID=3, DegreePlanSelected=5681, Term=1, CreditID=560, Status="C"},
                    new Slot {SlotID=4, DegreePlanSelected=5681, Term=2, CreditID=664, Status="A"},
                    new Slot {SlotID=5, DegreePlanSelected=5681, Term=2, CreditID=6, Status="A"},
                    new Slot {SlotID=6, DegreePlanSelected=5681, Term=2, CreditID=10, Status="A"},
                    new Slot {SlotID=7, DegreePlanSelected=5681, Term=3, CreditID=618, Status="P"},
                    new Slot {SlotID=8, DegreePlanSelected=5681, Term=3, CreditID=691, Status="P"},
                    new Slot {SlotID=9, DegreePlanSelected=5681, Term=4, CreditID=692, Status="P"},
                    new Slot {SlotID=10, DegreePlanSelected=5681, Term=4, CreditID=20, Status="P"},
                    new Slot {SlotID=11, DegreePlanSelected=5681, Term=4, CreditID=555, Status="P"},
                    new Slot {SlotID=12, DegreePlanSelected=7082, Term=1, CreditID=542, Status="C"},
                    new Slot {SlotID=13, DegreePlanSelected=7082, Term=1, CreditID=563, Status="C"},
                    new Slot {SlotID=14, DegreePlanSelected=7082, Term=1, CreditID=560, Status="C"},
                    new Slot {SlotID=15, DegreePlanSelected=7082, Term=2, CreditID=664, Status="A"},
                    new Slot {SlotID=16, DegreePlanSelected=7082, Term=2, CreditID=6, Status="A"},
                    new Slot {SlotID=17, DegreePlanSelected=7082, Term=2, CreditID=10, Status="A"},
                    new Slot {SlotID=18, DegreePlanSelected=7082, Term=3, CreditID=618, Status="P"},
                    new Slot {SlotID=19, DegreePlanSelected=7082, Term=4, CreditID=691, Status="P"},
                    new Slot {SlotID=20, DegreePlanSelected=7082, Term=4, CreditID=20, Status="P"},
                    new Slot {SlotID=21, DegreePlanSelected=7082, Term=5, CreditID=692, Status="P"},
                    new Slot {SlotID=22, DegreePlanSelected=7082, Term=5, CreditID=555, Status="P"},
                    new Slot {SlotID=23, DegreePlanSelected=8973, Term=1, CreditID=542, Status="A"},
                    new Slot {SlotID=24, DegreePlanSelected=8973, Term=1, CreditID=563, Status="A"},
                    new Slot {SlotID=25, DegreePlanSelected=8973, Term=1, CreditID=560, Status="A"},
                    new Slot {SlotID=26, DegreePlanSelected=8973, Term=2, CreditID=664, Status="P"},
                    new Slot {SlotID=27, DegreePlanSelected=8973, Term=2, CreditID=6, Status="P"},
                    new Slot {SlotID=28, DegreePlanSelected=8973, Term=2, CreditID=10, Status="P"},
                    new Slot {SlotID=29, DegreePlanSelected=8973, Term=3, CreditID=20, Status="P"},
                    new Slot {SlotID=30, DegreePlanSelected=8973, Term=3, CreditID=555, Status="P"},
                    new Slot {SlotID=31, DegreePlanSelected=8973, Term=3, CreditID=691, Status="P"},
                    new Slot {SlotID=32, DegreePlanSelected=8973, Term=4, CreditID=618, Status="P"},
                    new Slot {SlotID=33, DegreePlanSelected=8973, Term=4, CreditID=692, Status="P"},

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
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm {StudentTermID=1, StudentID=533568, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermID=2, StudentID=533568, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermID=3, StudentID=533568, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermID=4, StudentID=533568, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermID=5, StudentID=533708, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermID=6, StudentID=533708, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermID=7, StudentID=533708, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermID=8, StudentID=533708, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermID=9, StudentID=533708, Term=5, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermID=10, StudentID=533897, Term=1, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermID=11, StudentID=533897, Term=2, TermAbbr="FA20", TermName="Fall 2020"},
                    new StudentTerm {StudentTermID=12, StudentID=533897, Term=3, TermAbbr="SP21", TermName="Spring 2021"},
                    new StudentTerm {StudentTermID=13, StudentID=533897, Term=4, TermAbbr="SU21", TermName="Summer 2021"},

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
