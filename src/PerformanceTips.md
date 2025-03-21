# Performance

## sql in debug window
- we can see the sql statements entity framework generates

## Change tracking
Entity framework creates a snapshot in memory of query or changes and later written to database.\
In Readonly scenarios, we can skip the snapshot amd use system resources\
**Disable Change Tracking for readonly scenarios**

Add AsNoTracking() method
````cs

var products = context.Products
             .Where(p => p.Price > 10.00M)
             .AsNoTracking()
             .OrderBy(p => p.Name);

````
## Eager loading
- Use .Include(c=>c.orders)
- When eager loading one to many datasets, EF uses left join and gets entire dataset in one query
so, for every record in the left table there will be duplicates in the right table, it is called
cartesian explosion and can be mitigated a feature called split queries
````cs
var products = context.Products
            .Include(c=>c.orders)
             .Where(p => p.Price > 10.00M)             
             .OrderBy(p => p.Name);
````

````cs
// Eager loading With split query
var products = context.Products
            .Include(c=>c.orders)
             .Where(p => p.Price > 10.00M)
             .AsNoTracking()
             .OrderBy(p => p.Name);
````

## Lazy loading
Install Microsoft.EntityFrameworkCore.Proxies
````cs
// In startup configuration
   options.UseLazyLoadingProxies()

// In Entities
  public virtual ICollection<Order> orders { get; set; }
````

## Use custom SQL
EF will parameterize SQL statements to prevent injection attacks
````cs
var products = context.Products
            .FromSqlInterpolated($"Select * from products where id = {productId}")             
            .OrderBy(p => p.Name);
````

## FindAsync to get from snapshot(Cache)
````cs
var products = context.Products
            .FindAsync(id);
            
````

## DatabaseContext overhead for creating and destroying objects
We can reuse database Context by using database Context pooling 

````cs
builder.Services.AddDbContextPool()        
````

## Create indexes using index attribute

````cs
[Index(nameof(Url))]
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}     
````



