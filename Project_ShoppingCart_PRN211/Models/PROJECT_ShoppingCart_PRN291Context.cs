using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class PROJECT_ShoppingCart_PRN291Context : DbContext
    {
        public PROJECT_ShoppingCart_PRN291Context()
        {
        }

        public PROJECT_ShoppingCart_PRN291Context(DbContextOptions<PROJECT_ShoppingCart_PRN291Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Shoe> Shoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConstr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("account_address");

                entity.Property(e => e.AccountEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_email");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("account_name");

                entity.Property(e => e.AccountPassword)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("account_password");

                entity.Property(e => e.AccountPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("account_phone");

                entity.Property(e => e.AccountRole).HasColumnName("account_role");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(30)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullname");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasColumnName("note");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TotalMoney).HasColumnName("total_money");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("Order_Details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.TotalNumber).HasColumnName("total_number");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Order_Det__order__3F466844");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Order_Det__produ__403A8C7D");
            });

            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.HasKey(e => e.ShoesId)
                    .HasName("PK__Shoes__295A7385724CFA83");

                entity.Property(e => e.ShoesId).HasColumnName("Shoes_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ShoesImage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shoes_image");

                entity.Property(e => e.ShoesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shoes_name");

                entity.Property(e => e.ShoesPrice).HasColumnName("Shoes_price");

                entity.Property(e => e.ShoesQuantity).HasColumnName("Shoes_quantity");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Shoes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Shoes__category___3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
