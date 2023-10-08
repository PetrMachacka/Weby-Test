using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace RazorPagesRecap.InputModels
{

    /*< label ></ label >< input placeholder="křestní" />
    <label></label><input placeholder = "Přijmení" />
    < label ></ label >< input placeholder="Email" />
    <label></label><input placeholder = "ano" />
    < label ></ label >< input placeholder="" />
    <label></label><input placeholder = "" />
    < label ></ label >< input placeholder="Oslovení" />
    <label></label><input placeholder = "Příběh" />
    < button type="submit">Registrovat</button>
    <button type = "submit" > Odeslat </ button >*/

    public class Validation
    {
        [Required]
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public bool IsFifteen { get; set; }
        public Home Home { get; set; }
        public Gendre Gendre { get; set; }

        [Display(Name = "Pronouns")]
        public string? Pronouns { get; set; }
        [Required]
        [MinLength(30, ErrorMessage = "Min Length is 30 Characters")]
        public string Description { get; set; }

    }
    public enum Home
    {
        [Display(Name = "Splzov")]
        Splzov = 1,
        [Display(Name = "Pěnčín")]
        Pencin = 2,
        [Display(Name = "Liberec")]
        Liberec = 3
    }
    public enum Gendre
    {
        [Display(Name = "Muž")]
        Man = 0,
        [Display(Name = "Žena")]
        Woman = 1,
        [Display(Name = "Cosi")]
        Other = 3
    }
}