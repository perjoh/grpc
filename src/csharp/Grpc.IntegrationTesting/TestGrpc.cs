// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: test.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace grpc.testing {
  public static class TestService
  {
    static readonly string __ServiceName = "grpc.testing.TestService";

    static readonly Marshaller<global::grpc.testing.Empty> __Marshaller_Empty = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.Empty.ParseFrom);
    static readonly Marshaller<global::grpc.testing.SimpleRequest> __Marshaller_SimpleRequest = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.SimpleRequest.ParseFrom);
    static readonly Marshaller<global::grpc.testing.SimpleResponse> __Marshaller_SimpleResponse = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.SimpleResponse.ParseFrom);
    static readonly Marshaller<global::grpc.testing.StreamingOutputCallRequest> __Marshaller_StreamingOutputCallRequest = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.StreamingOutputCallRequest.ParseFrom);
    static readonly Marshaller<global::grpc.testing.StreamingOutputCallResponse> __Marshaller_StreamingOutputCallResponse = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.StreamingOutputCallResponse.ParseFrom);
    static readonly Marshaller<global::grpc.testing.StreamingInputCallRequest> __Marshaller_StreamingInputCallRequest = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.StreamingInputCallRequest.ParseFrom);
    static readonly Marshaller<global::grpc.testing.StreamingInputCallResponse> __Marshaller_StreamingInputCallResponse = Marshallers.Create((arg) => arg.ToByteArray(), global::grpc.testing.StreamingInputCallResponse.ParseFrom);

    static readonly Method<global::grpc.testing.Empty, global::grpc.testing.Empty> __Method_EmptyCall = new Method<global::grpc.testing.Empty, global::grpc.testing.Empty>(
        MethodType.Unary,
        __ServiceName,
        "EmptyCall",
        __Marshaller_Empty,
        __Marshaller_Empty);

    static readonly Method<global::grpc.testing.SimpleRequest, global::grpc.testing.SimpleResponse> __Method_UnaryCall = new Method<global::grpc.testing.SimpleRequest, global::grpc.testing.SimpleResponse>(
        MethodType.Unary,
        __ServiceName,
        "UnaryCall",
        __Marshaller_SimpleRequest,
        __Marshaller_SimpleResponse);

    static readonly Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> __Method_StreamingOutputCall = new Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse>(
        MethodType.ServerStreaming,
        __ServiceName,
        "StreamingOutputCall",
        __Marshaller_StreamingOutputCallRequest,
        __Marshaller_StreamingOutputCallResponse);

    static readonly Method<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse> __Method_StreamingInputCall = new Method<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse>(
        MethodType.ClientStreaming,
        __ServiceName,
        "StreamingInputCall",
        __Marshaller_StreamingInputCallRequest,
        __Marshaller_StreamingInputCallResponse);

    static readonly Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> __Method_FullDuplexCall = new Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "FullDuplexCall",
        __Marshaller_StreamingOutputCallRequest,
        __Marshaller_StreamingOutputCallResponse);

    static readonly Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> __Method_HalfDuplexCall = new Method<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "HalfDuplexCall",
        __Marshaller_StreamingOutputCallRequest,
        __Marshaller_StreamingOutputCallResponse);

    // client interface
    public interface ITestServiceClient
    {
      global::grpc.testing.Empty EmptyCall(global::grpc.testing.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::grpc.testing.Empty EmptyCall(global::grpc.testing.Empty request, CallOptions options);
      AsyncUnaryCall<global::grpc.testing.Empty> EmptyCallAsync(global::grpc.testing.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::grpc.testing.Empty> EmptyCallAsync(global::grpc.testing.Empty request, CallOptions options);
      global::grpc.testing.SimpleResponse UnaryCall(global::grpc.testing.SimpleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::grpc.testing.SimpleResponse UnaryCall(global::grpc.testing.SimpleRequest request, CallOptions options);
      AsyncUnaryCall<global::grpc.testing.SimpleResponse> UnaryCallAsync(global::grpc.testing.SimpleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::grpc.testing.SimpleResponse> UnaryCallAsync(global::grpc.testing.SimpleRequest request, CallOptions options);
      AsyncServerStreamingCall<global::grpc.testing.StreamingOutputCallResponse> StreamingOutputCall(global::grpc.testing.StreamingOutputCallRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncServerStreamingCall<global::grpc.testing.StreamingOutputCallResponse> StreamingOutputCall(global::grpc.testing.StreamingOutputCallRequest request, CallOptions options);
      AsyncClientStreamingCall<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse> StreamingInputCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncClientStreamingCall<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse> StreamingInputCall(CallOptions options);
      AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> FullDuplexCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> FullDuplexCall(CallOptions options);
      AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> HalfDuplexCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> HalfDuplexCall(CallOptions options);
    }

    // server-side interface
    public interface ITestService
    {
      Task<global::grpc.testing.Empty> EmptyCall(global::grpc.testing.Empty request, ServerCallContext context);
      Task<global::grpc.testing.SimpleResponse> UnaryCall(global::grpc.testing.SimpleRequest request, ServerCallContext context);
      Task StreamingOutputCall(global::grpc.testing.StreamingOutputCallRequest request, IServerStreamWriter<global::grpc.testing.StreamingOutputCallResponse> responseStream, ServerCallContext context);
      Task<global::grpc.testing.StreamingInputCallResponse> StreamingInputCall(IAsyncStreamReader<global::grpc.testing.StreamingInputCallRequest> requestStream, ServerCallContext context);
      Task FullDuplexCall(IAsyncStreamReader<global::grpc.testing.StreamingOutputCallRequest> requestStream, IServerStreamWriter<global::grpc.testing.StreamingOutputCallResponse> responseStream, ServerCallContext context);
      Task HalfDuplexCall(IAsyncStreamReader<global::grpc.testing.StreamingOutputCallRequest> requestStream, IServerStreamWriter<global::grpc.testing.StreamingOutputCallResponse> responseStream, ServerCallContext context);
    }

    // client stub
    public class TestServiceClient : ClientBase, ITestServiceClient
    {
      public TestServiceClient(Channel channel) : base(channel)
      {
      }
      public global::grpc.testing.Empty EmptyCall(global::grpc.testing.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_EmptyCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::grpc.testing.Empty EmptyCall(global::grpc.testing.Empty request, CallOptions options)
      {
        var call = CreateCall(__Method_EmptyCall, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::grpc.testing.Empty> EmptyCallAsync(global::grpc.testing.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_EmptyCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::grpc.testing.Empty> EmptyCallAsync(global::grpc.testing.Empty request, CallOptions options)
      {
        var call = CreateCall(__Method_EmptyCall, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::grpc.testing.SimpleResponse UnaryCall(global::grpc.testing.SimpleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_UnaryCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::grpc.testing.SimpleResponse UnaryCall(global::grpc.testing.SimpleRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_UnaryCall, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::grpc.testing.SimpleResponse> UnaryCallAsync(global::grpc.testing.SimpleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_UnaryCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::grpc.testing.SimpleResponse> UnaryCallAsync(global::grpc.testing.SimpleRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_UnaryCall, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncServerStreamingCall<global::grpc.testing.StreamingOutputCallResponse> StreamingOutputCall(global::grpc.testing.StreamingOutputCallRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_StreamingOutputCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public AsyncServerStreamingCall<global::grpc.testing.StreamingOutputCallResponse> StreamingOutputCall(global::grpc.testing.StreamingOutputCallRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_StreamingOutputCall, options);
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public AsyncClientStreamingCall<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse> StreamingInputCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_StreamingInputCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncClientStreamingCall(call);
      }
      public AsyncClientStreamingCall<global::grpc.testing.StreamingInputCallRequest, global::grpc.testing.StreamingInputCallResponse> StreamingInputCall(CallOptions options)
      {
        var call = CreateCall(__Method_StreamingInputCall, options);
        return Calls.AsyncClientStreamingCall(call);
      }
      public AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> FullDuplexCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_FullDuplexCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncDuplexStreamingCall(call);
      }
      public AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> FullDuplexCall(CallOptions options)
      {
        var call = CreateCall(__Method_FullDuplexCall, options);
        return Calls.AsyncDuplexStreamingCall(call);
      }
      public AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> HalfDuplexCall(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_HalfDuplexCall, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncDuplexStreamingCall(call);
      }
      public AsyncDuplexStreamingCall<global::grpc.testing.StreamingOutputCallRequest, global::grpc.testing.StreamingOutputCallResponse> HalfDuplexCall(CallOptions options)
      {
        var call = CreateCall(__Method_HalfDuplexCall, options);
        return Calls.AsyncDuplexStreamingCall(call);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(ITestService serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_EmptyCall, serviceImpl.EmptyCall)
          .AddMethod(__Method_UnaryCall, serviceImpl.UnaryCall)
          .AddMethod(__Method_StreamingOutputCall, serviceImpl.StreamingOutputCall)
          .AddMethod(__Method_StreamingInputCall, serviceImpl.StreamingInputCall)
          .AddMethod(__Method_FullDuplexCall, serviceImpl.FullDuplexCall)
          .AddMethod(__Method_HalfDuplexCall, serviceImpl.HalfDuplexCall).Build();
    }

    // creates a new client
    public static TestServiceClient NewClient(Channel channel)
    {
      return new TestServiceClient(channel);
    }

  }
}
#endregion
