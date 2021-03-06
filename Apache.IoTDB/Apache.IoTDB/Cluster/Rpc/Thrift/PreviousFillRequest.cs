/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.IoTDB.Cluster.Rpc.Thrift
{

  public partial class PreviousFillRequest : TBase
  {

    public string Path { get; set; }

    public long QueryTime { get; set; }

    public long BeforeRange { get; set; }

    public long QueryId { get; set; }

    public Node Requester { get; set; }

    public Node Header { get; set; }

    public int DataTypeOrdinal { get; set; }

    public THashSet<string> DeviceMeasurements { get; set; }

    public PreviousFillRequest()
    {
    }

    public PreviousFillRequest(string path, long queryTime, long beforeRange, long queryId, Node requester, Node header, int dataTypeOrdinal, THashSet<string> deviceMeasurements) : this()
    {
      this.Path = path;
      this.QueryTime = queryTime;
      this.BeforeRange = beforeRange;
      this.QueryId = queryId;
      this.Requester = requester;
      this.Header = header;
      this.DataTypeOrdinal = dataTypeOrdinal;
      this.DeviceMeasurements = deviceMeasurements;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_path = false;
        bool isset_queryTime = false;
        bool isset_beforeRange = false;
        bool isset_queryId = false;
        bool isset_requester = false;
        bool isset_header = false;
        bool isset_dataTypeOrdinal = false;
        bool isset_deviceMeasurements = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Path = await iprot.ReadStringAsync(cancellationToken);
                isset_path = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                QueryTime = await iprot.ReadI64Async(cancellationToken);
                isset_queryTime = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                BeforeRange = await iprot.ReadI64Async(cancellationToken);
                isset_beforeRange = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                QueryId = await iprot.ReadI64Async(cancellationToken);
                isset_queryId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                Requester = new Node();
                await Requester.ReadAsync(iprot, cancellationToken);
                isset_requester = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Struct)
              {
                Header = new Node();
                await Header.ReadAsync(iprot, cancellationToken);
                isset_header = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                DataTypeOrdinal = await iprot.ReadI32Async(cancellationToken);
                isset_dataTypeOrdinal = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Set)
              {
                {
                  TSet _set25 = await iprot.ReadSetBeginAsync(cancellationToken);
                  DeviceMeasurements = new THashSet<string>(_set25.Count);
                  for(int _i26 = 0; _i26 < _set25.Count; ++_i26)
                  {
                    string _elem27;
                    _elem27 = await iprot.ReadStringAsync(cancellationToken);
                    DeviceMeasurements.Add(_elem27);
                  }
                  await iprot.ReadSetEndAsync(cancellationToken);
                }
                isset_deviceMeasurements = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_path)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_queryTime)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_beforeRange)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_queryId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_requester)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_header)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_dataTypeOrdinal)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_deviceMeasurements)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("PreviousFillRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "path";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Path, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "queryTime";
        field.Type = TType.I64;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(QueryTime, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "beforeRange";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(BeforeRange, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "queryId";
        field.Type = TType.I64;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(QueryId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "requester";
        field.Type = TType.Struct;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Requester.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "header";
        field.Type = TType.Struct;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Header.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "dataTypeOrdinal";
        field.Type = TType.I32;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(DataTypeOrdinal, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "deviceMeasurements";
        field.Type = TType.Set;
        field.ID = 8;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteSetBeginAsync(new TSet(TType.String, DeviceMeasurements.Count), cancellationToken);
          foreach (string _iter28 in DeviceMeasurements)
          {
            await oprot.WriteStringAsync(_iter28, cancellationToken);
          }
          await oprot.WriteSetEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as PreviousFillRequest;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Path, other.Path)
        && System.Object.Equals(QueryTime, other.QueryTime)
        && System.Object.Equals(BeforeRange, other.BeforeRange)
        && System.Object.Equals(QueryId, other.QueryId)
        && System.Object.Equals(Requester, other.Requester)
        && System.Object.Equals(Header, other.Header)
        && System.Object.Equals(DataTypeOrdinal, other.DataTypeOrdinal)
        && TCollections.Equals(DeviceMeasurements, other.DeviceMeasurements);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Path.GetHashCode();
        hashcode = (hashcode * 397) + QueryTime.GetHashCode();
        hashcode = (hashcode * 397) + BeforeRange.GetHashCode();
        hashcode = (hashcode * 397) + QueryId.GetHashCode();
        hashcode = (hashcode * 397) + Requester.GetHashCode();
        hashcode = (hashcode * 397) + Header.GetHashCode();
        hashcode = (hashcode * 397) + DataTypeOrdinal.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DeviceMeasurements);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("PreviousFillRequest(");
      sb.Append(", Path: ");
      sb.Append(Path);
      sb.Append(", QueryTime: ");
      sb.Append(QueryTime);
      sb.Append(", BeforeRange: ");
      sb.Append(BeforeRange);
      sb.Append(", QueryId: ");
      sb.Append(QueryId);
      sb.Append(", Requester: ");
      sb.Append(Requester== null ? "<null>" : Requester.ToString());
      sb.Append(", Header: ");
      sb.Append(Header== null ? "<null>" : Header.ToString());
      sb.Append(", DataTypeOrdinal: ");
      sb.Append(DataTypeOrdinal);
      sb.Append(", DeviceMeasurements: ");
      sb.Append(DeviceMeasurements);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
