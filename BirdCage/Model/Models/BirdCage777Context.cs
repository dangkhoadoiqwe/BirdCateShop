using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.Models
{
    public partial class BirdCage777Context : DbContext
    {
        public BirdCage777Context()
        {
        }

        public BirdCage777Context(DbContextOptions<BirdCage777Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<BookingRequest> BookingRequests { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartDetail> CartDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Coursera> Courseras { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackReply> FeedbackReplies { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TrainingSchedule> TrainingSchedules { get; set; }
        public virtual DbSet<UpdateProduct> UpdateProducts { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=BirdCage777;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.HasIndex(e => e.Phone, "UQ__Account__B43B145F9756E6FF")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.AccountStatus).HasColumnName("accountStatus");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.ProfilePhoto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("profilePhoto");

                entity.Property(e => e.Role).HasColumnName("role");
            });

            modelBuilder.Entity<Bird>(entity =>
            {
                entity.ToTable("Bird");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.AvailabilityStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Available')");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Species)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Not Trained')");
            });

            modelBuilder.Entity<BookingRequest>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__BookingR__C6D03BED3816F784");

                entity.ToTable("BookingRequest");

                entity.Property(e => e.BookingId).HasColumnName("bookingID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.BirdType)
                    .HasMaxLength(255)
                    .HasColumnName("birdType");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.CusAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cusAddress");

                entity.Property(e => e.CusPhone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cusPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.MaterialCustom)
                    .HasMaxLength(255)
                    .HasColumnName("materialCustom");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .HasColumnName("size");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subtotal)
                    .HasMaxLength(255)
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.BookingRequests)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BookingRe__accou__3D5E1FD2");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.BookingRequests)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BookingRe__mater__3E52440B");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.CartId).HasColumnName("cartID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__accountID__3F466844");
            });

            modelBuilder.Entity<CartDetail>(entity =>
            {
                entity.ToTable("CartDetail");

                entity.Property(e => e.CartDetailId).HasColumnName("cartDetailID");

                entity.Property(e => e.CartId).HasColumnName("cartID");

                entity.Property(e => e.CartStatus).HasColumnName("cartStatus");

                entity.Property(e => e.PaymentId).HasColumnName("paymentID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartDetails)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetail_fk1");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.CartDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_CartDetail_Payment");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderdetail_fk2");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoriesId)
                    .HasName("PK__Category__52A97118242BC3EB");

                entity.ToTable("Category");

                entity.Property(e => e.CategoriesId).HasColumnName("categoriesID");

                entity.Property(e => e.CategoriesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("categoriesName");
            });

            modelBuilder.Entity<Coursera>(entity =>
            {
                entity.ToTable("Coursera");

                entity.Property(e => e.CourseraId).HasColumnName("CourseraID");

                entity.Property(e => e.Coserastatus).HasMaxLength(50);

                entity.Property(e => e.Describe).HasColumnName("describe");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.TimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("timeEnd");

                entity.Property(e => e.TimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("timeStart");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.Property(e => e.DeliveryId).HasColumnName("deliveryID");

                entity.Property(e => e.IntendTime)
                    .HasColumnType("date")
                    .HasColumnName("intendTime");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("feedbackID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.CartDetailId).HasColumnName("cartDetailID");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.FeedbackStatus).HasColumnName("feedbackStatus");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Account");

                entity.HasOne(d => d.CartDetail)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.CartDetailId)
                    .HasConstraintName("FK_Feedback_CartDetail");
            });

            modelBuilder.Entity<FeedbackReply>(entity =>
            {
                entity.HasKey(e => e.ReplyId)
                    .HasName("PK__feedback__36BBF6A8DC2C5BE8");

                entity.ToTable("feedback_reply");

                entity.Property(e => e.ReplyId).HasColumnName("replyID");

                entity.Property(e => e.Commentreply)
                    .HasColumnType("text")
                    .HasColumnName("commentreply");

                entity.Property(e => e.FeedbackId).HasColumnName("feedbackID");

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackReplies)
                    .HasForeignKey(d => d.FeedbackId)
                    .HasConstraintName("FK__feedback___feedb__5629CD9C");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("paymentID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.BookingId).HasColumnName("bookingID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.CusAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cusAddress");

                entity.Property(e => e.CusName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cusName");

                entity.Property(e => e.CusPhone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cusPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryId).HasColumnName("deliveryID");

                entity.Property(e => e.FeeShip).HasColumnName("feeShip");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.PaymentStatus).HasColumnName("paymentStatus");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductsPrice)
                    .HasColumnName("productsPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.VoucherId).HasColumnName("voucherID");

                entity.Property(e => e.VoucherPrice)
                    .HasColumnName("voucherPrice")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Payment__booking__44FF419A");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.DeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payment__deliver__45F365D3");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.CategoriesId).HasColumnName("categoriesID");

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .HasColumnName("color");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.MadeIn)
                    .HasMaxLength(50)
                    .HasColumnName("madeIn");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.Material)
                    .HasMaxLength(50)
                    .HasColumnName("material");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductStatus).HasColumnName("productStatus");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.HasOne(d => d.Categories)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__categor__46E78A0C");
            });

            modelBuilder.Entity<TrainingSchedule>(entity =>
            {
                entity.HasKey(e => e.TrainingId)
                    .HasName("PK__Training__E8D71DE2FA803949");

                entity.ToTable("TrainingSchedule");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.CouseraId).HasColumnName("couseraID");

                entity.Property(e => e.TrainingDate).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TrainingSchedules)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Account_TrainingSchedule");

                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.TrainingSchedules)
                    .HasForeignKey(d => d.BirdId)
                    .HasConstraintName("FK_Bird_TrainingSchedule");

                entity.HasOne(d => d.Cousera)
                    .WithMany(p => p.TrainingSchedules)
                    .HasForeignKey(d => d.CouseraId)
                    .HasConstraintName("FK_Cousera_TrainingSchedule");
            });

            modelBuilder.Entity<UpdateProduct>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PK__UpdatePr__3C748E9A27984ED6");

                entity.ToTable("UpdateProduct");

                entity.Property(e => e.UpdateId).HasColumnName("updateID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.TimeUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("timeUpdate");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UpdateProducts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UpdatePro__accou__47DBAE45");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UpdateProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_UpdateProduct_Product");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.ToTable("Voucher");

                entity.Property(e => e.VoucherId).HasColumnName("voucherID");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEnd");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("dateStart");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.VoucherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voucherName");

                entity.Property(e => e.VoucherStatus).HasColumnName("voucherStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
