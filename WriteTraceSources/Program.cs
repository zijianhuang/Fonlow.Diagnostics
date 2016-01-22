using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fonlow.Diagnostics;
using System.Diagnostics;

namespace WriteTraceSources
{
    class Program
    {
        static void Main(string[] args)
        {

            //var mySource = new System.Diagnostics.TraceSource("MySource");
            //mySource.TraceWarning("MySource is quite OK");

            TraceSources.Instance["MySource"].TraceWarning("MyTrace Warning is OK");

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 200; i++)
            {
                AssemblyTrace.TraceWarning("I would WriteSomething");
                AssemblyTrace.TraceInformation("I would WriteSomething");
                AssemblyTrace.WriteLine("I would be OK");
                AssemblyTrace.TraceError("error error");
                AssemblyTrace.WriteLine("hahahaha");
            }


            //for (int i = 0; i < 500; i++)
            //{
            //    MyAppTraceSources.Logic1Source.TraceWarning("Logic1 warning.");
            //    MyAppTraceSources.Logic1Source.TraceError("Logic1 error.");
            //}


            stopwatch.Stop();
            Trace.TraceInformation("1000 calls takes: " + stopwatch.Elapsed);

        }
    }


    public static class MyAppTraceSources
    {
        public static TraceSource Source(string name)
        {
            return TraceSources.Instance.GetTraceSource(name);
        }

        public static TraceSource Logic1Source
        {
            get
            {
                return TraceSources.Instance.GetTraceSource("Logic1");
            }
        }

        public static TraceSource Logic2Source
        {
            get
            {
                return TraceSources.Instance.GetTraceSource("Logic2");
            }
        }


    }
}
