namespace TransferLib;

public enum PacketType
{
    Error=0,
    Ping=1,
    Data=2,
    FileSyncInit=3,
    FileSyncInitResponse=4,
    FileSyncData=5,
    FileSyncUploadCheckHash=6,
    FileSyncUploadCheckHashResponse=7,
    FileSyncRetryUpload=8,
    FileSyncFinish=9,
    VersionHandshake=10,
    VersionHandshakeResponse=11,
    FileSyncHashCheck=12,
    FileSyncHashCheckResponse=13
}