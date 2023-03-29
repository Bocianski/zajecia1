using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace zajecia1.Forms
{
    
    public class FizzBuzzForm
    {
        public String CheckValue (int? Number)
        {
            string value = "";
            if (Number % 3 == 0)
            {
                value = "Fizz";
                if (Number % 5 == 0)
                {
                    value += "Buzz";
                }
            }
            else if (Number % 5 == 0)
            {
                value = "Buzz";
            }
            /*if (Number % 3 == 0 && Number % 5 == 0)
            {
                value = "FizzBuzz";
            }*/
            else { return "Liczba " + Number + " nie oddaje"; };
            return value;
        }
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required, Range(1, 1000, ErrorMessage = "Podaj od 1 do 1000")]
        public int? Number { get; set; }
    }
}
