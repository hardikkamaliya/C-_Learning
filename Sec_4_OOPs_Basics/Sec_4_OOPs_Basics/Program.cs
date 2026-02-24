using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_4_OOPs_Basics
{
     class  Program
    {
        static void Main()
        {
            //====== Undestanding OOPS ==================


            //--> OOPs : Programming Model for Scalable Application

            //--> Used in most popular language such as Java,Python, Javascript and C++.
            //--> Object : Any real world entity, Instance of class e.g swift, Honda City, Dustor
            //--> Class : Blue print of All Object e.g, Car
            //--> Method : Collection of statement to perform certain opration. Method should be member (part) of class
            //--> Fileds : 

            //========== Creating classes and Objects ===========



            //--> internal class test1 { }   - Class access withing same assembly (Project / One Solution contain more than one project)
            //--> public class test2{ }  - Class acces withing within same assemly and aslo in others asssemlies.


            //#Class syntax : 

            //acesessModifier Modifier class {

            //acesessModifier = internal(default), public
            //Modifier = static, abstract, sealed, partial

            //    Fields
            //    Methods
            //    Constructors
            //    Properties - set and get value from private fields
            //    Events
            //    Destructors

            //}

            // DDL file - Dynamic Link Library

            //Class1 Class1 = new Class1();     - public class of other prject access here but internal class not

            // Creating Object : 
            // 1) Creating Reference Valriables
            // 2) Create Object and Store its reference into the Reference Variable


            //Customer c1, c2; // referece variables

            //c1 = new Customer(); //Object
            //c2 = new Customer();//Object
        }

    }
}
