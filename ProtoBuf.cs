using ProtoBuf;

namespace TransferLib;

public class ProtoBuf
{
    
}

[ProtoContract]
public struct VersionHandshakeResponse
{

    [ProtoMember(1)]
    public required ushort Version { get; set; }
    
    [ProtoMember(2)]
    public required ApplicationVersionCompatibilityLevel ApplicationVersionCompatibilityLevel { get; set; }
}

[ProtoContract]
public struct VersionHandshake
{
    [ProtoMember(1)]
    public required ushort Version { get; set; }
}

[ProtoContract]
public struct FSSyncData
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required byte[] FileData { get; set; }
    [ProtoMember(3)]
    public required short Length { get; set; }
}

[ProtoContract]
public struct FsInit
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

    /// <summary>
    /// THAT WAS A DUMB DECISION… changing it to Guid since thats it's purpose… to be a GUID…
    /// </summary>
    [ProtoMember(8)]
    public required Guid FuuId;

    public FsInit()
    {
        
    }
}

[ProtoContract]
public struct FSInitResponse
{
    [ProtoMember(1)] 
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required bool IsAccepted  { get; set; }
}

[ProtoContract]
public struct FSUploadCheckHash
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required ulong Hash { get; set; }
}

[ProtoContract]
public struct FSUploadCheckHashResponse
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
    [ProtoMember(2)]
    public required bool IsCorrect { get; set; }
}

[ProtoContract]
public struct FSFinish
{
    [ProtoMember(1)]
    public required byte FileId { get; set; }
}

[ProtoContract]
public struct FSHashCheck
{
    public List<HashCheckPair> HashCheckPairs { get; set; }
}
[ProtoContract]
public struct FSHashCheckResponse
{
    public List<Guid> Changed { get; set; }
}