using ProtoBuf;

namespace TransferLib;

public class ProtoBuf
{
    
}

[ProtoContract]
public class VersionHandshakeResponse
{

    [ProtoMember(1)]
    public required ushort Version { get; set; }
    
    [ProtoMember(2)]
    public required ApplicationVersionCompatibilityLevel ApplicationVersionCompatibilityLevel { get; set; }
}

[ProtoContract]
public class VersionHandshake
{
    [ProtoMember(1)]
    public required ushort Version { get; set; }
}

[ProtoContract]
public class FSSyncData
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required byte[] FileData { get; set; }
    [ProtoMember(3)]
    public required short Length { get; set; }
}

[ProtoContract]
public class FsInit
{

    [ProtoMember(1)]
    public required byte FileId { get; set; }

    [ProtoMember(2)]
    public required string FilePath { get; set; }

    [ProtoMember(3)]
    public required long FileSize  { get; set; }
    [ProtoMember(4)]
    public required string FileName  { get; set; }
    [ProtoMember(5)]
    public required DateTime LastAccessTime { get; set; }
    [ProtoMember(6)]
    public required DateTime LastWriteTime { get; set; }
    [ProtoMember(7)]
    public required DateTime CreationTime { get; set; }

    [ProtoMember(8)] 
    public required byte[] FuuId = new byte[16]; 

    public FsInit()
    {
        
    }
}

[ProtoContract]
public class FSInitResponse
{
    [ProtoMember(1)] 
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required bool IsAccepted  { get; set; }
}

[ProtoContract]
public class FSCheckHash
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required ulong Hash { get; set; }
}

[ProtoContract]
public class FSCheckHashResponse
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required bool IsCorrect { get; set; }
}

[ProtoContract]
public class FSFinish
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
}