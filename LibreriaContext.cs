using Microsoft.EntityFrameworkCore;
using libreria.Models;

namespace libreria;

public class LibreriaContext: DbContext
{
    public  DbSet<Autor>? Autor {get; set;}

    public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options){}
}
