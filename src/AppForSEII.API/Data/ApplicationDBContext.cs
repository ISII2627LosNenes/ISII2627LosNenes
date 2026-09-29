using AppForSEII.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppForSEII.API.DTOs.ApplicationUserDTO;

namespace AppForSEII.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);


    }


    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public DbSet<Resena> Resena{get;set;}
    public DbSet<Subasta> Subastas{get;set;}

    public DbSet<Compra> Compra{get;set;}
    public DbSet<Reposicion> Reposicion{get;set;}

    public DbSet<CompraItem> CompraItem{get;set;}


    public DbSet<Editorial> Editorial{get;set;}

    public DbSet<MetodoPago> MetodoPago{get;set;}
    public DbSet<Libro> Libro{get;set;}
    public DbSet<Visa> Visa{get;set;}

    public DbSet<Genero> Genero{get;set;}

    public DbSet<ResenaItem> ResenaItem{get;set;}
    public DbSet<GooglePay> GooglePay{get;set;}
}