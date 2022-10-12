using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contexts.Ef;

public partial class AppDbContext
{
    private void OnBeforeSaving()
    {
        var entries = ChangeTracker.Entries();
        foreach (var entry in entries)
        {
            switch (entry.Entity)
            {
                case BaseEntity tractable:
                    {
                        var now = DateTime.Now;
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                tractable.CreateDate = now;
                                tractable.UpdateDate = now;
                                tractable.CreateBy = 1; //1
                                tractable.IsActive = true;
                                tractable.RowGuid = Guid.NewGuid();
                                break;

                            case EntityState.Modified:
                                tractable.UpdateDate = now;
                                tractable.UpdateBy = 1;//1
                                break;

                            case EntityState.Detached:
                            case EntityState.Unchanged:
                            case EntityState.Deleted:
                                tractable.IsActive = false;
                                tractable.UpdateDate = now;
                                tractable.UpdateBy = 1;//1
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                        break;
                    }
            }
        }
    }

    public override int SaveChanges()
    {
        OnBeforeSaving();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        OnBeforeSaving();
        return base.SaveChangesAsync(cancellationToken);
    }
}