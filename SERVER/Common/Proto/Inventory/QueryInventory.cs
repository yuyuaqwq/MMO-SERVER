// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Inventory/QueryInventory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Common.Proto.Inventory {

  /// <summary>Holder for reflection information generated from Inventory/QueryInventory.proto</summary>
  public static partial class QueryInventoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/QueryInventory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryInventoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5JbnZlbnRvcnkvUXVlcnlJbnZlbnRvcnkucHJvdG8SFkNvbW1vbi5Qcm90",
            "by5JbnZlbnRvcnkaHUludmVudG9yeS9JbnZlbnRvcnlJbmZvLnByb3RvInQK",
            "FUludmVudG9yeVF1ZXJ5UmVxdWVzdBIRCgllbnRpdHlfaWQYASABKAUSFgoO",
            "cXVlcnlfa25hcHNhY2sYAiABKAgSFwoPcXVlcnlfa2FyZWhvdXNlGAMgASgI",
            "EhcKD3F1ZXJ5X2txdWlwbWVudBgEIAEoCCLnAQoWSW52ZW50b3J5UXVlcnlS",
            "ZXNwb25zZRIRCgllbnRpdHlfaWQYASABKAUSPAoNa25hcHNhY2tfaW5mbxgC",
            "IAEoCzIlLkNvbW1vbi5Qcm90by5JbnZlbnRvcnkuSW52ZW50b3J5SW5mbxI9",
            "Cg53YXJlaG91c2VfaW5mbxgDIAEoCzIlLkNvbW1vbi5Qcm90by5JbnZlbnRv",
            "cnkuSW52ZW50b3J5SW5mbxI9Cg5lcXVpcG1lbnRfaW5mbxgEIAEoCzIlLkNv",
            "bW1vbi5Qcm90by5JbnZlbnRvcnkuSW52ZW50b3J5SW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.Proto.Inventory.InventoryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Inventory.InventoryQueryRequest), global::Common.Proto.Inventory.InventoryQueryRequest.Parser, new[]{ "EntityId", "QueryKnapsack", "QueryKarehouse", "QueryKquipment" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Common.Proto.Inventory.InventoryQueryResponse), global::Common.Proto.Inventory.InventoryQueryResponse.Parser, new[]{ "EntityId", "KnapsackInfo", "WarehouseInfo", "EquipmentInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///查询背包信息
  /// </summary>
  public sealed partial class InventoryQueryRequest : pb::IMessage<InventoryQueryRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InventoryQueryRequest> _parser = new pb::MessageParser<InventoryQueryRequest>(() => new InventoryQueryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InventoryQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Inventory.QueryInventoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryRequest(InventoryQueryRequest other) : this() {
      entityId_ = other.entityId_;
      queryKnapsack_ = other.queryKnapsack_;
      queryKarehouse_ = other.queryKarehouse_;
      queryKquipment_ = other.queryKquipment_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryRequest Clone() {
      return new InventoryQueryRequest(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private int entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "query_knapsack" field.</summary>
    public const int QueryKnapsackFieldNumber = 2;
    private bool queryKnapsack_;
    /// <summary>
    ///是否查询背包
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool QueryKnapsack {
      get { return queryKnapsack_; }
      set {
        queryKnapsack_ = value;
      }
    }

    /// <summary>Field number for the "query_karehouse" field.</summary>
    public const int QueryKarehouseFieldNumber = 3;
    private bool queryKarehouse_;
    /// <summary>
    ///是否查询仓库
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool QueryKarehouse {
      get { return queryKarehouse_; }
      set {
        queryKarehouse_ = value;
      }
    }

    /// <summary>Field number for the "query_kquipment" field.</summary>
    public const int QueryKquipmentFieldNumber = 4;
    private bool queryKquipment_;
    /// <summary>
    ///是否查询装备栏
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool QueryKquipment {
      get { return queryKquipment_; }
      set {
        queryKquipment_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InventoryQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InventoryQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (QueryKnapsack != other.QueryKnapsack) return false;
      if (QueryKarehouse != other.QueryKarehouse) return false;
      if (QueryKquipment != other.QueryKquipment) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (QueryKnapsack != false) hash ^= QueryKnapsack.GetHashCode();
      if (QueryKarehouse != false) hash ^= QueryKarehouse.GetHashCode();
      if (QueryKquipment != false) hash ^= QueryKquipment.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (QueryKnapsack != false) {
        output.WriteRawTag(16);
        output.WriteBool(QueryKnapsack);
      }
      if (QueryKarehouse != false) {
        output.WriteRawTag(24);
        output.WriteBool(QueryKarehouse);
      }
      if (QueryKquipment != false) {
        output.WriteRawTag(32);
        output.WriteBool(QueryKquipment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (QueryKnapsack != false) {
        output.WriteRawTag(16);
        output.WriteBool(QueryKnapsack);
      }
      if (QueryKarehouse != false) {
        output.WriteRawTag(24);
        output.WriteBool(QueryKarehouse);
      }
      if (QueryKquipment != false) {
        output.WriteRawTag(32);
        output.WriteBool(QueryKquipment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityId);
      }
      if (QueryKnapsack != false) {
        size += 1 + 1;
      }
      if (QueryKarehouse != false) {
        size += 1 + 1;
      }
      if (QueryKquipment != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InventoryQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.QueryKnapsack != false) {
        QueryKnapsack = other.QueryKnapsack;
      }
      if (other.QueryKarehouse != false) {
        QueryKarehouse = other.QueryKarehouse;
      }
      if (other.QueryKquipment != false) {
        QueryKquipment = other.QueryKquipment;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 16: {
            QueryKnapsack = input.ReadBool();
            break;
          }
          case 24: {
            QueryKarehouse = input.ReadBool();
            break;
          }
          case 32: {
            QueryKquipment = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 16: {
            QueryKnapsack = input.ReadBool();
            break;
          }
          case 24: {
            QueryKarehouse = input.ReadBool();
            break;
          }
          case 32: {
            QueryKquipment = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  ///角色的背包信息
  /// </summary>
  public sealed partial class InventoryQueryResponse : pb::IMessage<InventoryQueryResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InventoryQueryResponse> _parser = new pb::MessageParser<InventoryQueryResponse>(() => new InventoryQueryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InventoryQueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Common.Proto.Inventory.QueryInventoryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryResponse(InventoryQueryResponse other) : this() {
      entityId_ = other.entityId_;
      knapsackInfo_ = other.knapsackInfo_ != null ? other.knapsackInfo_.Clone() : null;
      warehouseInfo_ = other.warehouseInfo_ != null ? other.warehouseInfo_.Clone() : null;
      equipmentInfo_ = other.equipmentInfo_ != null ? other.equipmentInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InventoryQueryResponse Clone() {
      return new InventoryQueryResponse(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private int entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "knapsack_info" field.</summary>
    public const int KnapsackInfoFieldNumber = 2;
    private global::Common.Proto.Inventory.InventoryInfo knapsackInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Inventory.InventoryInfo KnapsackInfo {
      get { return knapsackInfo_; }
      set {
        knapsackInfo_ = value;
      }
    }

    /// <summary>Field number for the "warehouse_info" field.</summary>
    public const int WarehouseInfoFieldNumber = 3;
    private global::Common.Proto.Inventory.InventoryInfo warehouseInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Inventory.InventoryInfo WarehouseInfo {
      get { return warehouseInfo_; }
      set {
        warehouseInfo_ = value;
      }
    }

    /// <summary>Field number for the "equipment_info" field.</summary>
    public const int EquipmentInfoFieldNumber = 4;
    private global::Common.Proto.Inventory.InventoryInfo equipmentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Common.Proto.Inventory.InventoryInfo EquipmentInfo {
      get { return equipmentInfo_; }
      set {
        equipmentInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InventoryQueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InventoryQueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(KnapsackInfo, other.KnapsackInfo)) return false;
      if (!object.Equals(WarehouseInfo, other.WarehouseInfo)) return false;
      if (!object.Equals(EquipmentInfo, other.EquipmentInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (knapsackInfo_ != null) hash ^= KnapsackInfo.GetHashCode();
      if (warehouseInfo_ != null) hash ^= WarehouseInfo.GetHashCode();
      if (equipmentInfo_ != null) hash ^= EquipmentInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (knapsackInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(KnapsackInfo);
      }
      if (warehouseInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WarehouseInfo);
      }
      if (equipmentInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EquipmentInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EntityId);
      }
      if (knapsackInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(KnapsackInfo);
      }
      if (warehouseInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WarehouseInfo);
      }
      if (equipmentInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EquipmentInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityId);
      }
      if (knapsackInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KnapsackInfo);
      }
      if (warehouseInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WarehouseInfo);
      }
      if (equipmentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EquipmentInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InventoryQueryResponse other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.knapsackInfo_ != null) {
        if (knapsackInfo_ == null) {
          KnapsackInfo = new global::Common.Proto.Inventory.InventoryInfo();
        }
        KnapsackInfo.MergeFrom(other.KnapsackInfo);
      }
      if (other.warehouseInfo_ != null) {
        if (warehouseInfo_ == null) {
          WarehouseInfo = new global::Common.Proto.Inventory.InventoryInfo();
        }
        WarehouseInfo.MergeFrom(other.WarehouseInfo);
      }
      if (other.equipmentInfo_ != null) {
        if (equipmentInfo_ == null) {
          EquipmentInfo = new global::Common.Proto.Inventory.InventoryInfo();
        }
        EquipmentInfo.MergeFrom(other.EquipmentInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 18: {
            if (knapsackInfo_ == null) {
              KnapsackInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(KnapsackInfo);
            break;
          }
          case 26: {
            if (warehouseInfo_ == null) {
              WarehouseInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(WarehouseInfo);
            break;
          }
          case 34: {
            if (equipmentInfo_ == null) {
              EquipmentInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(EquipmentInfo);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EntityId = input.ReadInt32();
            break;
          }
          case 18: {
            if (knapsackInfo_ == null) {
              KnapsackInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(KnapsackInfo);
            break;
          }
          case 26: {
            if (warehouseInfo_ == null) {
              WarehouseInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(WarehouseInfo);
            break;
          }
          case 34: {
            if (equipmentInfo_ == null) {
              EquipmentInfo = new global::Common.Proto.Inventory.InventoryInfo();
            }
            input.ReadMessage(EquipmentInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
