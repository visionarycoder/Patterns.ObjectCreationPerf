using System.Diagnostics;
using QueryableExpressions.Client.Filtering;
using Shared.Data.Base;

namespace QueryableExpressions.Client.Helpers
{
    public static class EntityRunner
    {
        private static readonly Stopwatch stopwatch = new Stopwatch();
        private static readonly Random random = new Random();

        public static TimeSpan RunEntity<T>(List<T> data, ApplyFilterDelegate<T> applyFilter) where T : Entity
        {
            var (query, ids) = GetEntityData(data);
            stopwatch.Reset();
            foreach (var _ in Enumerable.Range(0, data.Count))
            {
                var id = random.Next(0, ids.Count);
                var filter = new Filter<T>((nameof(Entity.Id), id));
                stopwatch.Start();
                applyFilter(query, filter, true);
                stopwatch.Stop();
            }
            return stopwatch.Elapsed;
        }

        public static (IQueryable<T> query, List<int> ids) GetEntityData<T>(List<T> data) where T : Entity
        {
            var ids = data.Select(x => x.Id).ToList();
            var query = data.AsQueryable();
            return (query, ids);
        }
    }
}
