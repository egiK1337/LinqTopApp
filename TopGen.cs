
namespace LinqTopApp
{
    public static class TopGen
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> data, int percent)
        {
            if (percent < 1 || percent > 100)
            {
                throw new ArgumentException("Можно вводить число в диапазоне от 1 до 100");
            }

            var count = Math.Ceiling(data.Count() * (percent / 100.0));

            if (Convert.ToInt32(count) != Convert.ToDouble(count))
            {
                count++;
            }

            var order = data.OrderByDescending(x => x);

            return order.Take((int)count);
        }

        public static IEnumerable<T> Top<T, TKey>(this IEnumerable<T> data, int percent, Func<T, TKey> fieldSelector)
        {
            if (percent < 1 || percent > 100)
            {
                throw new ArgumentException("Можно вводить число в диапазоне от 1 до 100");
            }

            var count = Math.Ceiling(data.Count() * (percent / 100.0));

            if (Convert.ToInt32(count) != Convert.ToDouble(count))
            {
                count++;
            }

            var order = data.OrderByDescending(fieldSelector);

            return order.Take((int)count);
        }
    }
}
