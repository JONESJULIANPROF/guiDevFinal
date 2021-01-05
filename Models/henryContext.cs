using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FianlGUI.Models
{
    public partial class henryContext : DbContext
    {
        public henryContext()
        {
        }

        public henryContext(DbContextOptions<henryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Authorview> Authorview { get; set; }
        public virtual DbSet<Authorview1> Authorview1 { get; set; }
        public virtual DbSet<Authorview2> Authorview2 { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Bookview1> Bookview1 { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Copy> Copy { get; set; }
        public virtual DbSet<FatTrack> FatTrack { get; set; }
        public virtual DbSet<Foodl> Foodl { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Salestaxview> Salestaxview { get; set; }
        public virtual DbSet<Tyler> Tyler { get; set; }
        public virtual DbSet<Wrote> Wrote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:brianserver.database.windows.net,1433;Initial Catalog=henry;Persist Security Info=False;User ID=Syd;Password=Sddse33www;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorNum)
                    .HasName("PK__Author__7E6BD29CED9B54FF");

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.AuthorFirst)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorLast)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Authorview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authorview");

                entity.Property(e => e.Authorfirst)
                    .HasColumnName("authorfirst")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authorlast)
                    .HasColumnName("authorlast")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authornum)
                    .HasColumnName("authornum")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<Authorview1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authorview1");

                entity.Property(e => e.Authorfirst)
                    .HasColumnName("authorfirst")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authorlast)
                    .HasColumnName("authorlast")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authornum)
                    .HasColumnName("authornum")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Authorview2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authorview2");

                entity.Property(e => e.Authorfirst)
                    .HasColumnName("authorfirst")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authorlast)
                    .HasColumnName("authorlast")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("PK__Book__0A5FFCC60F537E1E");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Paperback)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bookview1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bookview1");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("numeric(11, 4)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchNum)
                    .HasName("PK__Branch__0E8D21C5A67FFC47");

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Copy>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.BranchNum, e.CopyNum })
                    .HasName("PK__Copy__3462780CC2EE123A");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CopyNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Quality)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FatTrack>(entity =>
            {
                entity.HasKey(e => e.ProfileNum)
                    .HasName("PK__FatTrack__BA8D8F929DC19610");

                entity.Property(e => e.ProfileNum).ValueGeneratedNever();

                entity.Property(e => e.ActivityLevel)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FirstN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastN)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Foodl>(entity =>
            {
                entity.HasKey(e => e.Food)
                    .HasName("PK__Foodl__386D084F9CD4FA1D");

                entity.Property(e => e.Food)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cheatcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cheattitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Game)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Logins>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Accesslevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passwords)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PublisherCode)
                    .HasName("PK__Publishe__DFB88E284D6D6D97");

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Salestaxview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("salestaxview");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SalesTax)
                    .HasColumnName("salesTax")
                    .HasColumnType("numeric(11, 4)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tyler>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Tyler__049E3A89C875D191");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Weekday)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wrote>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.AuthorNum })
                    .HasName("PK__Wrote__DDB941EFE8E385E5");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sequence).HasColumnType("decimal(2, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
