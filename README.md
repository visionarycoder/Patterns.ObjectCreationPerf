# Object Creation Performance Comparison

I had one of my peers question my habit of using Activator.CreateInstance<T>().  To see where things are at when using .Net 8, I wrote up a quick app to compare different object creation models.

Below are the results on my work issued laptop.
  
## Results

| Method    | Item Count    | Duration        | 
|-----------|---------------:|-----------------:|
| Activator |         1,000 | 00:00:00.0340841|
| New       |         1,000 | 00:00:00.0000697|
| Activator |        10,000 | 00:00:00.0007947|
| New       |        10,000 | 00:00:00.0003254|
| Activator |       100,000 | 00:00:00.0080820|
| New       |       100,000 | 00:00:00.0027301|
| Activator |     1,000,000 | 00:00:00.0685592|
| New       |     1,000,000 | 00:00:00.0192263|
| Activator |    10,000,000 | 00:00:00.6308889|
| New       |    10,000,000 | 00:00:00.2084718|
| Activator |   100,000,000 | 00:00:04.9240035|
| New       |   100,000,000 | 00:00:01.3337685|
| Activator | 1,000,000,000 | 00:00:17.6138075|
| New       | 1,000,000,000 | 00:00:11.7923033|

## Summary

| Count         | Ratio  | Faster Method |
|---------------:|--------|---------------|
|         1,000 |  0.002 | New           |
|        10,000 |  0.409 | New           |
|       100,000 |  0.338 | New           |
|     1,000,000 |  0.280 | New           |
|    10,000,000 |  0.330 | New           |
|   100,000,000 |  0.271 | New           |
| 1,000,000,000 |  0.669 | New           |


## ChangeLog:
Upgraded to .Net 8

Added 1,000,000,000 item count

Added Summary