using QueryableExpressions.Client.Filtering;

using Shared.Objects.Base;

using System.Diagnostics;

namespace QueryableExpressions.Client.Helpers
{
    public static class ObjectHelper
    {

        private static readonly Stopwatch stopwatch = new();
        private static readonly Random random = new();

        public static TimeSpan RunObject<T>(List<T> data, ApplyFilterDelegate<T> applyFilter) where T : ObjectBase
        {
            var (query, ids) = GetObjectData(data);
            stopwatch.Reset();
            foreach (var _ in Enumerable.Range(0, data.Count))
            {
                var id = random.Next(0, ids.Count);
                var filter = new Filter<T>((nameof(ObjectBase.Id), id));
                stopwatch.Start();
                applyFilter(query, filter, true);
                stopwatch.Stop();
            }
            return stopwatch.Elapsed;
        }

        public static (IQueryable<T> query, List<int> ids) GetObjectData<T>(List<T> data) where T : ObjectBase
        {
            var ids = data.Select(x => x.Id).ToList();
            var query = data.AsQueryable();
            return (query, ids);
        }
    }
}

