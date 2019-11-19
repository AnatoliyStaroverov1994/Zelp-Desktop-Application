﻿namespace Team7GUI.Information
{
    public class Business : BaseInfo
    {
        public string Businessid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public double Stars { get; set; }
        public int Reviewcount { get; set; }
        public int Numcheckins { get; set; }
        public double Reviewrating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distance { get; set; }
        public System.Collections.Generic.List<BusinessHours> Hours { get; set; }

        public string Fulladdress => Address + "\n" + City + ", " + State + " " + Zipcode;

        public Business()
        {
        }

        /// <summary>
        /// What to show when used as a Data Binding without having to specify a displaymemberpath
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Name}, {Address}";
        }
    }
}