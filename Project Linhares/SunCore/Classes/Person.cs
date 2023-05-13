namespace SunCore.Classes
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual int IdFarm { get; set; }
        public virtual string BirthCountry { get; set; }
        public virtual string Name { get; set; }//Max: 50
        public virtual string LastName { get; set; }//Max: 50
        public virtual string NickName { get; set; } //Max: 50
        public virtual string Email { get; set; } //Max: 150
        public virtual string Phone { get; set; }//Max: 20
        public virtual int IdDocument { get; set; }
        public virtual string Address { get; set; }
        public virtual string Neighborhood { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Sex { get; set; }
        public virtual string Observation { get; set; }
        public virtual string Birthday { get; set; }

    } 
}
