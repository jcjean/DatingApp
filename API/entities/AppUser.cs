using System.ComponentModel.DataAnnotations;
namespace API.entities
{
    public class AppUser{
        public int Id{ get; set; } //identificação do usuario

        public string UserName { get; set; }
    }
}