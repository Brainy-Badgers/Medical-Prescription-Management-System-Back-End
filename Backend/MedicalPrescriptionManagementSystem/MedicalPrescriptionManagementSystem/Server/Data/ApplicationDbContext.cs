using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MedicalPrescriptionManagementSystem.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalPrescriptionManagementSystem.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Pharmacist> Pharmacists { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    var userId = _httpContextAccessor.HttpContext?.User.FindFirst("ClaimUserId")?.Value;

        //    var currentUsername = !string.IsNullOrEmpty(userId)
        //        ? userId
        //        : "Anonymous";
        //    foreach (var entry in ChangeTracker.Entries<IAuditable>())
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.CreatedBy = currentUsername;
        //                entry.Entity.CreatedOn = DateTime.UtcNow;
        //                break;

        //            case EntityState.Modified:
        //                entry.Entity.UpdatedBy = currentUsername;
        //                entry.Entity.UpdatedOn = DateTime.UtcNow;
        //                break;
        //        }
        //    }

        //    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        //    return result;
        //}

        //public override int SaveChanges()
        //{
        //    return SaveChangesAsync().GetAwaiter().GetResult();
        //}

    }
}
