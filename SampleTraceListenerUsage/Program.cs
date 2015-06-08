using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Diagnostics;

namespace SampleTraceListenerUsage
{
    /// <summary>
    /// <para>
    /// This simple console application is configured in the app.config to use the AWS Trace Listener. This will cause Trace.Write calls
    /// to be written to a Logs table in DynamoDB. To confirm this view the Logs table in the DynamoDB table browser.
    /// </para>
    /// <para>
    /// The application will use the default profile for credentials and the us-west-2 region. When first launched it will 
    /// create the Logs table if it doesn't exist. Be sure to delete this table when done testing to avoid charges.
    /// </para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++ )
            {
                Trace.WriteLine(string.Format("Test logging message {0}", i));
                Thread.Sleep(500);                
            }
            Trace.Flush();
        }
    }
}
