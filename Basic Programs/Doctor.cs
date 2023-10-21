﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
   
    internal class Doctor : calulation, IDoctor,IApponiment
    {
        public int Did { get; set; } 
        public string? DName {  get; set; } 
        public void AddNewDoctor(int did,string? dname)
        {
            Did = did;
            DName = dname;
        }

        public void ModifyDoctor(int did, string? dname)
        {
            Did = did;
            DName = dname;
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine("Did :{0} \t Name : {1}",Did, DName);
        }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine("Book app for {0} with Doctor {1}",pname,did);
        }

        public void DelApp(string pname)
        {
            Console.WriteLine("cancel app for {0}{0}", pname);
        }
    }
    
    }

