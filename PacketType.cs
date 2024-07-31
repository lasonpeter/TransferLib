namespace TransferLib;

public enum PacketType
{
    Error=0,
    Ping=1,
    Data=2,
    FileSyncInit=3,
    FileSyncInitResponse=4,
    FileSyncData=5,
    FileSyncCheckHash=6,
    FileSyncCheckHashResponse=7,
    FileSyncRetryUpload=8,
    FileSyncFinish=9,
    VersionHandshake=10,
    VersionHandshakeResponse=11
}