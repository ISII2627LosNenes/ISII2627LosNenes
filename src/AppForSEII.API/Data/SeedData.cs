namespace AppForSEII.API.Data {
    public class SeedData {
        public static void Initialize(ApplicationDbContext dbContext, IServiceProvider serviceProvider, ILogger logger) {
            List<string> rolesNames = new List<string> { "Administrator", "Employee", "Customer" };

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            try {
                SeedRoles(roleManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the roles in the Database.");
            }

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            try {
                SeedUsers(userManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Users in the Database.");
            }

            try {
                SeedGenerosEditorialesYLibros(dbContext);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Books, Genres and Editorials in the Database.");
            }

 

        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager, List<string> roles) {

            foreach (string roleName in roles) {
                //it checks such role does not exist in the database 
                if (!roleManager.RoleExistsAsync(roleName).Result) {
                    IdentityRole role = new IdentityRole();
                    role.Name = roleName;
                    role.NormalizedName = roleName;
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                }
            }

        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager, List<string> roles) {
            //first, it checks the user does not already exist in the DB
            if (userManager.FindByNameAsync("elena@uclm.es").Result == null) {
                ApplicationUser user = new ApplicationUser("1", "Elena", "Navarro Martínez", "elena@uclm.es");
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "Password1234%");
                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //administrator role
                    userManager.AddToRoleAsync(user, roles[0]).Wait();
                }
            }


            if (userManager.FindByNameAsync("peter@uclm.es").Result == null) {
                //A customer class has been defined because it has different attributes (purchase, rental, etc.)
                ApplicationUser user = new ApplicationUser("3", "Peter", "Jackson", "peter@uclm.es");
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "OtherPass12$");

                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //customer role
                    userManager.AddToRoleAsync(user, roles[2]).Wait();

                }
            }

        }

         public static void SeedGenerosEditorialesYLibros(ApplicationDbContext dbcontext) {
            string[] nombresGeneros = { "Ciencia Ficción", "Fantasía", "Novela Histórica", "Terror" };
            List<Genero> generos = new List<Genero>();

            foreach (string nombre in nombresGeneros) {
                var genero = dbcontext.Genero.FirstOrDefault(g => g.Nombre == nombre);
                if (genero == null) {
                    genero = new Genero { Nombre = nombre };
                    dbcontext.Genero.Add(genero);
                }
                generos.Add(genero);
            }

            string[] nombresEditoriales = { "Minotauro", "Nova", "Alianza Editorial" };
            List<Editorial> editoriales = new List<Editorial>();

            foreach (string nombre in nombresEditoriales) {
                var editorial = dbcontext.Editorial.FirstOrDefault(e => e.Nombre == nombre);
                if (editorial == null) {
                    editorial = new Editorial { Nombre = nombre };
                    dbcontext.Editorial.Add(editorial);
                }
                editoriales.Add(editorial);
            }

            dbcontext.SaveChanges();

            if (dbcontext.Libro.FirstOrDefault(l => l.Titulo == "Dune") == null) {
                var libro1 = new Libro {
                    Titulo = "Dune",
                    TipoLibro = "Tapa Blanda",
                    Autor = "Frank Herbert",
                    CalificacionMedia = 5,
                    FechaLanzamiento = new DateTime(1965, 8, 1),
                    PrecioCompra = 19.99m,
                    Stock = 50,
                    GeneroId = generos[0].Id,    
                    EditorialId = editoriales[1].Id 
                };
                dbcontext.Libro.Add(libro1);
            }
            if (dbcontext.Libro.FirstOrDefault(l => l.Titulo == "El Señor de los Anillos") == null) {
                var libro2 = new Libro {
                    Titulo = "El Señor de los Anillos",
                    TipoLibro = "Tapa Dura",
                    Autor = "J.R.R. Tolkien",
                    CalificacionMedia = 5,
                    FechaLanzamiento = new DateTime(1954, 7, 29),
                    PrecioCompra = 35.50m,
                    Stock = 25,
                    GeneroId = generos[1].Id,    
                    EditorialId = editoriales[0].Id 
                };
                dbcontext.Libro.Add(libro2);
            }

            dbcontext.SaveChanges();
        }



    }
}