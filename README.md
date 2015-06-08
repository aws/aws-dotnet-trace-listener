# AWS DynamoDB Trace Listener

The **AWS DynamoDB Trace Listener** allows System.Diagnostics.Trace calls to be written to Amazon DynamoDB.

## Usage Information

The trace listener can be included in your project from the [NuGet][nuget-package] package. Once included the trace listener can be configured in your application's app.config or web.config.
Here is an example configuration that writes all Trace.Write calls to DynamoDB.

<pre>
&lt;system.diagnostics&gt;
  &lt;trace autoflush="true"&gt;
    &lt;listeners&gt;
      &lt;add name="dynamo" type="Amazon.TraceListener.DynamoDBTraceListener, AWS.TraceListener"
                      Region="us-west-2"
                      ExcludeAttributes="Callstack"
                      HashKeyFormat="%ComputerName%-{EventType}-{ProcessId}"
                      RangeKeyFormat="{Time}"
        /&gt;
    &lt;/listeners&gt;
  &lt;/trace&gt;    
&lt;/system.diagnostics&gt;
</pre>

Go [here](http://blogs.aws.amazon.com/net/post/Tx16NZPGUZK6LDU/DynamoDBTraceListener) for more information on using the trace listener.


## Links

* [AWS Trace Listener NuGet package][nuget-package]
* [AWS .NET Developer Blog][dotnet-blog]
* [AWS SDK for .NET GitHub Repository][github-awssdk]
* [AWS SDK for .NET SDK][sdk-website]


[nuget-package]: https://www.nuget.org/packages/AWS.TraceListener/
[github-awssdk]: https://github.com/aws/aws-sdk-net
[sdk-website]: http://aws.amazon.com/sdkfornet
[dotnet-blog]: http://blogs.aws.amazon.com/net/
