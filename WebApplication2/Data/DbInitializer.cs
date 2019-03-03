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

            //for Student - Mouni

            //for DegreeCredit - Malli

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
