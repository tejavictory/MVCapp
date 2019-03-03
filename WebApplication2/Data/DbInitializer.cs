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

            //for DegreeCredit - Malli

            //for DegreePlan - Mouni 

            //for Student - Mouni

            //for Slot - TEJA

            //for StudentTerm - TEJA
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm {StudentTermID=1, StudentId=533568, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermID=2, StudentId=533568, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermID=3, StudentId=533568, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermID=4, StudentId=533568, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermID=5, StudentId=533708, Term=1, TermAbbr="F18", TermName="Fall 2018"},
                    new StudentTerm {StudentTermID=6, StudentId=533708, Term=2, TermAbbr="SP19", TermName="Spring 2019"},
                    new StudentTerm {StudentTermID=7, StudentId=533708, Term=3, TermAbbr="SU19", TermName="Summer 2019"},
                    new StudentTerm {StudentTermID=8, StudentId=533708, Term=4, TermAbbr="F19", TermName="Fall 2019"},
                    new StudentTerm {StudentTermID=9, StudentId=533708, Term=5, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermID=10, StudentId=533897, Term=1, TermAbbr="SP20", TermName="Spring 2020"},
                    new StudentTerm {StudentTermID=11, StudentId=533897, Term=2, TermAbbr="FA20", TermName="Fall 2020"},
                    new StudentTerm {StudentTermID=12, StudentId=533897, Term=3, TermAbbr="SP21", TermName="Spring 2021"},
                    new StudentTerm {StudentTermID=13, StudentId=533897, Term=4, TermAbbr="SU21", TermName="Summer 2021"},

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
