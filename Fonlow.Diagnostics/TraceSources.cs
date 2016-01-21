using System.Diagnostics;
using System.Collections.Concurrent;

namespace Fonlow.Diagnostics
{
    /// <summary>
    /// Store a dictionary of TraceSource objects created through lazy loading.
    /// </summary>
    public class TraceSources
    {
        ConcurrentDictionary<string, TraceSource> dic;

        TraceSources()
        {
            dic = new ConcurrentDictionary<string, TraceSource>();
        }

        /// <summary>
        /// Create a TraceSource in lazy way.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TraceSource GetTraceSource(string name)
        {
            TraceSource r;
            if (dic.TryGetValue(name, out r))
                return r;

            r = new TraceSource(name);
            dic.TryAdd(name, r);
            return r;
        }

        /// <summary>
        /// Access a TraceSource object by name. A named TraceSource object will be created the first time when being looked up.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TraceSource this[string name]
        {
            get
            {
                return GetTraceSource(name);
            }
        }

        public static TraceSources Instance { get { return Nested.instance; } }

        private static class Nested
        {
            static Nested()
            {
            }

            internal static readonly TraceSources instance = new TraceSources();
        }
    }


}
