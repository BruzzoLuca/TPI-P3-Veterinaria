using Domain.Entities;


namespace Domain.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        //public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }

}

