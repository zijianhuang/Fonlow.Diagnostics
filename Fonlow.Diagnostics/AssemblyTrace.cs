using System;
using System.Diagnostics;

namespace Fonlow.Diagnostics
{
    /// <summary>
    /// Output trace info using a TraceSource object named after the calling asseembly
    /// </summary>
    public static class AssemblyTrace
    {
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceWarning(string message)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Warning, 0, message);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceWarning(string format, params object[] args)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Warning, 0, format, args);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceError(string message)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Error, 0, message);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceError(string format, params object[] args)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Error, 0, format, args);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceInformation(string format, params object[] args)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceInformation(format, args);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceInformation(string message)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceInformation(message);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void WriteLine(string message)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Verbose, 0, message);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void WriteLine(string format, params object[] args)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(TraceEventType.Verbose, 0, format, args);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceData(TraceEventType eventType, int id, params object[] data)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceData(eventType, id, data);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceData(TraceEventType eventType, int id, object data)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceData(eventType, id, data);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceEvent(TraceEventType eventType, int id)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(eventType, id);
        }


        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceEvent(TraceEventType eventType, int id, string message)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(eventType, id, message);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceEvent(TraceEventType eventType, int id, string format, params object[] args)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceEvent(eventType, id, format, args);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void TraceTransfer(int id, string message, Guid relatedActivityId)
        {
            var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            TraceSources.Instance.GetTraceSource(assemblyName).TraceTransfer(id, message, relatedActivityId);
        }



        public static SourceSwitch Switch
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
                return TraceSources.Instance.GetTraceSource(assemblyName).Switch;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
                TraceSources.Instance.GetTraceSource(assemblyName).Switch = value;
            }
        }

        public static TraceListenerCollection Listeners
        {
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                var assemblyName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
                return TraceSources.Instance.GetTraceSource(assemblyName).Listeners;
            }
        }
    }



}
