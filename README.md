# Object-Creation-Performance-Comparison

I had one of my peers question my habit of using Activator.CreateInstance<T>().  To see where things are at when using .Net 5, I wrote up a quick app to compare different object creation models.

Below are the results on my work issued laptop.
---

Activator 1,000 => 00:00:00.0090217
New       1,000 => 00:00:00.0000581
Activator 10,000 => 00:00:00.0005771
New       10,000 => 00:00:00.0002890
Activator 100,000 => 00:00:00.0071593
New       100,000 => 00:00:00.0018757
Activator 1,000,000 => 00:00:00.0508704
New       1,000,000 => 00:00:00.0168309
Activator 10,000,000 => 00:00:00.7260828
New       10,000,000 => 00:00:00.2147767
Activator 100,000,000 => 00:00:05.2054630
New       100,000,000 => 00:00:01.4583150
