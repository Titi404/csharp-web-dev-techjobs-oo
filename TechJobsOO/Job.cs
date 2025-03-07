﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;


        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType employerPositionType, CoreCompetency employerCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = employerPositionType;
            JobCoreCompetency = employerCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            if (Name == "" || Name == null)
            {
                return "Oopz";
            }
            else
            {
                if (EmployerName.Value == "" || EmployerName.Value == null)
                {
                    EmployerName.Value = "Data not available";
                }
                if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
                {
                    EmployerLocation.Value = "Data not available";
                }
                if (JobType.Value == "" || JobType.Value == null)
                {
                    JobType.Value = "Data not available";
                }
                if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
                {
                    JobCoreCompetency.Value = "Data not available";
                }


                return $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}\n";
            }
        }
    }
}
