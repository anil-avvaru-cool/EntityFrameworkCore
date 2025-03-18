# Performance

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

