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

  public partial class TSCreateMultiTimeseriesReq : TBase
  {
    private List<Dictionary<string, string>> _propsList;
    private List<Dictionary<string, string>> _tagsList;
    private List<Dictionary<string, string>> _attributesList;
    private List<string> _measurementAliasList;

    public long SessionId { get; set; }

    public List<string> Paths { get; set; }

    public List<int> DataTypes { get; set; }

    public List<int> Encodings { get; set; }

    public List<int> Compressors { get; set; }

    public List<Dictionary<string, string>> PropsList
    {
      get
      {
        return _propsList;
      }
      set
      {
        __isset.propsList = true;
        this._propsList = value;
      }
    }

    public List<Dictionary<string, string>> TagsList
    {
      get
      {
        return _tagsList;
      }
      set
      {
        __isset.tagsList = true;
        this._tagsList = value;
      }
    }

    public List<Dictionary<string, string>> AttributesList
    {
      get
      {
        return _attributesList;
      }
      set
      {
        __isset.attributesList = true;
        this._attributesList = value;
      }
    }

    public List<string> MeasurementAliasList
    {
      get
      {
        return _measurementAliasList;
      }
      set
      {
        __isset.measurementAliasList = true;
        this._measurementAliasList = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool propsList;
      public bool tagsList;
      public bool attributesList;
      public bool measurementAliasList;
    }

    public TSCreateMultiTimeseriesReq()
    {
    }

    public TSCreateMultiTimeseriesReq(long sessionId, List<string> paths, List<int> dataTypes, List<int> encodings, List<int> compressors) : this()
    {
      this.SessionId = sessionId;
      this.Paths = paths;
      this.DataTypes = dataTypes;
      this.Encodings = encodings;
      this.Compressors = compressors;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionId = false;
        bool isset_paths = false;
        bool isset_dataTypes = false;
        bool isset_encodings = false;
        bool isset_compressors = false;
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
                  TList _list150 = await iprot.ReadListBeginAsync(cancellationToken);
                  Paths = new List<string>(_list150.Count);
                  for(int _i151 = 0; _i151 < _list150.Count; ++_i151)
                  {
                    string _elem152;
                    _elem152 = await iprot.ReadStringAsync(cancellationToken);
                    Paths.Add(_elem152);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_paths = true;
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
                  TList _list153 = await iprot.ReadListBeginAsync(cancellationToken);
                  DataTypes = new List<int>(_list153.Count);
                  for(int _i154 = 0; _i154 < _list153.Count; ++_i154)
                  {
                    int _elem155;
                    _elem155 = await iprot.ReadI32Async(cancellationToken);
                    DataTypes.Add(_elem155);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_dataTypes = true;
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
                  TList _list156 = await iprot.ReadListBeginAsync(cancellationToken);
                  Encodings = new List<int>(_list156.Count);
                  for(int _i157 = 0; _i157 < _list156.Count; ++_i157)
                  {
                    int _elem158;
                    _elem158 = await iprot.ReadI32Async(cancellationToken);
                    Encodings.Add(_elem158);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_encodings = true;
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
                  TList _list159 = await iprot.ReadListBeginAsync(cancellationToken);
                  Compressors = new List<int>(_list159.Count);
                  for(int _i160 = 0; _i160 < _list159.Count; ++_i160)
                  {
                    int _elem161;
                    _elem161 = await iprot.ReadI32Async(cancellationToken);
                    Compressors.Add(_elem161);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_compressors = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.List)
              {
                {
                  TList _list162 = await iprot.ReadListBeginAsync(cancellationToken);
                  PropsList = new List<Dictionary<string, string>>(_list162.Count);
                  for(int _i163 = 0; _i163 < _list162.Count; ++_i163)
                  {
                    Dictionary<string, string> _elem164;
                    {
                      TMap _map165 = await iprot.ReadMapBeginAsync(cancellationToken);
                      _elem164 = new Dictionary<string, string>(_map165.Count);
                      for(int _i166 = 0; _i166 < _map165.Count; ++_i166)
                      {
                        string _key167;
                        string _val168;
                        _key167 = await iprot.ReadStringAsync(cancellationToken);
                        _val168 = await iprot.ReadStringAsync(cancellationToken);
                        _elem164[_key167] = _val168;
                      }
                      await iprot.ReadMapEndAsync(cancellationToken);
                    }
                    PropsList.Add(_elem164);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.List)
              {
                {
                  TList _list169 = await iprot.ReadListBeginAsync(cancellationToken);
                  TagsList = new List<Dictionary<string, string>>(_list169.Count);
                  for(int _i170 = 0; _i170 < _list169.Count; ++_i170)
                  {
                    Dictionary<string, string> _elem171;
                    {
                      TMap _map172 = await iprot.ReadMapBeginAsync(cancellationToken);
                      _elem171 = new Dictionary<string, string>(_map172.Count);
                      for(int _i173 = 0; _i173 < _map172.Count; ++_i173)
                      {
                        string _key174;
                        string _val175;
                        _key174 = await iprot.ReadStringAsync(cancellationToken);
                        _val175 = await iprot.ReadStringAsync(cancellationToken);
                        _elem171[_key174] = _val175;
                      }
                      await iprot.ReadMapEndAsync(cancellationToken);
                    }
                    TagsList.Add(_elem171);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.List)
              {
                {
                  TList _list176 = await iprot.ReadListBeginAsync(cancellationToken);
                  AttributesList = new List<Dictionary<string, string>>(_list176.Count);
                  for(int _i177 = 0; _i177 < _list176.Count; ++_i177)
                  {
                    Dictionary<string, string> _elem178;
                    {
                      TMap _map179 = await iprot.ReadMapBeginAsync(cancellationToken);
                      _elem178 = new Dictionary<string, string>(_map179.Count);
                      for(int _i180 = 0; _i180 < _map179.Count; ++_i180)
                      {
                        string _key181;
                        string _val182;
                        _key181 = await iprot.ReadStringAsync(cancellationToken);
                        _val182 = await iprot.ReadStringAsync(cancellationToken);
                        _elem178[_key181] = _val182;
                      }
                      await iprot.ReadMapEndAsync(cancellationToken);
                    }
                    AttributesList.Add(_elem178);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.List)
              {
                {
                  TList _list183 = await iprot.ReadListBeginAsync(cancellationToken);
                  MeasurementAliasList = new List<string>(_list183.Count);
                  for(int _i184 = 0; _i184 < _list183.Count; ++_i184)
                  {
                    string _elem185;
                    _elem185 = await iprot.ReadStringAsync(cancellationToken);
                    MeasurementAliasList.Add(_elem185);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        if (!isset_paths)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_dataTypes)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_encodings)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_compressors)
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
        var struc = new TStruct("TSCreateMultiTimeseriesReq");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "sessionId";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SessionId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "paths";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Paths.Count), cancellationToken);
          foreach (string _iter186 in Paths)
          {
            await oprot.WriteStringAsync(_iter186, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "dataTypes";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, DataTypes.Count), cancellationToken);
          foreach (int _iter187 in DataTypes)
          {
            await oprot.WriteI32Async(_iter187, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "encodings";
        field.Type = TType.List;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, Encodings.Count), cancellationToken);
          foreach (int _iter188 in Encodings)
          {
            await oprot.WriteI32Async(_iter188, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "compressors";
        field.Type = TType.List;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, Compressors.Count), cancellationToken);
          foreach (int _iter189 in Compressors)
          {
            await oprot.WriteI32Async(_iter189, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (PropsList != null && __isset.propsList)
        {
          field.Name = "propsList";
          field.Type = TType.List;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Map, PropsList.Count), cancellationToken);
            foreach (Dictionary<string, string> _iter190 in PropsList)
            {
              {
                await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, _iter190.Count), cancellationToken);
                foreach (string _iter191 in _iter190.Keys)
                {
                  await oprot.WriteStringAsync(_iter191, cancellationToken);
                  await oprot.WriteStringAsync(_iter190[_iter191], cancellationToken);
                }
                await oprot.WriteMapEndAsync(cancellationToken);
              }
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (TagsList != null && __isset.tagsList)
        {
          field.Name = "tagsList";
          field.Type = TType.List;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Map, TagsList.Count), cancellationToken);
            foreach (Dictionary<string, string> _iter192 in TagsList)
            {
              {
                await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, _iter192.Count), cancellationToken);
                foreach (string _iter193 in _iter192.Keys)
                {
                  await oprot.WriteStringAsync(_iter193, cancellationToken);
                  await oprot.WriteStringAsync(_iter192[_iter193], cancellationToken);
                }
                await oprot.WriteMapEndAsync(cancellationToken);
              }
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (AttributesList != null && __isset.attributesList)
        {
          field.Name = "attributesList";
          field.Type = TType.List;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Map, AttributesList.Count), cancellationToken);
            foreach (Dictionary<string, string> _iter194 in AttributesList)
            {
              {
                await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, _iter194.Count), cancellationToken);
                foreach (string _iter195 in _iter194.Keys)
                {
                  await oprot.WriteStringAsync(_iter195, cancellationToken);
                  await oprot.WriteStringAsync(_iter194[_iter195], cancellationToken);
                }
                await oprot.WriteMapEndAsync(cancellationToken);
              }
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (MeasurementAliasList != null && __isset.measurementAliasList)
        {
          field.Name = "measurementAliasList";
          field.Type = TType.List;
          field.ID = 9;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, MeasurementAliasList.Count), cancellationToken);
            foreach (string _iter196 in MeasurementAliasList)
            {
              await oprot.WriteStringAsync(_iter196, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
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
      var other = that as TSCreateMultiTimeseriesReq;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(SessionId, other.SessionId)
        && TCollections.Equals(Paths, other.Paths)
        && TCollections.Equals(DataTypes, other.DataTypes)
        && TCollections.Equals(Encodings, other.Encodings)
        && TCollections.Equals(Compressors, other.Compressors)
        && ((__isset.propsList == other.__isset.propsList) && ((!__isset.propsList) || (TCollections.Equals(PropsList, other.PropsList))))
        && ((__isset.tagsList == other.__isset.tagsList) && ((!__isset.tagsList) || (TCollections.Equals(TagsList, other.TagsList))))
        && ((__isset.attributesList == other.__isset.attributesList) && ((!__isset.attributesList) || (TCollections.Equals(AttributesList, other.AttributesList))))
        && ((__isset.measurementAliasList == other.__isset.measurementAliasList) && ((!__isset.measurementAliasList) || (TCollections.Equals(MeasurementAliasList, other.MeasurementAliasList))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + SessionId.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Paths);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DataTypes);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Encodings);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Compressors);
        if(__isset.propsList)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(PropsList);
        if(__isset.tagsList)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(TagsList);
        if(__isset.attributesList)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(AttributesList);
        if(__isset.measurementAliasList)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(MeasurementAliasList);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSCreateMultiTimeseriesReq(");
      sb.Append(", SessionId: ");
      sb.Append(SessionId);
      sb.Append(", Paths: ");
      sb.Append(Paths);
      sb.Append(", DataTypes: ");
      sb.Append(DataTypes);
      sb.Append(", Encodings: ");
      sb.Append(Encodings);
      sb.Append(", Compressors: ");
      sb.Append(Compressors);
      if (PropsList != null && __isset.propsList)
      {
        sb.Append(", PropsList: ");
        sb.Append(PropsList);
      }
      if (TagsList != null && __isset.tagsList)
      {
        sb.Append(", TagsList: ");
        sb.Append(TagsList);
      }
      if (AttributesList != null && __isset.attributesList)
      {
        sb.Append(", AttributesList: ");
        sb.Append(AttributesList);
      }
      if (MeasurementAliasList != null && __isset.measurementAliasList)
      {
        sb.Append(", MeasurementAliasList: ");
        sb.Append(MeasurementAliasList);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
