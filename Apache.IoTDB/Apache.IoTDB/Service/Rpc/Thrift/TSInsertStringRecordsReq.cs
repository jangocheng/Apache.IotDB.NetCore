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


namespace Apache.IoTDB.Service.Rpc.Thrift
{

  public partial class TSInsertStringRecordsReq : TBase
  {

    public long SessionId { get; set; }

    public List<string> DeviceIds { get; set; }

    public List<List<string>> MeasurementsList { get; set; }

    public List<List<string>> ValuesList { get; set; }

    public List<long> Timestamps { get; set; }

    public TSInsertStringRecordsReq()
    {
    }

    public TSInsertStringRecordsReq(long sessionId, List<string> deviceIds, List<List<string>> measurementsList, List<List<string>> valuesList, List<long> timestamps) : this()
    {
      this.SessionId = sessionId;
      this.DeviceIds = deviceIds;
      this.MeasurementsList = measurementsList;
      this.ValuesList = valuesList;
      this.Timestamps = timestamps;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionId = false;
        bool isset_deviceIds = false;
        bool isset_measurementsList = false;
        bool isset_valuesList = false;
        bool isset_timestamps = false;
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
              if (field.Type == TType.I64)
              {
                SessionId = await iprot.ReadI64Async(cancellationToken);
                isset_sessionId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list107 = await iprot.ReadListBeginAsync(cancellationToken);
                  DeviceIds = new List<string>(_list107.Count);
                  for(int _i108 = 0; _i108 < _list107.Count; ++_i108)
                  {
                    string _elem109;
                    _elem109 = await iprot.ReadStringAsync(cancellationToken);
                    DeviceIds.Add(_elem109);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_deviceIds = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list110 = await iprot.ReadListBeginAsync(cancellationToken);
                  MeasurementsList = new List<List<string>>(_list110.Count);
                  for(int _i111 = 0; _i111 < _list110.Count; ++_i111)
                  {
                    List<string> _elem112;
                    {
                      TList _list113 = await iprot.ReadListBeginAsync(cancellationToken);
                      _elem112 = new List<string>(_list113.Count);
                      for(int _i114 = 0; _i114 < _list113.Count; ++_i114)
                      {
                        string _elem115;
                        _elem115 = await iprot.ReadStringAsync(cancellationToken);
                        _elem112.Add(_elem115);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    MeasurementsList.Add(_elem112);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_measurementsList = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  TList _list116 = await iprot.ReadListBeginAsync(cancellationToken);
                  ValuesList = new List<List<string>>(_list116.Count);
                  for(int _i117 = 0; _i117 < _list116.Count; ++_i117)
                  {
                    List<string> _elem118;
                    {
                      TList _list119 = await iprot.ReadListBeginAsync(cancellationToken);
                      _elem118 = new List<string>(_list119.Count);
                      for(int _i120 = 0; _i120 < _list119.Count; ++_i120)
                      {
                        string _elem121;
                        _elem121 = await iprot.ReadStringAsync(cancellationToken);
                        _elem118.Add(_elem121);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    ValuesList.Add(_elem118);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_valuesList = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.List)
              {
                {
                  TList _list122 = await iprot.ReadListBeginAsync(cancellationToken);
                  Timestamps = new List<long>(_list122.Count);
                  for(int _i123 = 0; _i123 < _list122.Count; ++_i123)
                  {
                    long _elem124;
                    _elem124 = await iprot.ReadI64Async(cancellationToken);
                    Timestamps.Add(_elem124);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_timestamps = true;
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
        if (!isset_sessionId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_deviceIds)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_measurementsList)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_valuesList)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_timestamps)
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
        var struc = new TStruct("TSInsertStringRecordsReq");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "sessionId";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SessionId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "deviceIds";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, DeviceIds.Count), cancellationToken);
          foreach (string _iter125 in DeviceIds)
          {
            await oprot.WriteStringAsync(_iter125, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "measurementsList";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.List, MeasurementsList.Count), cancellationToken);
          foreach (List<string> _iter126 in MeasurementsList)
          {
            {
              await oprot.WriteListBeginAsync(new TList(TType.String, _iter126.Count), cancellationToken);
              foreach (string _iter127 in _iter126)
              {
                await oprot.WriteStringAsync(_iter127, cancellationToken);
              }
              await oprot.WriteListEndAsync(cancellationToken);
            }
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "valuesList";
        field.Type = TType.List;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.List, ValuesList.Count), cancellationToken);
          foreach (List<string> _iter128 in ValuesList)
          {
            {
              await oprot.WriteListBeginAsync(new TList(TType.String, _iter128.Count), cancellationToken);
              foreach (string _iter129 in _iter128)
              {
                await oprot.WriteStringAsync(_iter129, cancellationToken);
              }
              await oprot.WriteListEndAsync(cancellationToken);
            }
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "timestamps";
        field.Type = TType.List;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I64, Timestamps.Count), cancellationToken);
          foreach (long _iter130 in Timestamps)
          {
            await oprot.WriteI64Async(_iter130, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
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
      var other = that as TSInsertStringRecordsReq;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(SessionId, other.SessionId)
        && TCollections.Equals(DeviceIds, other.DeviceIds)
        && TCollections.Equals(MeasurementsList, other.MeasurementsList)
        && TCollections.Equals(ValuesList, other.ValuesList)
        && TCollections.Equals(Timestamps, other.Timestamps);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + SessionId.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DeviceIds);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(MeasurementsList);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ValuesList);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Timestamps);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSInsertStringRecordsReq(");
      sb.Append(", SessionId: ");
      sb.Append(SessionId);
      sb.Append(", DeviceIds: ");
      sb.Append(DeviceIds);
      sb.Append(", MeasurementsList: ");
      sb.Append(MeasurementsList);
      sb.Append(", ValuesList: ");
      sb.Append(ValuesList);
      sb.Append(", Timestamps: ");
      sb.Append(Timestamps);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
