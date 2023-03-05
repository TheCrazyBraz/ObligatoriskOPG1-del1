using System.Xml.Linq;
using System.Xml.Schema;

namespace ObligatoriskOPG1
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? Plate { get; set; }

        public void ValidateCarModel()
        {
            if (Model == null)
            {
                throw new ArgumentNullException("Model is NULL, please enter Model name.");
            }
            if (Model.Length < 4)
            {
                throw new ArgumentException("Model must be at least 4 characters long. Your model name attempt: " + Model);
            }

        }
        public void ValidatePrice()
        {
            if (Price <= 0)
            {
                throw new ArgumentException("Price cant be negative or 0, your price: " + Price);
            }
        }
        public void ValidatePlate()
        {
            if (Plate == null)
            {
                throw new ArgumentNullException("Plate is NULL, please enter Plate ID.");
            }
            if (Plate.Length< 2 || Plate.Length > 7)
            {
                throw new ArgumentException("Plate must be between 2 and 7 characters, your plate: " + Plate);
            }
           
        }
        public void Validate()
        {
            ValidateCarModel();
            ValidatePrice();
            ValidatePlate();
        }
        public override string ToString()
        {
            return "ID: " + Id + ", Model: " + Model + ", Price: " + Price + ", Plate: " + Plate;
        }
    }

}