namespace QueryableExpressions.Client.Filtering;

public delegate IQueryable<T> ApplyFilterDelegate<T>(IQueryable<T> query, Filter<T> filter, bool caseInsensitive) where T : class;