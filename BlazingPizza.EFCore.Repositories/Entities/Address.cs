﻿namespace BlazingPizza.EFCore.Repositories.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostaCode { get; set; }
    }
}
